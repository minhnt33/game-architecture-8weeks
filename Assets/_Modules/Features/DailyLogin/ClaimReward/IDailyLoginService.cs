namespace DailyLogins
{
    public interface IDailyLoginService
    {
        ClaimResult ClaimReward(int day);
        void ResetRewards();
    }
}