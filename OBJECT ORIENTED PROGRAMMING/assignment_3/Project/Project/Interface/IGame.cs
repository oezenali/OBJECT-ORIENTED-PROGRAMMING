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
using Savas.Library.Enum;

namespace Savas.Library.Interface
{
    internal interface IGame
    {
        event EventHandler TimeChanged;

        bool DevamEdiyorMu { get; }
        TimeSpan PassingTime { get; }

        void Baslat();
        void AtesEt();
        void UcaksavariHareketEttir(Yon yon);
    }
}
