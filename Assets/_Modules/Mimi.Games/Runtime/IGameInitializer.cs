namespace Mimi.Games
{
    public interface IGameInitializer
    {
        int CurrentStep { get; }
        int TotalSteps { get; }
        public void Initialize();
    }
}