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
using Savas.Library.Enum;
using System;
using System.Windows.Forms;

namespace ProjeOdevi
{
    public partial class Form1 : Form
    {

        private readonly Game _game;

        public Form1()
        {
            InitializeComponent();

            _game = new Game(s400Panel, battlegroundPanel, labelPoint);
            _game.TimeChanged += Game_TimeChanged;
        }


        private void AnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    KeyEnterEvent();
                    break;
                case Keys.Right:
                    _game.UcaksavariHareketEttir(Yon.Saga);
                    break;
                case Keys.Left:
                    _game.UcaksavariHareketEttir(Yon.Sola);
                    break;
                case Keys.Space:
                    _game.AtesEt();
                    break;
                case Keys.Escape:
                    KeyEscapeEvent();
                    break;

            }
        }

        private void KeyEnterEvent()
        {
            Focus();
            buttonBestScore.Enabled = false;
            _game.Baslat();
        }    
        private void KeyEscapeEvent()
        {
            buttonBestScore.Enabled = true;
            _game.PauseTimer();
        }

        private void Game_TimeChanged(object sender, EventArgs e)
        {
            timelabel.Text = _game.PassingTime.ToString(@"m\:ss");
        }

        private void savasAlaniPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bilgiLabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonBestScore_Click(object sender, EventArgs e)
        {
            BestScoreForm bestScoreForm = new BestScoreForm(_game);
            bestScoreForm.Show();
            buttonBestScore.Enabled = false;
            _game.PauseTimer();
        }

        private void timelabel_Click(object sender, EventArgs e)
        {

        }

    }
}
