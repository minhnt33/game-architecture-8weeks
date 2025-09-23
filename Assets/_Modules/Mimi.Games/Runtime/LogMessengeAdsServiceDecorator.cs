using UnityEngine;

namespace Mimi.Games
{
    [CreateAssetMenu(fileName = "LogMessenge", menuName = "Mimi/AdsService/Decorator/LogMessenge")]
    public class LogMessengeAdsServiceDecorator : BaseAdServiceDecorator
    {
        [SerializeField] private string messenge;
        public override void Initialize()
        {
            base.Initialize();
            Debug.Log("Initialize "+messenge);
        }

        public override void ShowBanner()
        {
            base.ShowBanner();
            Debug.Log("Show Banner "+messenge);
        }

        public override void ShowRewardedVideo()
        {
            base.ShowRewardedVideo();
            Debug.Log("Show Reward " + messenge);
        }

        public override void ShowInterstitial()
        {
            base.ShowInterstitial();
            Debug.Log("Show Inter "+messenge);
        }
    }
}