using UnityEngine;

namespace Mimi.Games
{
    public class AdService : BaseAdService
    {
        [SerializeField] private BaseAdService[] decorators;

        protected override IAdAdapter CreateAdAdapter()
        {
            return new LogAds();
        }
    }
}