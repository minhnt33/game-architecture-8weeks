using System.Collections.Generic;

namespace DailyLogins
{
    public class ClaimResult
    {
        public List<RewardInfo> Rewards { get; private set; }
        public bool IsDoubleRewards { get; private set; }
        public bool HasClaimedAllRewards { get; private set; }
    }

    public class RewardInfo
    {
        
    }
}