using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens
{
    public partial class SchoolClassesViewModel : BaseViewModel
    {
        private SchoolClassesViewModel _schoolClassesViewModel;

        public SchoolClassesViewModel()
        {
            _currentSchoolClassesChildView = new SchoolClassesViewModel();
            _schoolClassesViewModel = new SchoolClassesViewModel();
        }

        public SchoolClassesViewModel(SchoolClassesViewModel SchoolClassesViewModel)
        {
            _schoolClassesViewModel = SchoolClassesViewModel;

            _currentSchoolClassesChildView = new StudentViewModel();
        }

        [ObservableProperty]
        private BaseViewModel _currentSchoolClassesChildView;

        [RelayCommand]
        public void ShowSchoolClassesView()
        {
            CurrentSchoolClassesChildView = _schoolClassesViewModel;
        }
    }
}
