using Microsoft.AspNetCore.Mvc;
using My_WebAPI.Model;

namespace My_WebAPI.Controllers
{
    public class HangHoaController : Controller
    {
        public static List<Hanghoa> hanghoas= new List<Hanghoa>(); 
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(hanghoas);
        }
        [HttpPost]
        public IActionResult TaoMoi(HanghoaVM hanghoaVM) 
        {
            var hangHoa = new Hanghoa
            {
                MaHangHoa = Guid.NewGuid(),
                TenHangHoa = hanghoaVM.TenHangHoa,
                DonGia = hanghoaVM.DonGia

            };
            hanghoas.Add(hangHoa);
            return Ok(
                        new
                        {
                            Succeeded = true,
                            Data = hangHoa
                        }
                     );
        }
       
    }
}
