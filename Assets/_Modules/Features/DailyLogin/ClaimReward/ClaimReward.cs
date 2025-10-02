using CommandBuses;

namespace DailyLogins
{
    public class ClaimReward : ICommand
    {
        public int Day { get; set; }

        public ClaimReward(int day)
        {
            Day = day;
        }
    }
}