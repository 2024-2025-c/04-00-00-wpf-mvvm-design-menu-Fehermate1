using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.Grades
{
    public partial class GradesViewModel : BaseViewModel
    {
        private TaughtClassesViewModel _taughtClassesViewModel;
        private EndOfSemesterVIewModel _endOfSemesterViewModel;
        private EndOfYearViewModel _endOfYearViewModel;
        private CurrentLessonViewModel _currentLessonViewModel;

        public GradesViewModel()
        {
            _currentLessonViewModel = new CurrentLessonViewModel();
            _endOfYearViewModel = new EndOfYearViewModel();
            _endOfSemesterViewModel = new EndOfSemesterVIewModel();
            _taughtClassesViewModel = new TaughtClassesViewModel();
        }

        public GradesViewModel(CurrentLessonViewModel currentLessonViewModel, EndOfYearViewModel endOfYearViewModel, EndOfSemesterVIewModel endOfSemesterViewModel, TaughtClassesViewModel taughtClassesViewModel)
        {
            _currentLessonViewModel = currentLessonViewModel;
            _endOfYearViewModel = endOfYearViewModel;
            _endOfSemesterViewModel = endOfSemesterViewModel;
            _taughtClassesViewModel = taughtClassesViewModel;

            _currentLessonViewModel = new CurrentLessonViewModel();
            _endOfYearViewModel = new EndOfYearViewModel();
            _endOfSemesterViewModel = new EndOfSemesterVIewModel();
            _taughtClassesViewModel = new TaughtClassesViewModel();
        }

        [ObservableProperty]
        private BaseViewModel? _currentGradesChildView;

        [RelayCommand]
        public void ShowCurrentLessonView()
        {
            CurrentGradesChildView = _currentLessonViewModel;
        }
        [RelayCommand]

        public void ShowEndofSemesterView()
        {
            CurrentGradesChildView = _endOfSemesterViewModel;
        }

        [RelayCommand]

        public void ShowEndOfYearView()
        {
            CurrentGradesChildView = _endOfYearViewModel;
        }

        [RelayCommand]

        public void ShowTaughtClassesView()
        {
            CurrentGradesChildView = _taughtClassesViewModel;
        }
    }
}
