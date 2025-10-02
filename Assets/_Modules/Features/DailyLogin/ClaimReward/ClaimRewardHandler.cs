using System;
using System.Threading.Tasks;
using CommandBuses;

namespace DailyLogins
{
    public class ClaimRewardHandler : ICommandHandler<ClaimReward>
    {
        private readonly IDailyLoginService dailyLoginService;
        private readonly ISaveService saveService;
        private readonly ITrackingService trackingService;

        public ClaimRewardHandler(IDailyLoginService dailyLoginService, ISaveService saveService,
            ITrackingService trackingService)
        {
            this.dailyLoginService = dailyLoginService;
            this.saveService = saveService;
            this.trackingService = trackingService;
        }

        public async Task Execute(ClaimReward command)
        {
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