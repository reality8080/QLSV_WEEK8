using Microsoft.Extensions.Logging;
using QLSV.Data;
using QLSV.Interface.Repo.Create;
using QLSV.Interface.Service.Create;
using QLSV.Model;
using QLSV.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Service
{
    public class SerCreateStudent : IServiCreateStu
    {
        private readonly IRepoCreateStu _studentRepo;
        private readonly ILogger<SerCreateStudent> _logger;
        public SerCreateStudent(IRepoCreateStu studentRepo, ILogger<SerCreateStudent> logger) 
        {
            _studentRepo = studentRepo ?? throw new ArgumentNullException(nameof(studentRepo));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public async Task<bool> CreateStuAsync(Student stu)
        {
            if (string.IsNullOrWhiteSpace(stu.Name) || string.IsNullOrWhiteSpace(stu.Faculty))
            {
                _logger.LogWarning("Ten hoặc khoa không hop le.");
                return false;
            }

            if (stu.dtb < 0 || stu.dtb > 10)
            {
                _logger.LogWarning("Điem trung binh phai trong khoang 0 - 10.");
                return false;
            }
            try
            {
                bool result=await _studentRepo.CreateStuAsync(stu);
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
                _logger.LogError(ex.Message);
                return false;
            }
        }
    }
}
