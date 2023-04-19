using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Lab_Objects_Expanded
{
    internal class AudioPlus
    {
        List<Headphones> _audioPlusStock;
        int _inventory;



        public AudioPlus()
        {
            _audioPlusStock = new List<Headphones>();
        }

        public List<Headphones> AudioPlusStock { get => _audioPlusStock; }
        public int Inventory { get => _inventory; set => _inventory = value; }

        public void AddAudioPlus(Headphones audioPlus)
        {
            _audioPlusStock.Add(audioPlus);
        }
        public void AddAudioPlus(AudioTransmitionType type)
        {
            Headphones headphones = new Headphones(type);
            _audioPlusStock.Add(headphones);
        }
    }
}
