using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie3
{
    class Printer : BaseDevice, IPrinter
    {
        public int PrintCount { get; private set; } = 0;

        public void Print(in IDocument doc)
        {

            if (this.state == IDevice.State.on)
            {
                PrintCount += 1;
                DateTime date = new DateTime();
                Console.WriteLine($"{date} Print: {doc.GetFileName()}");
            }

        }
    }
}
