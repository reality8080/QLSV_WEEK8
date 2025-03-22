using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QLSV.Data;
using QLSV.Interface.Repo.Read;
using QLSV.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Repository
{
    public class ReadStu:IRepoReadStu
    {
        private readonly DbClass context;
        private readonly ILogger<ReadStu> logger;

        public ReadStu(DbClass dbContext, ILogger<ReadStu> logger)
        {
            context = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Student?> ReadStuAsync(int? Id)
        {
            if (Id == null||Id<0)
            {
                logger.LogWarning($"ID sinh viên không hợp lệ: {Id}");
                return null;
            }
            try
            {
                var student = await context.students
                    .AsNoTracking()
                    .FirstOrDefaultAsync(s => s.Id == Id);

                if (student == null)
                {
                    logger.LogWarning($"Không tìm thấy sinh viên ID={Id}");
                }
                else
                {
                    logger.LogInformation($"Đọc thành công sinh viên ID={Id}");
                }

                return student;

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
            return null;
        }
        public async Task<IEnumerable<Student>> ReadAll()
        {
            try
            {
                var students = await context.students
                    .AsNoTracking()
                    .ToListAsync();
                logger.LogInformation($"Đọc danh sách {students.Count} sinh viên.");
                return students;
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
            return Enumerable.Empty<Student>();
        }
    }
}
