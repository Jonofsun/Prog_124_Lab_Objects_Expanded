using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Lab_Objects_Expanded
{
    internal class Headphones
    {
        AudioTransmitionType _audioTransmitionType;
        //string _brand;
        //string _styleOfHeadphones;
        //string _modle;
        //int _frequency;

        public Headphones(AudioTransmitionType audioTransmitionType/*, string brand, string styleOfHeadphones, string modle, int frequency*/)
        {
            _audioTransmitionType = audioTransmitionType;
            //_brand = brand;
            //_styleOfHeadphones = styleOfHeadphones;
            //_modle = modle;
            //_frequency = frequency;
        }

        public AudioTransmitionType AudioTransmitionType { get => _audioTransmitionType; set => _audioTransmitionType = value; }
        //public string Brand { get => _brand; set => _brand = value; }
        //public string StyleOfHeadphones { get => _styleOfHeadphones; set => _styleOfHeadphones = value; }
        //public string Modle { get => _modle; set => _modle = value; }
        //public int Frequency { get => _frequency; set => _frequency = value; }
    }
}
