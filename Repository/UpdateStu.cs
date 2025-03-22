using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QLSV.Data;
using QLSV.Interface.Repo.Update;
using QLSV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Repository
{
    public class UpdateStu:IRepoUpdateStu
    {
        private readonly DbClass context;
        private readonly ILogger<UpdateStu> logger;
        public UpdateStu(DbClass dbContext, ILogger<UpdateStu> logger)
        {
            context = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Boolean> UpdateStudent(int id, string name, string faculty, decimal dtb)
        {
            if (id < 0 )
            {
                logger.LogWarning($"Dữ liệu đầu vào không hợp lệ: id={id}, student=null");
                return false;
            }
            try
            {
                var student = await context.students.FindAsync(id);
                if (student == null)
                {
                    logger.LogWarning($"Không tìm thấy sinh viên có ID {id}.");
                    return false;
                }

                student.Name = name;
                student.dtb = dtb;
                student.Faculty = faculty;

                await context.SaveChangesAsync();
                return true;

            }
            catch (DbUpdateException ex)
            {
                logger.LogError(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                logger.LogError(ex.Message);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
            }
            return false;
        }
    }
}
