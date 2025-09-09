using UnityEngine;

namespace Mimi.Games
{
    [CreateAssetMenu(fileName = "TrackingAdsService", menuName = "Mimi/TrackingAdsService")]
    public class TrackingAdsService : BaseAdService
    {
        protected override IAdAdapter CreateAdAdapter()
        {
            return new TrackingAds();
        }
    }
}