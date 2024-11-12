namespace Bai01.Models
{
    public class ITTest
    {
        public List<IT> _ITList;
        public ITTest()
        {
            _ITList = new List<IT>();
            _ITList.Add(new IT { Id = 1, title = "Phát triển phần mềm", Name = "IT1", image = "~/img/SD.jpg" });
            _ITList.Add(new IT { Id = 2, title = "Ứng dụng phần mềm", Name = "IT2", image = "~/img/UD.jpg" });
            _ITList.Add(new IT { Id = 3, title = "Lập trình Web", Name = "IT3", image = "~/img/WEB.png" });
            _ITList.Add(new IT { Id = 4, title = "Lập trình AI", Name = "IT4", image = "~/img/AI.jpg" });
            _ITList.Add(new IT { Id = 5, title = "Chíp bán dẫn", Name = "IT5", image = "~/img/CHIP.png" });
        }
    }
}
