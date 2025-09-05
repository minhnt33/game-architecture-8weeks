namespace Mimi.Games
{
    // Các service
    public interface IService
    {
        // Chung lifetime event
        public void Initialize();
        public void Dispose();
    }
}