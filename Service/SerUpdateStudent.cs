using Microsoft.Extensions.Logging;
using QLSV.Interface.Repo.Create;
using QLSV.Interface.Repo.Update;
using QLSV.Interface.Service.Delete;
using QLSV.Interface.Service.Update;
using QLSV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Service
{
    public class SerUpdateStudent:IServiUpdateStu
    {
        private readonly IRepoUpdateStu _studentRepo;
        private readonly ILogger<SerUpdateStudent> _logger;

        public SerUpdateStudent(IRepoUpdateStu studentRepo, ILogger<SerUpdateStudent> logger)
        {
            _studentRepo = studentRepo ?? throw new ArgumentNullException(nameof(studentRepo));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<bool> UpdateStudent(int id, string name, string faculty, decimal dtb)
        {
            try
            {
                bool result = await _studentRepo.UpdateStudent(id, name, faculty,dtb);
                if (result)
                {
                    _logger.LogInformation("Success");
                }
                else
                {
                    _logger.LogError("Fail");
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
