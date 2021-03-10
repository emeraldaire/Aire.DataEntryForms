using FormEntryDesign;
using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace ScheduleEntryForms.ViewModels
{
    public class UniversalEquipmentHeaderViewModel : ViewModelBase
    {
        #region "Properties"

        private IEventAggregator _eventAggregator;
        private ISessionController _sessionController;
        private string _location;
        private string _equipmentTag;
        private List<string> _manufacturerList;
        private List<string> _modelList;
        private string _selectedManufacturer;
        private string _selectedModel;
       
        


        public string EquipmentTag
        {
            get { return _equipmentTag; }
            set 
            { 
                _equipmentTag = value;
                OnPropertyChanged();
            }
        }
        public string Location
        {
            get { return _location; }
            set
            {
                _location = value;
                OnPropertyChanged();
            }
        }
        public List<string> ManufacturerList
        {
            get { return _manufacturerList; }
            set 
            { 
                _manufacturerList = value;
                OnPropertyChanged();          
            }
        }
        public List<string> ModelList
        {
            get { return _modelList; }
            set 
            {
                _modelList = value;
                OnPropertyChanged();
            }
        }
        public string SelectedManufacturer
        {
            get { return _selectedManufacturer; }
            set 
            { 
                _selectedManufacturer = value;
                OnPropertyChanged();
            }
        }
        public string SelectedModel
        {
            get { return _selectedModel; }
            set 
            { 
                _selectedModel = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region "Commands"

        public ICommand CreateNewUnitCommand { get; set; }

        #endregion

        public UniversalEquipmentHeaderViewModel()

        {
            //_eventAggregator = eventAggregator;
            //_sessionController = sessionController;


            GenerateDummyData();
            CreateNewUnitCommand = new DelegateCommand(OnCreateNewUnitExecute, OnCreateNewUnitCanExecute);

        }

        private bool OnCreateNewUnitCanExecute()
        {
            return true;
        }

        private void OnCreateNewUnitExecute()
        {
           
            MessageBox.Show(EquipmentTag);
            MessageBox.Show(Location);
            MessageBox.Show(SelectedModel);
            MessageBox.Show(SelectedManufacturer);
        }

        private void GenerateDummyData()
        {
            EquipmentTag = "hello Nhan";
            Location = "Kitchen";

            ManufacturerList = new List<string>()
            { 
                "Mitsubishi",
                "LG",
                "Daikin",
                "Greenheck",
                "Fade"
            };

            ModelList = new List<string>()
            {
                "car",
                "bear",
                "cat",
                "dog",
                "cow",
                "hen",
                "chicken",
                "llama",
                "buffalo",
                "deer"
            };
            
            //ManufacturerList.Add("Mitsubishi");
            //ManufacturerList.Add("LG");
            //ManufacturerList.Add("Daikin");
            //ManufacturerList.Add("Greenheck");
            //ManufacturerList.Add("Fade");


        }



    }
}
