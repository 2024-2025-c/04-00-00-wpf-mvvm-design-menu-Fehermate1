using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens
{
    public partial class SchoolCitizensViewModel : BaseViewModel
    {
        private SchoolCitizensViewModel _schoolCitizenViewModel;

        public SchoolCitizensViewModel()
        {
            _currentSchoolCitizensChildView = new SchoolCitizensViewModel();
            _schoolCitizenViewModel = new SchoolCitizensViewModel();
        }

        public SchoolCitizensViewModel(SchoolCitizensViewModel schoolCitizensViewModel)
        {
            _schoolCitizenViewModel = new SchoolCitizensViewModel();

            _currentSchoolCitizensChildView= new SchoolCitizensViewModel();
        }

        [ObservableProperty]
        private BaseViewModel _currentSchoolCitizensChildView;

        [RelayCommand]
        public void ShowSchoolCitizensView()
        {
            CurrentSchoolCitizensChildView = _schoolCitizenViewModel;
        }
    }
}
