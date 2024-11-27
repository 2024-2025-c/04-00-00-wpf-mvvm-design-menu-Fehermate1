﻿using CommunityToolkit.Mvvm.ComponentModel;
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
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolSubjects;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.Grades
{
    public partial class GradesViewModel : BaseViewModel
    {
        private TaughtClassesViewModel _taughtClassesViewModel;
        private EndOfSemester _EndOfSemester;
        private EndOfYearViewModel _EndOfOfYearViewModel;
        private CurrentLessonViewModel _CurrentLessonViewModel;

        public GradesViewModel()
        {
            _currentGradesChildView = new CurrentLessonViewModel();
        }
    }
}
