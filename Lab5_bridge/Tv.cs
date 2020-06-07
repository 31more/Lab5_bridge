using System;

namespace BridgePattern
{
    /// <summary>
    /// TV class with special realisation 
    /// </summary>
    public class Tv : Device
    {
        private bool isEnabled { get; set; }
        private int channel { get; set; }
        private int volume { get; set; }

        public Tv()
        {
            isEnabled = false;
            channel = 1;
            volume = 10;
        }

        public bool IsEnabled()
        {
            Console.WriteLine($"TV is enabled: {isEnabled}.");
            return isEnabled;
        }

        public void Enable()
        {
            isEnabled = true;
            Console.WriteLine("TV is enabled.");
        }

        public void Disable()
        {
            isEnabled = false;
            Console.WriteLine("TV is disabled.");
        }

        public int GetChannel()
        {
            return channel;
        }

        public void SetChannel(int channel)
        {
            this.channel = channel;
            Console.WriteLine($"TV channel has changed to the {channel}.");
        }

        public int GetVolume()
        {
            return volume;
        }

        public void SetVolume(int volume)
        {
            this.volume = volume;
            Console.WriteLine($"TV volume has changed to the {volume}.");
        }
    }
}