namespace Mimi.Games
{
    public interface IAdAdapter
    {
        public void Initialize();
        public void Dispose();
        public void ShowBanner();
        public void ShowInterstitial();
        public void ShowRewardedVideo();
    }
}