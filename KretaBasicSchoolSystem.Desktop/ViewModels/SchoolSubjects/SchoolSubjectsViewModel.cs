using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolSubjects
{
    public partial class SchoolSubjectsViewModel : BaseViewModel
    {
        private SchoolSubjectsViewModel _schoolSubjectsViewModel;

        public SchoolSubjectsViewModel()
        {
            _currentSchoolSubjectsChildView = new SchoolSubjectsViewModel();
            _schoolSubjectsViewModel = new SchoolSubjectsViewModel();
        }

        public SchoolSubjectsViewModel(SchoolSubjectsViewModel schoolSubjectsViewModel)
        {
            _schoolSubjectsViewModel = schoolSubjectsViewModel;

            _currentSchoolSubjectsChildView = new SchoolSubjectsViewModel();
        }

        [ObservableProperty]
        private BaseViewModel _currentSchoolSubjectsChildView;

        [RelayCommand]
        public void ShowSchoolSubjectsView()
        {
            _currentSchoolSubjectsChildView = _schoolSubjectsViewModel;
        }
    }
}
