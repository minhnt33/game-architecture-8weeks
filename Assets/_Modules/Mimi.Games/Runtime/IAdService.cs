namespace Mimi.Games
{
    public interface IAdService : IService
    {
        public void ShowBanner();
        public void ShowInterstitial();
        public void ShowRewardedVideo();
    }
}