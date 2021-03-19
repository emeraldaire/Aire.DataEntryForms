using FormEntryDesign;
using Prism.Commands;
using ScheduleEntryForms.Configurations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ScheduleEntryForms.ViewModels
{
    public class ElectricalInformationPanelViewModel : ViewModelBase, IElectricalInformationPanelViewModel
    {
        public IElectricalConfiguration ElectricalConfiguration;


        private List<string> _voltPhaseList;
        private string _selectedVoltPhase;
        private int _hpWatt;
        private int _kiloWatts;
        private int _auxKiloWatts;
        private double _fanHP;
        private double _maximumCurrentAmps;
        private double _maximumOverCurrentProtection;
        private double _fullLoadAmps;
        private double _ratedAmps;





        public double RatedAmps
        {
            get { return _ratedAmps; }
            set
            {
                _ratedAmps = value;
                OnPropertyChanged();
            }
        }
        public double FullLoadAmps
        {
            get { return _fullLoadAmps; }
            set
            {
                _fullLoadAmps = value;
                OnPropertyChanged();
            }
        }
        public double MaximumOverCurrentProtection
        {
            get { return _maximumOverCurrentProtection; }
            set
            {
                _maximumOverCurrentProtection = value;
                OnPropertyChanged();
            }
        }
        public double MaximumCurrentAmps
        {
            get { return _maximumCurrentAmps; }
            set
            {
                _maximumCurrentAmps = value;
                OnPropertyChanged();
            }
        }
        public double FanHP
        {
            get { return _fanHP; }
            set
            {
                _fanHP = value;
                OnPropertyChanged();
            }
        }
        public int AuxKiloWatts
        {
            get { return _auxKiloWatts; }
            set
            {
                _auxKiloWatts = value;
                OnPropertyChanged();
            }
        }
        public int KiloWatts
        {
            get { return _kiloWatts; }
            set
            {
                _kiloWatts = value;
                OnPropertyChanged();
            }
        }
        public int HPWatt
        {
            get { return _hpWatt; }
            set
            {
                _hpWatt = value;
                OnPropertyChanged();
            }
        }
        public string SelectedVoltPhase
        {
            get { return _selectedVoltPhase; }
            set
            {
                _selectedVoltPhase = value;
                OnPropertyChanged();
            }
        }
        public List<string> VoltPhaseList
        {
            get { return _voltPhaseList; }
            set
            {
                _voltPhaseList = value;
                OnPropertyChanged();
            }
        }


        public ICommand TestDataCommand { get; set; }

        //THIS IS THE CONTRUCTOR 
        public ElectricalInformationPanelViewModel(IElectricalConfiguration electricalConfiguration)
        {
            ElectricalConfiguration = electricalConfiguration;

            //HasMCA = electricalConfiguration.MaximumCurrentAmps;
            //HasHPWatt = electricalConfiguration.HpWatt;

            TestDataCommand = new DelegateCommand(OnTestData);

            GenerateDummyData();


        }

        private void OnTestData()
        {
            throw new NotImplementedException();
        }

        private void GenerateDummyData()
        {
            VoltPhaseList = new List<string>()
            {
                "1/120",
                "3/120",
                "3/360",
                "3/240"
            };


        }
    }
}
