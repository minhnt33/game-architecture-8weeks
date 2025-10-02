using System.Threading.Tasks;
using CommandBuses;

namespace DailyLogins
{
    public class ShowRewardPanelHandler : ICommandHandler<ShowRewardPanel>
    {
        private readonly IUIService uiService;

        public ShowRewardPanelHandler(IUIService uiService)
        {
            this.uiService = uiService;
        }

        public async Task Execute(ShowRewardPanel command)
        {
            await Task.CompletedTask;
            this.uiService.Show("DailyLogin");
        }
    }
}