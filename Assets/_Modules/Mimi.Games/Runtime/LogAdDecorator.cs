using UnityEngine;

namespace Mimi.Games
{
    [CreateAssetMenu(fileName = "LogAdDecorator", menuName = "Mimi/LogAdDecorator")]
    public class LogAdDecorator : BaseAdDecorator
    {
        protected override IAdAdapter CreateAdAdapter(IAdService adService)
        {
            return new LogAd(adService);
        }
    }
}