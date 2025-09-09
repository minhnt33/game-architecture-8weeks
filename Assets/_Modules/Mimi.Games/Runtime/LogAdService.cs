using UnityEngine;

namespace Mimi.Games
{
    [CreateAssetMenu(fileName = "LogAdService", menuName = "Mimi/LogAdService")]
    public class LogAdService : BaseAdService
    {
        protected override IAdAdapter CreateAdAdapter()
        {
            return new LogAds();
        }
    }
}