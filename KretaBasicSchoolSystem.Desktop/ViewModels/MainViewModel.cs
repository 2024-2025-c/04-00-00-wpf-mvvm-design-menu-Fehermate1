﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FontAwesome.Sharp;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using KretaBasicSchoolSystem.Desktop.ViewModels.ControlPanel;
using KretaBasicSchoolSystem.Desktop.ViewModels.Grades;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolClasses;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolSubjects;

namespace KretaBasicSchoolSystem.Desktop.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private ControlPanelViewModel _controlPanelViewModel;
        private SchoolCitizensViewModel _schoolCitizensViewModel;
        private SchoolClassesViewModel _schoolClassesViewModel;
        private SchoolSubjectsViewModel _schoolSubjectsViewModel;
        private GradesViewModel _gradesViewModel;

        public MainViewModel()
        {
            _controlPanelViewModel = new ControlPanelViewModel();
            _schoolCitizensViewModel = new SchoolCitizensViewModel();
            _schoolClassesViewModel = new SchoolClassesViewModel();
            _schoolSubjectsViewModel = new SchoolSubjectsViewModel();
            _gradesViewModel = new GradesViewModel();

            CurrentChildView = _controlPanelViewModel;

        }

        public MainViewModel(
            ControlPanelViewModel controlPanelViewModel,
            SchoolCitizensViewModel schoolCitizensViewModel,
            SchoolClassesViewModel schoolClassesViewModel,
            SchoolSubjectsViewModel schoolSubjectsViewModel,
            GradesViewModel gradesViewModel
            )
        {
            _controlPanelViewModel = controlPanelViewModel;
            _schoolCitizensViewModel = schoolCitizensViewModel;
            _schoolClassesViewModel = schoolClassesViewModel;
            _schoolSubjectsViewModel = schoolSubjectsViewModel;
            _gradesViewModel = gradesViewModel;

            CurrentChildView = _controlPanelViewModel;
            ShowDashbord();
        }

        [ObservableProperty]
        private string _caption = string.Empty;

        [ObservableProperty]
        private IconChar _icon = new IconChar();

        [ObservableProperty]
        private BaseViewModel _currentChildView;

        [RelayCommand]
        public void ShowDashbord()
        {
            Caption = "Vezérlőpult";
            Icon=IconChar.SolarPanel;
            CurrentChildView = _controlPanelViewModel;
        }

        [RelayCommand]
        public void ShowSchoolCitizens()
        {
            Caption = "Iskolapolgárok";
            Icon = IconChar.UserGroup;
            CurrentChildView = _schoolCitizensViewModel;
        }

        [RelayCommand]
        public void ShowSchoolClasses() 
        {
            Caption = "Osztályok";
            Icon = IconChar.ChalkboardUser;
            CurrentChildView = _schoolClassesViewModel;
        }
        [RelayCommand]
        public void ShowSchoolSubjects()
        {
            Caption = "Tantárgyak";
            Icon = IconChar.GraduationCap;
            CurrentChildView = _schoolSubjectsViewModel;
        }
        [RelayCommand]
        public void ShowGrades()
        {
            Caption = "Osztályzatok";
            Icon = IconChar.Grav;
            CurrentChildView = _gradesViewModel;
        }
    }
}
