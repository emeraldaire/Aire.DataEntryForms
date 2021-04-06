using FormEntryDesign;
using Prism.Commands;
using ScheduleEntryForms.Configurations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ScheduleEntryForms.ViewModels
{
    public class HeatingCoolingPanelViewModel : ViewModelBase, IHeatingCoolingInformationPanelViewModel
    {
        public IHeatingCoolingConfiguration HeatingCoolingConfiguration { get; set; }

        private string _heatingAFUE;
        private string _heatingNumberOfStages;
        private string _heatingInputMBH;
        private string _heatingOutputMBH;
        private string _heatingMBH;
        private string _heatingHSPF;
        private string _heatingAuxKiloWatts;

        private string _coolingTons;
        private string _coolingMBH;
        private string _coolingSEER_EER;
        private string _coolingSEER;


        public string HeatingAFUE
        {
            get { return _heatingAFUE; }
            set
            {
                _heatingAFUE = value;
                OnPropertyChanged();
            }
        }

        public string HeatingNumberOfStages
        {
            get { return _heatingNumberOfStages; }
            set
            {
                _heatingNumberOfStages = value;
                OnPropertyChanged();
            }
        }

        public string HeatingInputMBH
        {
            get { return _heatingInputMBH; }
            set
            {
                _heatingInputMBH = value;
                OnPropertyChanged();
            }
        }


        public string HeatingOutputMBH
        {
            get { return _heatingOutputMBH; }
            set
            {
                _heatingOutputMBH = value;
                OnPropertyChanged();
            }
        }

        public string HeatingMBH
        {
            get { return _heatingMBH; }
            set
            {
                _heatingMBH = value;
                OnPropertyChanged();
            }
        }

        public string HeatingHSPF
        {
            get { return _heatingHSPF; }
            set
            {
                _heatingHSPF = value;
                OnPropertyChanged();
            }
        }

        public string HeatingAuxKiloWatts
        {
            get { return _heatingAuxKiloWatts; }
            set
            {
                _heatingAuxKiloWatts = value;
                OnPropertyChanged();
            }
        }


        public string CoolingTons
        {
            get { return _coolingTons; }
            set
            {
                _coolingTons = value;
                OnPropertyChanged();
            }
        }

        public string CoolingMBH
        {
            get { return _coolingMBH; }
            set
            {
                _coolingMBH = value;
                OnPropertyChanged();
            }
        }


        public string CoolingSEER_EER
        {
            get { return _coolingSEER_EER; }
            set
            {
                _coolingSEER_EER = value;
                OnPropertyChanged();
            }
        }


        public string CoolingSEER
        {
            get { return _coolingSEER; }
            set
            {
                _coolingSEER = value;
                OnPropertyChanged();
            }
        }


        public ICommand TestDataCommand { get; set; }


        //CONSTRUCTOR

        public HeatingCoolingPanelViewModel(IHeatingCoolingConfiguration heatingCoolingConfiguration)
        {
            HeatingCoolingConfiguration = heatingCoolingConfiguration;
            TestDataCommand = new DelegateCommand(OnTestData);
        }

        private void OnTestData()
        {
            throw new NotImplementedException();
        }
    }
}
