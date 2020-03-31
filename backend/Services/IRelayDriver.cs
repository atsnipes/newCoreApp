namespace backend.Services
{
    public interface IRelayDriver
    {
        bool Write(int chnl, bool val);
    }
}
