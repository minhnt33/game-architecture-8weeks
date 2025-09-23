namespace Mimi.Games
{
    public abstract class BaseAdServiceSO : BaseServiceSO, IAdService
    {
        public abstract void ShowBanner();

        public abstract void ShowInterstitial();

        public abstract void ShowRewardedVideo();
    }
}