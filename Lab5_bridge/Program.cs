using System;

namespace BridgePattern
{
    /// <summary>
    /// The base class, client code
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Tv tv = new Tv();
            Radio radio = new Radio();

            Remote remote = new Remote(tv);
            remote.Enable();
            remote.VolumeUp();
            remote.Disable();

            Console.WriteLine();

            AdvancedRemote advancedRemote = new AdvancedRemote(radio);
            advancedRemote.Enable();
            advancedRemote.ChannelUp();
            advancedRemote.Mute();
            advancedRemote.Disable();

            Console.ReadKey();
        }
    }
}