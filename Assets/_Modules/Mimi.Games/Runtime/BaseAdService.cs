using UnityEngine;

namespace Mimi.Games
{
    /// <summary>
    /// Tuan thu Interface Segregation. Vd trong 1 truong hoc co he thong so diem.
    /// Teacher co quyen ghi diem, xem diem, viet loi phe.
    /// Student co quyen xem diem.
    /// Parent co quyen xem diem, tra loi loi phe.
    /// Neu interface co SetGPA, ReadGPA, WriteComment
    /// Teacher implement IGPASetter, IGPAReader, ICommentWriter
    /// Student implement IGPAReader
    /// Parent implement IGPAReader, ICommentWriter
    /// SOLID:
    /// 1. Single Responsibility
    /// 2. Open Closed
    /// 3. Liskov's Substitution
    /// 4. Interface Segregation
    /// 5. Dependency Inversion
    /// </summary>
    public abstract class BaseAdService : BaseServiceSO, IAdService
    {
        private IAdAdapter adAdapter;

        protected abstract IAdAdapter CreateAdAdapter();

        public override void Initialize()
        {
            this.adAdapter = CreateAdAdapter();
            this.adAdapter.Initialize();
        }

        public override void Dispose()
        {
            this.adAdapter.Dispose();
        }

        public void ShowBanner()
        {
            this.adAdapter.ShowBanner();
        }

        public void ShowInterstitial()
        {
            this.adAdapter.ShowInterstitial();
        }

        public void ShowRewardedVideo()
        {
            this.adAdapter.ShowRewardedVideo();
        }
    }

    public abstract class BaseAdDecorator : BaseDecoratorSO, IAdService
    {
        private IAdAdapter adAdapter;

        public IAdAdapter ADAdapter => this.adAdapter;

        protected abstract IAdAdapter CreateAdAdapter(IAdService adService);

        public override void Initialize(IAdService adService)
        {
            this.adAdapter = CreateAdAdapter(adService);
            this.adAdapter.Initialize();
        }

        public void Initialize()
        {
        }

        public override void Dispose()
        {
            this.adAdapter.Dispose();
        }

        public void ShowBanner()
        {
            this.adAdapter.ShowBanner();
        }

        public void ShowInterstitial()
        {
            this.adAdapter.ShowInterstitial();
        }

        public void ShowRewardedVideo()
        {
            this.adAdapter.ShowRewardedVideo();
        }
    }
}