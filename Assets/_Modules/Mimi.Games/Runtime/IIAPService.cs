namespace Mimi.Games
{
    public interface IIAPService : IService
    {
        public void Purchase(string productId);
    }
}