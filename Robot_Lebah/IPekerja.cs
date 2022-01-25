using System;
using System.Collections.Generic;
using System.Text;

namespace Robot_Lebah
{
    interface IPekerja
    {
        string Kerjaan { get; }
        void KerjaanSelanjutnya();
    }
}
