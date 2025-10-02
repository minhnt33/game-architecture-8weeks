namespace DailyLogins
{
    public interface ITrackingService
    {
        void Log(string eventName, params object[] args);
    }
}