using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie3
{
    class Faxer : BaseDevice, IFax
    {
        public void Fax(in IDocument document, String number)
        {
            DateTime date = new DateTime();
            if (this.state == IDevice.State.on)
                Console.WriteLine($"{date} Send: {document.GetFileName()} to {number}");
        }
    }
}
