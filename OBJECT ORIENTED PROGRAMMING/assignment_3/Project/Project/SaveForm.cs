/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2020-2021 BAHAR DÖNEMİ
**
** ÖDEV NUMARASI..........: Proje Ödevi
** ÖĞRENCİ ADI............: Muhammet Ali Ozen
** ÖĞRENCİ NUMARASI.......: b201200373
** DERSİN ALINDIĞI GRUP...: A
****************************************************************************/


using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ProjeOdevi
{
    public partial class SaveForm : Form
    {
        private int _gamePoint = 0;

        public SaveForm(int point)
        {
            InitializeComponent();

            _gamePoint = point;
            textBoxScore.Text = _gamePoint.ToString();

        }

        private void SaveScore()
        {
            String _scoresFilePath = @"GamePoint.txt";

            try
            {
                if (!File.Exists(_scoresFilePath))
                {
                    File.Create(_scoresFilePath).Dispose();
                }

                DataColumn nameColumn = new DataColumn("nickName", typeof(String));
                DataColumn scoreColumn = new DataColumn("score", typeof(int));

                DataTable scores = new DataTable();
                scores.Columns.Add(nameColumn);
                scores.Columns.Add(scoreColumn);

                using (StreamReader streamReader = new StreamReader(_scoresFilePath))
                {
                    streamReader.ReadLine();

                    while (!streamReader.EndOfStream)
                    {
                        String[] row = streamReader.ReadLine().Split(',');
                        scores.Rows.Add(row);
                    }
                }

                Boolean scoreFound = false;

                foreach (DataRow score in scores.Rows)
                {
                    if ((String)score["nickName"] == textBoxNickName.Text)
                    {
                        if ((int)score["score"] < _gamePoint)
                        {
                            score["score"] = _gamePoint;
                        }

                        scoreFound = true;
                        break;
                    }
                }

                if (!scoreFound)
                {
                    scores.Rows.Add(textBoxNickName.Text, _gamePoint);
                }

                scores.DefaultView.Sort = "score desc";
                scores = scores.DefaultView.ToTable(true);

                File.WriteAllText(_scoresFilePath, string.Empty);

                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("nickName,score");

                foreach (DataRow score in scores.Rows)
                {
                    stringBuilder.AppendLine(score["nickName"] + "," + score["score"]);
                }


                File.WriteAllText(_scoresFilePath, stringBuilder.ToString());
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:\n\n" + ex.ToString(), "Hata");
            }
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveScore();
        }
    }
}
