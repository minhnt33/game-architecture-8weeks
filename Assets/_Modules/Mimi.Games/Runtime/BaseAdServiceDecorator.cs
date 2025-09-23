using UnityEngine;

namespace Mimi.Games
{
    public abstract class BaseAdServiceDecorator : BaseAdServiceSO
    {
        [SerializeField] BaseAdServiceSO adService;

        public override void Initialize()
        {
            this.adService.Initialize();
        }

        public override void Dispose()
        {
            adService.Dispose();
        }

        public override void ShowBanner()
        {
           this.adService.ShowBanner();
        }

        public override void ShowInterstitial()
        {
            this.adService.ShowInterstitial();
        }

        public override void ShowRewardedVideo()
        {
            this.adService.ShowRewardedVideo();
        }
    }
}