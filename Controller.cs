
using Microsoft.AspNetCore.Mvc;
using tpmodul10_103022330117.Models;
using System.Collections.Generic;
namespace tpmodul10_103022330117.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Muthi'ah Az Zahra", Nim = "103022330117" },
            new Mahasiswa { Nama = "Muhammad Endihan Alfatah Nasution", Nim = "103022300064" },
            new Mahasiswa { Nama = "Muhammad Ihsan Romdhon", Nim = "103022330150" },
            new Mahasiswa { Nama = "Triana Julianingsih", Nim = "103022300053" },
            new Mahasiswa { Nama = "Muhammad Ilham Firdaus", Nim = "103022300043" },
            new Mahasiswa { Nama = "Syahdan Mansiz Kurniawan", Nim = "103022300079" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> GetAll()
        {
            return Ok(mahasiswaList);
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetByIndex(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
                return NotFound("Index tidak ditemukan.");

            return Ok(mahasiswaList[index]);
        }

        [HttpPost]
        public ActionResult AddMahasiswa([FromBody] Mahasiswa newMahasiswa)
        {
            mahasiswaList.Add(newMahasiswa);
            return Ok("Mahasiswa berhasil ditambahkan.");
        }

        [HttpDelete("{index}")]
        public ActionResult DeleteMahasiswa(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
                return NotFound("Index tidak ditemukan.");

            mahasiswaList.RemoveAt(index);
            return Ok("Mahasiswa berhasil dihapus.");
        }
    }
}