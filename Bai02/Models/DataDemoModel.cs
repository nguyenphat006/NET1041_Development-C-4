namespace Bai02.Models
{
    public class DataDemoModel
    {
        public List<PhoneModel> _ListPhone;
        public DataDemoModel()
        {
            _ListPhone = new List<PhoneModel>();
            _ListPhone.Add(new PhoneModel
            {
                Title = "Samsung Galaxy S21",
                salePrice = 20000000,
                Name = "Samsung Galaxy S21",
                Rate = "12",
                screen = "6.2 inch",
                camera = "64 MP",
                pin = "4000 mAh",
                ram = "8 GB",
                cpu = "Exynos 2100",
                hdh = "Android 11",
                image = "~/img/samsung1.jpg"
            });
            _ListPhone.Add(new PhoneModel
            {
                Title = "Samsung Galaxy S21 Ultra",
                salePrice = 30000000,
                Name = "Samsung Galaxy S21 Ultra",
                Rate = "21",
                screen = "6.8 inch",
                camera = "108 MP",
                pin = "5000 mAh",
                ram = "12 GB",
                cpu = "Exynos 2100",
                hdh = "Android 11",
                image = "~/img/samsung2.jpg"
            });
            _ListPhone.Add(new PhoneModel
            {
                Title = "Samsung Galaxy S21 Plus",
                salePrice = 25000000,
                Name = "Samsung Galaxy S21 Plus",
                Rate = "19",
                screen = "6.7 inch",
                camera = "108 MP",
                pin = "4800 mAh",
                ram = "8 GB",
                cpu = "Exynos 2100",
                hdh = "Android 11",
                image = "~/img/samsung3.jpg"
            });
            _ListPhone.Add(new PhoneModel
            {
                Title = "Samsung Galaxy S21 Plus",
                salePrice = 25000000,
                Name = "Samsung Galaxy S21 Plus",
                Rate = "5",
                screen = "6.7 inch",
                camera = "108 MP",
                pin = "4800 mAh",
                ram = "8 GB",
                cpu = "Exynos 2100",
                hdh = "Android 11",
                image = "~/img/samsung3.jpg"
            });
        }
    }
}
