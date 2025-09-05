namespace Mimi.Games
{
    public abstract class AmazonAdService : BaseAdService
    {
        protected override IAdAdapter CreateAdAdapter()
        {
            return new MaxAdapter();
        }
    }
}