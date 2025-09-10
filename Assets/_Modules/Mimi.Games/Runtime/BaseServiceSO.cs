using UnityEngine;

namespace Mimi.Games
{
    public abstract class BaseServiceSO : ScriptableObject, IService
    {
        public abstract void Initialize();
        public abstract void Dispose();
    }

    public abstract class BaseDecoratorSO : ScriptableObject
    {
        public abstract void Initialize(IAdService adService);
        public abstract void Dispose();
    }
}