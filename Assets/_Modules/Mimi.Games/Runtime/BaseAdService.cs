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
        [SerializeField] private BaseAdService[] decorators;
        
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
}