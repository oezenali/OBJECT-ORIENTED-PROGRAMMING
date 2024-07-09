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


using Savas.Library.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ProjeOdevi
{
    public partial class BestScoreForm : Form
    {
        private readonly Game _game;

        public BestScoreForm(Game game)
        {
            InitializeComponent();

            _game = game;
            ReadBestScores();
        }


        private void ReadBestScores()
        {

            String _scoresFilePath = @"GamePoint.txt";

            StreamReader streamReader = new StreamReader(_scoresFilePath);

            List<string> lines = new();

            using (StreamReader r = new StreamReader(_scoresFilePath))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    lines.Add(line);
                    
                }
            }

            if (lines.Count > 6)
            {
                for (int i = 1; i < 6; i++)
                {
                    listBoxBestScores.Items.Add(lines[i]);
                }
            }
            else
            {
                for (int i = 1; i < lines.Count; i++)
                {
                    listBoxBestScores.Items.Add(lines[i]);
                }
            }

            streamReader.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            _game.StartTimer();

        }
    }
}
