using UnityEngine;

namespace Mimi.Games
{
    public class SequenceInitializer : BaseMonoGameInitializer
    {
        [SerializeField] private BaseMonoInitStep[] initSteps;

        public override int TotalSteps => this.initSteps.Length; // Single source of truth

        public override void Initialize()
        {
            foreach (IInitStep initStep in this.initSteps)
            {
                initStep.Initialize();
                NextStep();
            }
        }
    }
}