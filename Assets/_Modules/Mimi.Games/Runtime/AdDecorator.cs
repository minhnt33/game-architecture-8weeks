namespace Mimi.Games
{
    public class AdDecorator : IAdAdapter
    {
        private IAdService adService;

        public AdDecorator(IAdService adService)
        {
            this.adService = adService;
        }

        public void Initialize()
        {
        }

        public virtual void Dispose()
        {
        }

        public virtual void ShowBanner()
        {
            this.adService.ShowBanner();
        }

        public virtual void ShowInterstitial()
        {
            this.adService.ShowInterstitial();
        }

        public virtual void ShowRewardedVideo()
        {
            this.adService.ShowRewardedVideo();
        }
    }
}