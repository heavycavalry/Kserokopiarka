using System;
using Format = Zadanie3.IDocument.FormatType;

namespace Zadanie3
{
    class Scanner : BaseDevice, IScanner
    {
        public int ScanCount { get; private set; } = 0;
        public void Scan(out IDocument document, IDocument.FormatType formatType = Format.JPG)
        {

            DateTime date = new DateTime();
            if (this.state == IDevice.State.on)
            {
                ScanCount += 1;

                if (formatType == Format.PDF)
                {
                    document = new PDFDocument($"PDFScan{ScanCount}.pdf");
                    Console.WriteLine($"{date} Scan: PDFScan{ScanCount}.pdf");
                    return;
                }

                if (formatType == Format.JPG)
                {
                    document = new ImageDocument($"ImageScan{ScanCount}.jpg");
                    Console.WriteLine($"{date} Scan: ImageScan{ScanCount}.jpg");
                    return;
                }

                if (formatType == Format.TXT)
                {
                    document = new TextDocument($" TextScan{ScanCount}.txt");
                    Console.WriteLine($"{date} Scan: TextScan{ScanCount}.txt");
                    return;
                }
            }

            document = null;
        }
    }
}
