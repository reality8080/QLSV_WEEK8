using Microsoft.Extensions.Logging;
using QLSV.Interface.Repo.Read;
using QLSV.Interface.Service.Read;
using QLSV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Service
{
    public class SerReadStudent : IServiReadStu
    {
        private readonly IRepoReadStu _studentRepo;
        private readonly ILogger<SerReadStudent> _logger;
        public SerReadStudent(IRepoReadStu studentRepo, ILogger<SerReadStudent> logger)
        {
            _studentRepo = studentRepo ?? throw new ArgumentNullException(nameof(studentRepo));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<IEnumerable<Student>> ReadAll()
        {
            try
            {
                var students= await _studentRepo.ReadAll();
                //if (students == null)
                //{
                //    _logger.LogWarning("Danh sach sinh vien tra ve null, thay bang danh sach rong");
                //    return new List<Student>();
                //}
                _logger.LogInformation($"Đọc danh sách {students?.Count()} sinh viên");
                return students ?? new List<Student>();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Lỗi khi đọc danh sách sinh viên");
                return Enumerable.Empty<Student>();
            }
        }

        public async Task<Student?> ReadStuAsync(int? Id)
        {
            if (Id == null || Id < 0)
            {
                _logger.LogWarning("Id sinh vien khong hop le, bi null hoac am");
                return null;
            }
            try
            {
                var student=await _studentRepo.ReadStuAsync(Id);
                if(student != null)
                {
                    _logger.LogInformation($"Doc thanh cong sinh vien {student}");
                }
                else
                {
                    _logger.LogWarning($"Khong tim thay sinh vien");
                }
                return student;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return null;
            }
        }
    }
}
