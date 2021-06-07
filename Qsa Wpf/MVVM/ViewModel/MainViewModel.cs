﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qsa_Wpf.Core;
using System.Windows;

namespace Qsa_Wpf.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommad { get; set; }

        public RelayCommand BureautiqueViewCommand { get; set; }

        public RelayCommand NavigateueqViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }

        public BureautiqueViewModel BureautiqueVM { get; set; }

        public NavigateursViewModel NavigateursVM { get; set; }


        private object _currentView;

        public object CurrentView
        {
            get { return _currentView;; }
            set {
                _currentView = value;
                OnPropertyChanged(); 
            }
        }


        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            BureautiqueVM = new BureautiqueViewModel();
            NavigateursVM = new NavigateursViewModel();
            CurrentView = HomeVM;

            HomeViewCommad = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });
            BureautiqueViewCommand = new RelayCommand(o =>
            {
                CurrentView = BureautiqueVM;
                
            });
            NavigateueqViewCommand = new RelayCommand(o =>
            {
                CurrentView = NavigateursVM;
            });
        }
    }
}
