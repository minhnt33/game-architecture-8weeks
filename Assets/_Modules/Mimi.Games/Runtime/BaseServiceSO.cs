using UnityEngine;

namespace Mimi.Games
{
    public abstract class BaseServiceSO : ScriptableObject, IService
    {
        public abstract void Initialize();
        public abstract void Dispose();
    }
}