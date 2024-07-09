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
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ProjeOdevi;
using Savas.Library.Enum;
using Savas.Library.Interface;

namespace Savas.Library.Concrete
{
    public class Game : IGame
    {
        #region Alanlar

        private readonly Timer _passingTimer = new Timer { Interval = 1000 };
        private readonly Timer _moveTimer = new Timer { Interval = 100 };
        private readonly Timer _planeCreationTimer = new Timer { Interval = 2000 };
        private TimeSpan _passingTime;
        private readonly Panel _s400Panel;
        private readonly Panel _battlegroundPanel;
        private S400 _s400;
        private readonly List<Bullet> _bullets = new List<Bullet>();
        private readonly List<F35> _warPlanes = new List<F35>();
        private Label _labelPoint;
        private int _gamePoint = 0;

        #endregion

        #region Olaylar

        public event EventHandler TimeChanged;

        #endregion

        #region Özellikler

        public bool DevamEdiyorMu { get; private set; }

        public TimeSpan PassingTime
        {
            get => _passingTime;
            private set
            {
                _passingTime = value;

                TimeChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        #endregion

        #region Metotlar

        public Game(Panel s400Panel, Panel battlegroundPanel, Label labelPoint)
        {
            _s400Panel = s400Panel;
            _battlegroundPanel = battlegroundPanel;
            _labelPoint = labelPoint;
            _labelPoint.Text = _gamePoint.ToString();

            _passingTimer.Tick += PassingTimer_Tick;
            _moveTimer.Tick += MoveTimer_Tick;
            _planeCreationTimer.Tick += PlaneCreationTimer_Tick;
        }

        private void PassingTimer_Tick(object sender, EventArgs e)
        {
            PassingTime += TimeSpan.FromSeconds(1);
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            MermileriHareketEttir();
            UcaklariHareketEttir();
            VurulanUcaklariCikar();
        }

        private void VurulanUcaklariCikar()
        {
            for (var i = _warPlanes.Count - 1; i >= 0; i--)
            {
                var ucak = _warPlanes[i];

                var vuranMermi = ucak.VurulduMu(_bullets);
                if (vuranMermi is null) continue;

                _warPlanes.Remove(ucak);
                _bullets.Remove(vuranMermi);
                _battlegroundPanel.Controls.Remove(ucak);
                _battlegroundPanel.Controls.Remove(vuranMermi);
                _gamePoint += 16;

                if (_gamePoint >= 50)
                {
                    _planeCreationTimer.Interval = 1500;
                }
                else if (_gamePoint >= 100)
                {
                    _planeCreationTimer.Interval = 1000;
                }
                else if (_gamePoint >= 200)
                {
                    _planeCreationTimer.Interval = 750;
                }
                else if (_gamePoint >= 350)
                {
                    _planeCreationTimer.Interval = 500;
                }

                _labelPoint.Text = _gamePoint.ToString();
            }
        }

        private void UcaklariHareketEttir()
        {
            foreach (var ucak in _warPlanes)
            {
                var carptiMi = ucak.HareketEttir(Yon.Asagi);
                if (!carptiMi) continue;

                BitirAsync();
                break;
            }
        }

        private void PlaneCreationTimer_Tick(object sender, EventArgs e)
        {
            UcakOlustur();
        }

        private void MermileriHareketEttir()
        {
            for (int i = _bullets.Count - 1; i >= 0; i--)
            {
                var bullet = _bullets[i];
                var carptiMi = bullet.HareketEttir(Yon.Yukari);
                if (carptiMi)
                {
                    _bullets.Remove(bullet);
                    _battlegroundPanel.Controls.Remove(bullet);
                }
            }
        }

        public void Baslat()
        {
            if (DevamEdiyorMu) return;

            DevamEdiyorMu = true;
            
            ZamanlayicilariBaslat();

            UcaksavarOlustur();
            UcakOlustur();
        }

        private void UcakOlustur()
        {
            var warplane = new F35(_battlegroundPanel.Size);
            _warPlanes.Add(warplane);
            _battlegroundPanel.Controls.Add(warplane);
        }

        private void ZamanlayicilariBaslat()
        {
            _passingTimer.Start();
            _moveTimer.Start();
            _planeCreationTimer.Start();
        }

        private void UcaksavarOlustur()
        {
            _s400 = new S400(_s400Panel.Width, _s400Panel.Size);
            _s400Panel.Controls.Add(_s400);
        }

        private async System.Threading.Tasks.Task BitirAsync()
        {
            if (!DevamEdiyorMu) return;

            DevamEdiyorMu = false;
            ZamanlayicilariDurdur();


            DialogResult dialogResult = MessageBox.Show("Skorunuzu kayıt etmek istiyor musunuz?", "Oyun sona erdi!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SaveForm saveForm = new SaveForm(_gamePoint);
                saveForm.Show();

            }
            else if (dialogResult == DialogResult.No)
            {
               
            }

        }

        private void ZamanlayicilariDurdur()
        {
            _passingTimer.Stop();
            _moveTimer.Stop();
            _planeCreationTimer.Stop();
        }

        public void AtesEt()
        {
            if (!DevamEdiyorMu) return;

            var bullet = new Bullet(_battlegroundPanel.Size, _s400.Center);
            _bullets.Add(bullet);
            _battlegroundPanel.Controls.Add(bullet);
        }

        public void UcaksavariHareketEttir(Yon yon)
        {
            if (!DevamEdiyorMu) return;

            _s400.HareketEttir(yon);
        }


        public void PauseTimer()
        {
            _passingTimer.Dispose();
            _moveTimer.Dispose();
            _planeCreationTimer.Dispose();
        }
        

        public void StartTimer()
        {
            _passingTimer.Start();
            _moveTimer.Start();
            _planeCreationTimer.Start();
        }

        #endregion
    }
}
