using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FontAwesome.Sharp;
using GlobeTrekker.ViewModels.Base;
using GlobeTrekker.ViewModels.ControlPanel;

namespace GlobeTrekker.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private ControlPanelViewModel _controlPanelViewModel;
       
        public MainViewModel()
        {
            _controlPanelViewModel = new ControlPanelViewModel();
            
        }

        public MainViewModel(
            ControlPanelViewModel controlPanelViewModel
            
            )
        {
            _controlPanelViewModel = controlPanelViewModel;


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
            Icon = IconChar.SolarPanel;
            CurrentChildView = _controlPanelViewModel;
        }
    }
}
