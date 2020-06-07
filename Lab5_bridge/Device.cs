namespace BridgePattern
{
    /// <summary>
    /// The common interface of all devices
    /// </summary>
    public interface Device
    {      
        bool IsEnabled();
        void Enable();
        void Disable();
        int GetChannel();
        void SetChannel(int channel);
        int GetVolume();
        void SetVolume(int volume);
    }
}