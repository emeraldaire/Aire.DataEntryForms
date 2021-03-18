using Prism.Events;
using ScheduleEntryForms.Configurations;
using ScheduleEntryForms.Controls;
using ScheduleEntryForms.ViewModels;
using System;
using ScheduleEntryForms.Enums;
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

namespace ScheduleEntryForms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public UniversalEquipmentHeaderViewModel UniversalEquipmentHeaderViewModel { get; set; }
        public ElectricalInformationPanelViewModel ElectricalInformationPanelViewModel { get; set; }
        private IEquipmentConfigurationFactory _equipmentConfigurationFactory { get; set; }

        public MainWindow()
        {
            DataContext = this;

            UniversalEquipmentHeaderViewModel = new UniversalEquipmentHeaderViewModel();

            //PICK EQUIPMENT TYPE FOR FORMS
            //The purpose of the EquipmentConfigurationFactory is to provide an EquipmentConfiguration for the desired EquipmentProfileType.
            //The point of individual Equipment Configuration is to control the specific visibilities for that equipment
            
            _equipmentConfigurationFactory =  new EquipmentConfigurationFactory();
            var vfdConfiguration = _equipmentConfigurationFactory.CreateEquipmentConfiguration(EquipmentProfileType.VFD);
            var heaterConfiguration = _equipmentConfigurationFactory.CreateEquipmentConfiguration(EquipmentProfileType.Heater);
            var rtuHeatPumpConfiguration = _equipmentConfigurationFactory.CreateEquipmentConfiguration(EquipmentProfileType.RTUHeatPump);
            var grdConfiguration = _equipmentConfigurationFactory.CreateEquipmentConfiguration(EquipmentProfileType.GRD);
            var rtuGasConfiguration = _equipmentConfigurationFactory.CreateEquipmentConfiguration(EquipmentProfileType.RTUGas);


            ElectricalInformationPanelViewModel = new ElectricalInformationPanelViewModel();


            InitializeComponent();
        }
    }
}
