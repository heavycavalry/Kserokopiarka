using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            
            var copier = new Copier();
            copier.PowerOn();
            copier.Print(new PDFDocument("dokument"));
            copier.ScanAndPrint();
                          
    }
    }
}
