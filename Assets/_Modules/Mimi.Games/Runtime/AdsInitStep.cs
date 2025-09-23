using UnityEngine;

namespace Mimi.Games
{
    public class AdsInitStep : BaseMonoInitStep
    {
        [SerializeField] private BaseAdServiceSO adService;

        public override void Initialize()
        {
            this.adService.Initialize();
        }

        [ContextMenu("Show Banner Ad")]
        public void ShowBanner()
        {
            this.adService.ShowBanner();
        }

        [ContextMenu("Show Interstitial Ad")]
        public void ShowInterstitial()
        {
            this.adService.ShowInterstitial();
        }

        [ContextMenu("Show Rewarded Video")]
        public void ShowRewardedVideo()
        {
            this.adService.ShowRewardedVideo();
        }
    }
}