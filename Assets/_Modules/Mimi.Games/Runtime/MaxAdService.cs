using UnityEngine;

namespace Mimi.Games
{
    [CreateAssetMenu(fileName = "MaxAdService", menuName = "Mimi/MaxAdService")]
    public class MaxAdService : BaseAdService
    {
        [SerializeField] private string maxAdId;
        
        protected override IAdAdapter CreateAdAdapter()
        {
            return new MaxAdapter();
        }
    }
}