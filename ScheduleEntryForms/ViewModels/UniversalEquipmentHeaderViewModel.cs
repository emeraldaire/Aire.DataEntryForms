using FormEntryDesign;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace ScheduleEntryForms.ViewModels
{
    public class UniversalEquipmentHeaderViewModel : ViewModelBase
    {
        private string _equipmentTag;
        public string EquipmentTag
        {
            get { return _equipmentTag; }
            set 
            { 
                _equipmentTag = value;
                OnPropertyChanged();
            }
        }
        private string _location;
        public string Location
        {
            get { return _location; }
            set
            {
                _location = value;
                OnPropertyChanged();
            }
        }
        private List<string> _manufacturerList;
        public List<string> ManufacturerList
        {
            get { return _manufacturerList; }
            set 
            { 
                _manufacturerList = value;
                OnPropertyChanged();          
            }
        }
        private List<string> _modelList;
        public List<string> ModelList
        {
            get { return _modelList; }
            set 
            {
                _modelList = value;
                OnPropertyChanged();
            }
        }

        private string _selectedManufacturer;

        public string SelectedManufacturer
        {
            get { return _selectedManufacturer; }
            set 
            { 
                _selectedManufacturer = value;
                OnPropertyChanged();
            }
        }

        private string _selectedModel;

        public string SelectedModel
        {
            get { return _selectedModel; }
            set 
            { 
                _selectedModel = value;
                OnPropertyChanged();
            }
        }




        public ICommand CreateNewUnitCommand { get; set; }


        public UniversalEquipmentHeaderViewModel()
        {
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
