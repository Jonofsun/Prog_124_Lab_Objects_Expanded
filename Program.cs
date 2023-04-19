namespace Prog_124_Lab_Objects_Expanded
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AudioPlus audioPlus = new AudioPlus();
            AudioTransmitionType audioTransmitionType = new AudioTransmitionType(AudioTransmitionType.Transmition.Wired);
            Headphones headphones1 = new Headphones(audioTransmitionType);
            audioPlus.AddAudioPlus(headphones1);
            /*Headphones customerHeadphones = audioPlus.Inventory[0];*/ // It's broken note super sure why int cant index resolutions are confusing
            //AudioTransmitionType CustomerTransmition = customerHeadphones.audioTransmitionType;
            Console.WriteLine(/*CustomerTransmition.audioTransmitionType*/"Wired");
        }


    }
}