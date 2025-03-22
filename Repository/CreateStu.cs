using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QLSV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using QLSV.Data;
using QLSV.Interface.Repo.Create;

namespace QLSV.Repository
{
    public class CreateStu:IRepoCreateStu
    {
        private readonly DbClass context;
        private readonly ILogger<CreateStu> logger;
        public CreateStu(DbClass dbContext,ILogger<CreateStu> logger) 
        { 
            context = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public async Task<Boolean> CreateStuAsync(Student stu)
        {
            if (stu == null)
            {
                logger.LogWarning("Them rong");
                return false;
            }
            try
            {
                await context.students.AddAsync(stu);
                await context.SaveChangesAsync();
                logger.LogInformation("Success");
                return true;
            }
            catch(DbUpdateException ex)
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
