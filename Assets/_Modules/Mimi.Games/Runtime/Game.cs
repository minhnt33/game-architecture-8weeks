using UnityEngine;

namespace Mimi.Games
{
    [DefaultExecutionOrder(int.MinValue)]
    public class Game : MonoBehaviour
    {
        [SerializeField] private BaseMonoGameInitializer initializer;

        // Quan trong nhat la life cycle. Phai lam ro sinh ra va chet di
        // Trong Unity, co 2 component A va B. Awake cua A chay truoc B hay B truoc A?
        // Random moi lan chay => Meo biet. Neu B phu thuoc vao A de hoat dong, thi se loi khi B khoi tao truoc
        // Awake A -> Start B -> Start C nhung doi 1 frame, D doi may frame?, E, F, G, H,... Component 1000 doi ? frame
        // Execution Order
        // Phai kiem soat thu tu khoi tao. Kiem soat the nao?
        // Trong code lam sao de code A chay truoc code B? Goi lenh truoc thi chay truoc
        // Entry point phai la diem chay dau tien trong game
        /// Xay dung he thong phai o thoi diem cang it code cang tot. Phan nao khong can thiet thi xoa luon.
        private void Start()
        {
            // Khoi tao Service. Service la cai gi? Lam gi?
            // Liet ke 1 vai service: Ads Service, IAP Service, Audio Service, Event Broadcast, Save Load,....
            // Ads Service: biet cach de show ads len man hinh. The Ads Service co biet cach show khi nao khong? Show sau level 3, khong show khi da mua Remove Ads?
            // IAP Service: biet cach thanh toan. IAP Service co biet thanh toan trong hoan canh nao khong?
            // Persistence Service: biet cach ghi du lieu tu RAM ve Hard Disk va nguoc lai
            // Code gian y la lam gi? La viet truoc, liet ke cac method, thuoc tinh truoc khi detail implementation
            // Tuyet doi trong service khong chua context (Where, When)
            // Ghi nho: Trong code service khong duoc chua dieu kien de hanh dong xay ra. IPO. Chi dc phep chua dieu kien de kiem tra dau vao.
            // Save Load Service: Save(){ if(checkInput) {SaveData()}} thi ok. if(level > 3){SaveData()} => SAI
            // Save Load Service: Save(), Load(), private Backup(), private Restore(), private UpgradeSaveVersion(). Vd player choi ver 1.0.0 sau do bo game 3 thang. Luc mo lai game update len 2.3.0.
            // Player da choi den level 64, co 150000 gem, 50 unique item, 300 rare item, 100 ticket gacha tai ver 1.0.0
            // Khi len ver 2.3.0, ticket gacha da bi chuyen thanh ticket world cup tai ver 1.6.0
            // 30/50 unique item da bi thay doi can bang, 10 do bi doi level requirement tai ver 2.0.0
            // Tai ver 2.1.0, thay doi save format tu json sang custom binary
            // Giua 2 huong: Save Load chi chua Save(), Load()
            // Service tra loi cau hoi What, How
            this.initializer.Initialize();

            // Trong Unity de thay doi ngu canh dung Scene. Neu game nhieu Scene thi phai chuyen Scene de chuyen ngu canh
            // Plugin
        }

        // Exit point
        private void End()
        {
        }
    }
}