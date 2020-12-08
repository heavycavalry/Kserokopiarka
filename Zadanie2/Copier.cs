using System;
using System.Transactions;
using Format = Zadanie1.IDocument.FormatType;

namespace Zadanie1
{
    public class Copier : BaseDevice, IPrinter, IScanner
    {

        private int ScanCount = 0;
        private int PrintCount = 0;
        private int Count = 0;
        public int PrintCounter { get { return PrintCount; } }
        public int ScanCounter { get { return ScanCount; } }
        public int Counter { get { return Count; } }


        public void PowerOn()
        {
            if (this.state == IDevice.State.off)
            {
                Count += 1;
            }
            base.PowerOn();
        }

        public void Print(in IDocument doc)
        {

            if (this.state == IDevice.State.on)
            {
                PrintCount += 1;
                DateTime date = new DateTime();
                Console.WriteLine($"{date} Print: {doc.GetFileName()}.{doc.GetFormatType()}");
            }
        
        }


        public void Scan(out IDocument document, IDocument.FormatType formatType = Format.JPG)
        {

            DateTime date = new DateTime();
            if (this.state == IDevice.State.on)
            {
                ScanCount += 1;

                if (formatType == Format.PDF)
                {
                    document = new PDFDocument($"PDFScan{ScanCounter}.pdf");
                    Console.WriteLine($"{date} Scan: PDFScan{ScanCounter}.pdf");
                    return;
                }

                if (formatType == Format.JPG)
                {
                    document = new ImageDocument($"ImageScan{ScanCounter}.jpg");
                    Console.WriteLine($"{date} Scan: ImageScan{ScanCounter}.jpg");
                    return;
                }

                if (formatType == Format.TXT)
                {
                    document = new TextDocument($" TextScan{ScanCounter}.txt");
                    Console.WriteLine($"{date} Scan: TextScan{ScanCounter}.txt");
                    return;
                }
            }

            document = null;
        }

        public void ScanAndPrint()
        {
            if (this.state == IDevice.State.on)
            {
                IDocument document;
                this.Scan(out document, Format.JPG);
                this.Print(document);
            }
        }


    }

}