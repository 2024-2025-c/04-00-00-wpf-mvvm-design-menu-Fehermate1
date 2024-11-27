using KretaBasicSchoolSystem.Desktop.ViewModels;
using KretaBasicSchoolSystem.Desktop.ViewModels.ControlPanel;
using KretaBasicSchoolSystem.Desktop.ViewModels.Login;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolSubjects;
using KretaBasicSchoolSystem.Desktop.ViewModels.Grades;
using KretaBasicSchoolSystem.Desktop.Views;
using KretaBasicSchoolSystem.Desktop.Views.ControlPanel;
using KretaBasicSchoolSystem.Desktop.Views.Login;
using KretaBasicSchoolSystem.Desktop.Views.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.Views.SchoolClasses;
using KretaBasicSchoolSystem.Desktop.Views.SchoolSubjects;
using KretaBasicSchoolSystem.Desktop.Views.Grades;
using Microsoft.Extensions.DependencyInjection;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;

namespace KretaDesktop.Extensions
{
    public static class ViewViewModelsExtensions
    {
        public static void ConfigureViewViewModels(this IServiceCollection services)
        {
            // MainView
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainView>(s => new MainView()
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            });

            // LoginView
            services.AddSingleton<LoginViewModel>();
            services.AddSingleton<LoginView>(s => new LoginView()
            {
                DataContext = s.GetRequiredService<LoginViewModel>()
            });

            // ControlPanel
            services.AddSingleton<ControlPanelViewModel>();
            services.AddSingleton<ControlPanelView>(s => new ControlPanelView()
            {
                DataContext = s.GetRequiredService<ControlPanelViewModel>()
            });
            // School Citizens
            services.AddSingleton<SchoolCitizensViewModel>();
            services.AddSingleton<SchoolCitizensView>(s => new SchoolCitizensView()
            {
                DataContext = s.GetRequiredService<SchoolCitizensViewModel>()
            });

            // Students
            // School Citizens
            services.AddSingleton<StudentViewModel>();
            services.AddSingleton<StudentView>(s => new StudentView()
            {
                DataContext = s.GetRequiredService<StudentViewModel>()
            });

            //SchoolClasses
            services.AddSingleton<SchoolCitizensViewModel>();
            services.AddSingleton<SchoolClassesView>(s => new SchoolClassesView()
            {
                DataContext = s.GetRequiredService<SchoolCitizensViewModel>()
            });

            //SchoolSubjects
            services.AddSingleton<SchoolSubjectsViewModel>();
            services.AddSingleton<SchoolSubjectsView>(s => new SchoolSubjectsView()
            {
                DataContext = s.GetRequiredService<SchoolSubjectsViewModel>()
            });

            //Grades
            services.AddSingleton<GradesViewModel>();
            services.AddSingleton<GradesView>(s => new GradesView()
            {
                DataContext = s.GetRequiredService<GradesViewModel>()
            });

            //Current Lesson
            services.AddSingleton<CurrentLessonViewModel>();
            services.AddSingleton<CurrentLessonView>(s => new CurrentLessonView()
            {
                DataContext = s.GetRequiredService<CurrentLessonViewModel>()
            });

            //Taught Classes
            services.AddSingleton<TaughtClassesViewModel>();
            services.AddSingleton<TaughtClassesView>(s => new TaughtClassesView()
            {
                DataContext = s.GetRequiredService<TaughtClassesViewModel>()
            });

            //End of Year
            services.AddSingleton<EndOfYearViewModel>();
            services.AddSingleton<EndOfYearView>(s => new EndOfYearView()
            {
                DataContext = s.GetRequiredService<EndOfYearViewModel>()
            });

            //End of Semester
            services.AddSingleton<EndOfSemesterVIewModel>();
            services.AddSingleton<EndOfSemesterView>(s => new EndOfSemesterView()
            {
                DataContext = s.GetRequiredService<EndOfSemesterVIewModel>()
            });
        }
    }
}
