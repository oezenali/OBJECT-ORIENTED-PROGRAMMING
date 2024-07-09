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
using Savas.Library.Enum;

namespace Savas.Library.Interface
{
    internal interface IHareketEden
    {
        Size HareketAlaniBoyutlari { get; }

        int HareketMesafesi { get; }
        
        /// <summary>
        /// Cismi istenilen yönde hareket ettirir
        /// </summary>
        /// <param name="yon">Hangi yöne hareket edileceği</param>
        /// <returns>Cisim duvara çaparsa true döndürür.</returns>
        bool HareketEttir(Yon yon);
    }
}
