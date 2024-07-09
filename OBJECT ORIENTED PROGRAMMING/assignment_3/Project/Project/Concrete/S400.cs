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

using System.Drawing;
using Savas.Library.Abstract;

namespace Savas.Library.Concrete
{
    internal class S400 : Cisim
    {
        public S400(int panelGenisligi, Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
            Center = panelGenisligi / 2;
            HareketMesafesi = Width;
        }
    }
}
