using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using QLSV.Data;
using QLSV.Interface.Repo.Create;
using QLSV.Interface.Repo.Delete;
using QLSV.Interface.Repo.Read;
using QLSV.Interface.Repo.Update;
using QLSV.Interface.Service.Create;
using QLSV.Interface.Service.Delete;
using QLSV.Interface.Service.Read;
using QLSV.Interface.Service.Update;
using QLSV.Repository;
using QLSV.Service;

namespace QLSV
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            services.AddLogging(config => config.AddConsole());
            services.AddDbContext<DbClass>();
            services.AddScoped<IRepoReadStu, ReadStu>();
            services.AddScoped<IRepoUpdateStu, UpdateStu>();
            services.AddScoped<IRepoCreateStu, CreateStu>();
            services.AddScoped<IRepoDeleteStu, DeleteStu>();
            services.AddScoped<IServiReadStu, SerReadStudent>();
            services.AddScoped<IServiUpdateStu, SerUpdateStudent>();
            services.AddScoped<IServiCreateStu, SerCreateStudent>();
            services.AddScoped<IServiDeleteStu, SerDeleteStudent>();
            services.AddTransient<Form1>();
            var provider = services.BuildServiceProvider();
            Application.Run(provider.GetRequiredService<Form1>());

        }
    }
}