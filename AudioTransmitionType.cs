using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Lab_Objects_Expanded
{
    public class AudioTransmitionType
    {
        public enum Transmition { Wireless, Bluetooth, Wired}

        Transmition _transmition;

        public Transmition Transmition1 { get => _transmition; set => _transmition = value; }

        public AudioTransmitionType(Transmition transmition)
        {
            _transmition = transmition;
        }

        


    }
}
