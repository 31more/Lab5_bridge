using System;

namespace BridgePattern
{
    /// <summary>
    /// Radio class with special realisation
    /// </summary>
    public class Radio : Device
    {
        private bool isEnabled { get; set; }
        private int channel { get; set; }
        private int volume { get; set; }

        public Radio()
        {
            isEnabled = false;
            channel = 4;
            volume = 5;
        }

        public bool IsEnabled()
        {
            Console.WriteLine($"Radio is enabled: {isEnabled}.");
            return isEnabled;
        }

        public void Enable()
        {
            isEnabled = true;
            Console.WriteLine("Radio is enabled.");
        }

        public void Disable()
        {
            isEnabled = false;
            Console.WriteLine("Radio is disabled.");
        }

        public int GetChannel()
        {
            return channel;
        }

        public void SetChannel(int channel)
        {
            this.channel = channel;
            Console.WriteLine($"Radio wave has changed to the {channel}.");
        }

        public int GetVolume()
        {
            return volume;
        }

        public void SetVolume(int volume)
        {
            this.volume = volume;
            Console.WriteLine($"Radio volume has changed to the {volume}.");
        }
    }
}