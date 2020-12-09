using System;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Copier kopiareczka = new Copier();
            kopiareczka.PowerOn();
            TextDocument txt = new TextDocument("napewnodziała");
            PDFDocument pdf = new PDFDocument("nochybadziała");
            kopiareczka.Print(pdf);
            kopiareczka.ScanAndPrint();
            kopiareczka.PowerOff();
            IDocument doc;
            kopiareczka.Scan(out doc);
            kopiareczka.PowerOn();
            IDocument doc2;
            kopiareczka.Scan(out doc2);
            kopiareczka.PowerOff();
            kopiareczka.PowerOff();
            kopiareczka.PowerOff();
            MultifunctionalDevice allinone = new MultifunctionalDevice();
            allinone.PowerOn();
            allinone.Fax(txt, "991");
            

        }
    }
}
