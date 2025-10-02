using System.Collections.Generic;
using CommandBuses;
using UnityEngine;
using UnityEngine.UI;

namespace DailyLogins
{
    public class DailyLoginView : MonoBehaviour
    {
        [SerializeField] private Button claimButton;
        [SerializeField] private int day;

        private CommandBus commandBus;

        private void Awake()
        {
            this.claimButton.onClick.AddListener(ClaimRewardHandler);
            var dailyLoginModel = new DailyLoginModel();
            
            foreach (string rewardData in dailyLoginModel.Rewards)
            {
                // Spawn reward view item theo data
            }

            // this.commandBus = new CommandBus();
            // this.commandBus.Register(typeof(ClaimReward), new RemoteConfigHandler<ClaimReward>(new List<CommandOption<ClaimReward>>(
            // {
            //     new CommandOption<ClaimReward>("A", new ClaimRewardHandler()),
            //     new CommandOption<ClaimReward>("B", new OptimizeVer1ClaimRewardHandler())
            // })));
            
        }

        private async void ClaimRewardHandler()
        {
            await this.commandBus.Execute(new ClaimReward(this.day));
        }
    }
}