namespace BridgePattern
{
    /// <summary>
    /// The remote control class has a link to the device it controls.
    /// Methods of this class delegate work to methods of the associated device.
    /// </summary>
    public class Remote
    {
        protected Device device { get; set; }

        public Remote(Device device)
        {
            this.device = device;
        }

        public void Enable()
        {
            device.Enable();
        }

        public void Disable()
        {
            device.Disable();
        }

        public void ChannelUp()
        {
            device.SetChannel(device.GetChannel() + 4);
        }

        public void ChannelDown()
        {
            device.SetChannel(device.GetChannel() - 8);
        }

        public void VolumeUp()
        {
            device.SetVolume(device.GetVolume() + 10);
        }

        public void VolumeDown()
        {
            device.SetVolume(device.GetVolume() - 5);
        }
    }
}