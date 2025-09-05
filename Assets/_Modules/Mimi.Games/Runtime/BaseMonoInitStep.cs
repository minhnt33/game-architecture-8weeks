using UnityEngine;

namespace Mimi.Games
{
    public abstract class BaseMonoInitStep : MonoBehaviour, IInitStep
    {
        public abstract void Initialize();
    }
}