using UnityEngine;

namespace Mimi.Games
{
    public class LogAds : IAdAdapter
    {
        public void Initialize()
        {
        }

        public void Dispose()
        {
        }

        public void ShowBanner()
        {
            Debug.Log($"--- (ADS) Log BANNER");
        }

        public void ShowInterstitial()
        {
            Debug.Log($"--- (ADS) Log INTER");
        }

        public void ShowRewardedVideo()
        {
            Debug.Log($"--- (ADS) Log REWARD");
        }
    }
}