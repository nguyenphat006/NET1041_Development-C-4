using Bai01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Bai01.Controllers
{
    public class ITController : Controller
    {
        public IActionResult Index()
        {
            ITTest itTest = new ITTest();
            List<IT> itList = itTest._ITList; // Lấy danh sách từ ITTest
            return View(itList); // Trả về danh sách cho View
        }
    }
}
