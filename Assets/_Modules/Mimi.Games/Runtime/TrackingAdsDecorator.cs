using UnityEngine;

namespace Mimi.Games
{
    [CreateAssetMenu(fileName = "TrackingAdsDecorator", menuName = "Mimi/TrackingAdsDecorator")]
    public class TrackingAdsDecorator : BaseAdDecorator
    {
        protected override IAdAdapter CreateAdAdapter(IAdService adService)
        {
            return new TrackingAd(adService);
        }
    }
}