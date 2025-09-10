using UnityEngine;

namespace Mimi.Games
{
    public class TrackingAd : AdDecorator
    {
        public TrackingAd(IAdService adService) : base(adService)
        {
        }

        public override void ShowBanner()
        {
            base.ShowBanner();
            Debug.Log($"--- (ADS) Tracking BANNER");
        }

        public override void ShowInterstitial()
        {
            base.ShowInterstitial();
            Debug.Log($"--- (ADS) Tracking INTER");
        }

        public override void ShowRewardedVideo()
        {
            base.ShowRewardedVideo();
            Debug.Log($"--- (ADS) Tracking REWARD");
        }
    }
}