using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QLSV.Data;
using QLSV.Interface.Repo.Delete;
using QLSV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Repository
{
    public class DeleteStu : IRepoDeleteStu
    {
        private readonly DbClass context;
        private readonly ILogger<DeleteStu> logger;
        public DeleteStu(DbClass dbContext, ILogger<DeleteStu> logger)
        {
            context = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<bool> DeleteById(int Id)
        {
            if (Id<=0)
            {
                logger.LogWarning("Them rong");
                return false;
            }
            try
            {
                var student = await context.students.FindAsync(Id);
                if (student == null)
                {
                    logger.LogWarning($"Không tìm thấy sinh viên có ID {Id}.");
                    return false;
                }
                context.students.Remove(student);
                await context.SaveChangesAsync();
                logger.LogInformation("Success");
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

        public async Task<bool> DeleteStuAll()
        {
            try
            {
                var student = await context.students.ToListAsync();
                if (student.Count == 0)
                {
                    logger.LogWarning("Không có sinh viên nào để xóa.");
                    return false;
                }
                context.students.RemoveRange(student);
                await context.SaveChangesAsync();
                logger.LogInformation("Success");
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
