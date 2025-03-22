using Microsoft.Extensions.Logging;
using QLSV.Interface.Repo.Delete;
using QLSV.Interface.Service.Create;
using QLSV.Interface.Service.Delete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Service
{
    public class SerDeleteStudent : IServiDeleteStu
    {
        private readonly IRepoDeleteStu _studentRepo;
        private readonly ILogger<SerDeleteStudent> _logger;
        public SerDeleteStudent(IRepoDeleteStu studentRepo, ILogger<SerDeleteStudent> logger)
        {
            _studentRepo = studentRepo ?? throw new ArgumentNullException(nameof(studentRepo));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<bool> DeleteById(int Id)
        {
            if (Id <= 0)
            {
                _logger.LogWarning("Khong phu hop");
                return false;
            }
            try
            {
                bool result = await _studentRepo.DeleteById(Id);
                if (result)
                {
                    _logger.LogInformation("Success");
                }
                else
                {
                    _logger.LogWarning("Fail");
                }
                return result;

            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex.Message);
                return false;
            }
        }

        public async Task<bool> DeleteStuAsync()
        {
            try
            {
                _logger.LogInformation("Yêu cầu xóa toàn bộ sinh viên.");

                bool result = await _studentRepo.DeleteStuAll();
                if (result)
                {
                    _logger.LogInformation("Xóa thành công toàn bộ sinh viên.");
                }
                else
                {
                    _logger.LogWarning("Không thể xóa toàn bộ sinh viên.");
                }
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return false;
            }
        }
    }
}
