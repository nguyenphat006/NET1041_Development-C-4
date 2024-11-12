using Microsoft.AspNetCore.Mvc;
using Bai02.Models;
namespace Bai02.Controllers
{
    public class PhoneController : Controller
    {
        public IActionResult Index()
        {
            DataDemoModel dataDemo = new DataDemoModel();
            List<PhoneModel> phoneList = dataDemo._ListPhone; // Lấy danh sách điện thoại
            return View(phoneList); // Truyền danh sách vào view
        }
    }
}
