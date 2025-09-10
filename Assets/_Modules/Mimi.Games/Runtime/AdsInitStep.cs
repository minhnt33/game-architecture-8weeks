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

        [ContextMenu("ShowBanner")]
        public void ShowBanner()
        {
            this.adService.ShowBanner();
        }

        [ContextMenu("ShowInterstitial")]
        public void ShowInterstitial()
        {
            this.adService.ShowInterstitial();
        }

        [ContextMenu("ShowRewardedVideo")]
        public void ShowRewardedVideo()
        {
            this.adService.ShowRewardedVideo();
        }
    }
}