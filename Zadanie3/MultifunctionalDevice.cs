using System;
using System.Collections.Generic;
using System.Text;
using Format = Zadanie3.IDocument.FormatType;

namespace Zadanie3
{
    public class MultifunctionalDevice : BaseDevice, IFax, IPrinter, IScanner
    {
        public int PrintCounter { get { return printer.PrintCount; } }
        public int ScanCounter { get { return scanner.ScanCount; } }

        private Scanner scanner = new Scanner();
        private Printer printer = new Printer();
        private Faxer fax = new Faxer();

        public void PowerOn()
        {
            if (this.state == IDevice.State.off)
            {
                Console.WriteLine("... Device is on !");
            }
            base.PowerOn();
            printer.PowerOn();
            scanner.PowerOn();
            fax.PowerOn();
        }

        public void PowerOff()
        {
            if (this.state == IDevice.State.on)
            {
                Console.WriteLine("... Device is off !");
            }
            base.PowerOff();
            printer.PowerOff();
            scanner.PowerOff();
            fax.PowerOff();

        }

        public void Print(in IDocument doc)
        {
            printer.Print(doc);
        }


        public void Scan(out IDocument document, IDocument.FormatType formatType = Format.JPG)
        {
            scanner.Scan(out document, formatType);
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

        public void Fax(in IDocument document, string number)
        {
            fax.Fax(document, number);
        }
    }
}

