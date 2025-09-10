using UnityEngine;

namespace Mimi.Games
{
    public class LogAd : AdDecorator
    {
        public LogAd(IAdService adService) : base(adService)
        {
        }

        public override void ShowBanner()
        {
            base.ShowBanner();
            Debug.Log($"--- (ADS) Log BANNER");
        }

        public override void ShowInterstitial()
        {
            base.ShowInterstitial();
            Debug.Log($"--- (ADS) Log INTER");
        }

        public override void ShowRewardedVideo()
        {
            base.ShowRewardedVideo();
            Debug.Log($"--- (ADS) Log REWARD");
        }
    }
}