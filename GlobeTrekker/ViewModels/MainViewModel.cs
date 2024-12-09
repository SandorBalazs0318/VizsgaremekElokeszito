﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FontAwesome.Sharp;
using GlobeTrekker.ViewModels.Base;
using GlobeTrekker.ViewModels.ControlPanel;

namespace GlobeTrekker.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private ControlPanelViewModel _controlPanelViewModel;
        private SchoolCitizensViewModel _schoolCitizensViewModel;
        private SchoolClassesViewModel _schoolClassesViewModel;
        private SchoolSubjectsViewModel _schoolSubjectsViewModel;
        private SchoolGradesViewModel _schoolGradesViewModel;
       

        public MainViewModel()
        {
            _controlPanelViewModel = new ControlPanelViewModel();
            _schoolCitizensViewModel = new SchoolCitizensViewModel();
            _schoolClassesViewModel = new SchoolClassesViewModel();
            _schoolSubjectsViewModel = new SchoolSubjectsViewModel();
            _schoolGradesViewModel = new SchoolGradesViewModel();
            
        }

        public MainViewModel(
            ControlPanelViewModel controlPanelViewModel,
            SchoolCitizensViewModel schoolCitizensViewModel,
            SchoolClassesViewModel schoolClassesViewModel,
            SchoolSubjectsViewModel schoolSubjectsViewModel,
            SchoolGradesViewModel schoolGradesViewModel
            
            )
        {
            _controlPanelViewModel = controlPanelViewModel;
            _schoolCitizensViewModel = schoolCitizensViewModel;
            _schoolClassesViewModel = schoolClassesViewModel;
            _schoolSubjectsViewModel = schoolSubjectsViewModel;
            _schoolGradesViewModel = schoolGradesViewModel;
            


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
        //csere

        [RelayCommand]
        public void ShowSchoolSubjects()
        {
            Caption = "Tantárgyak";
            Icon = IconChar.GraduationCap;
            CurrentChildView = _schoolSubjectsViewModel;
        }
        
        [RelayCommand]
        public void ShowSchoolGrades()
        {
            Caption = "Osztályzatok";
            Icon = IconChar.ListNumeric;
            CurrentChildView = _schoolGradesViewModel;
        }
    }
}
