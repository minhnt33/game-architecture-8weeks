using System;
using System.Threading.Tasks;
using CommandBuses;
using Mimi.Games;

namespace DailyLogins
{
    public class OptimizeVer1ClaimRewardHandler : ICommandHandler<ClaimReward>
    {
        private readonly IDailyLoginService dailyLoginService;
        private readonly ISaveService saveService;
        private readonly ITrackingService trackingService;
        private readonly IUIService uiService;
        private readonly IAdService adService;

        public OptimizeVer1ClaimRewardHandler(IDailyLoginService dailyLoginService, ISaveService saveService,
            ITrackingService trackingService, IUIService uiService, IAdService adService)
        {
            this.dailyLoginService = dailyLoginService;
            this.saveService = saveService;
            this.trackingService = trackingService;
            this.uiService = uiService;
            this.adService = adService;
        }

        public async Task Execute(ClaimReward command)
        {
            this.uiService.Show("X2ClaimPopup");
            this.adService.ShowRewardedVideo();
            ClaimResult rewards = dailyLoginService.ClaimReward(command.Day);

            if (rewards.HasClaimedAllRewards)
            {
                this.dailyLoginService.ResetRewards();
            }

            if (this.saveService.IsFull)
            {
                this.saveService.CleanUp();
            }

            try
            {
                saveService.Save();
            }
            catch (Exception e)
            {
            }

            trackingService.Log("ClaimReward", 1);
            await Task.CompletedTask;
        }
    }
}