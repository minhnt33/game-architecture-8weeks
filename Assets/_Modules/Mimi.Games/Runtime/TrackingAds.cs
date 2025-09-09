using UnityEngine;

namespace Mimi.Games
{
    public class TrackingAds : IAdAdapter
    {
        public void Initialize()
        {
        }

        public void Dispose()
        {
        }

        public void ShowBanner()
        {
            Debug.Log($"--- (ADS) Tracking BANNER");
        }

        public void ShowInterstitial()
        {
            Debug.Log($"--- (ADS) Tracking INTER");
        }

        public void ShowRewardedVideo()
        {
            Debug.Log($"--- (ADS) Tracking REWARD");
        }
    }
}