using UnityEngine;

namespace Mimi.Games
{
    [CreateAssetMenu(fileName = "AdService", menuName = "Mimi/AdService")]
    public class AdService : BaseAdService
    {
        [SerializeField] private BaseAdService adService;
        [SerializeField] private BaseAdDecorator[] decorators;

        protected override IAdAdapter CreateAdAdapter()
        {
            this.adService.Initialize();

            int decoratorsLength = this.decorators.Length;
            BaseAdDecorator firstDecorator = this.decorators[0];

            for (int i = 0; i < decoratorsLength; i++)
            {
                BaseAdDecorator decorator = this.decorators[i];

                if (IsLastDecorator(i))
                {
                    decorator.Initialize(this.adService);
                    continue;
                }

                BaseAdDecorator nextDecorator = this.decorators[i + 1];
                decorator.Initialize(nextDecorator);
            }

            return firstDecorator.ADAdapter;
        }

        private bool IsLastDecorator(int index)
        {
            return index == this.decorators.Length - 1;
        }
    }
}