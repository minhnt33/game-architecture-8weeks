using UnityEngine;

namespace Mimi.Games
{
    public class AdsInitStep : BaseMonoInitStep
    {
        [SerializeField] private BaseAdService adService;

        public override void Initialize()
        {
            this.adService.Initialize();
        }
    }
}