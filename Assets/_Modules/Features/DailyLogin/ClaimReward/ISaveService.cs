namespace DailyLogins
{
    public interface ISaveService
    {
        bool IsFull { get; }
        void Save();
        void CleanUp();
        void SaveCloud();
    }
}