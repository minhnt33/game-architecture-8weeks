using UnityEngine;

namespace Mimi.Games
{
    public abstract class BaseMonoGameInitializer : MonoBehaviour, IGameInitializer
    {
        public int CurrentStep { private set; get; }
        public abstract int TotalSteps { get; }
        public abstract void Initialize();

        protected void NextStep()
        {
            CurrentStep++;
        }
    }
}