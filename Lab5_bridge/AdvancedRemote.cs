namespace BridgePattern
{
    /// <summary>
    /// Class where we can expand the class of remotes without touching the device code.
    /// </summary>
    public class AdvancedRemote : Remote
    {
        public AdvancedRemote(Device device) : base(device) { }

        public void Mute()
        {
            device.SetVolume(0);
        }
    }
}