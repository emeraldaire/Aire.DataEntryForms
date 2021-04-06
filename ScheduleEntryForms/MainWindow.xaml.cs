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
        private IEquipmentConfigurationFactory _equipmentConfigurationFactory { get; set; }
        public ERVViewModel ERVViewModel { get; set; }

        public MainWindow()
        {
            DataContext = this;

            UniversalEquipmentHeaderViewModel = new UniversalEquipmentHeaderViewModel();

            //PICK EQUIPMENT TYPE FOR FORMS
            //The purpose of the EquipmentConfigurationFactory is to provide an EquipmentConfiguration for the desired EquipmentProfileType.
            //The point of individual Equipment Configuration is to control the specific visibilities for that equipment
            
            _equipmentConfigurationFactory =  new EquipmentConfigurationFactory();
            var ervConfiguration = _equipmentConfigurationFactory.CreateEquipmentConfiguration(EquipmentProfileType.ERV);
            var electricalPanelViewModelFactory = new ElectricalPanelViewModelFactory();
            var heatingCoolingPanelViewModelFactory = new HeatingCoolingPanelViewModelFactory();

            ERVViewModel = new ERVViewModel(ervConfiguration, electricalPanelViewModelFactory, heatingCoolingPanelViewModelFactory);


            //var vfdConfiguration = _equipmentConfigurationFactory.CreateEquipmentConfiguration(EquipmentProfileType.VFD);
            //var louverConfiguration = _equipmentConfigurationFactory.CreateEquipmentConfiguration(EquipmentProfileType.Louver);
            //var isolationConfiguration = _equipmentConfigurationFactory.CreateEquipmentConfiguration(EquipmentProfileType.Isolation);
            //var heaterConfiguration = _equipmentConfigurationFactory.CreateEquipmentConfiguration(EquipmentProfileType.Heater);
            //var grdConfiguration = _equipmentConfigurationFactory.CreatequipmentConfiguration(EquipmentProfileType.GRD);
            //var rtuHeatPumpConfiguration = _equipmentConfigurationFactory.CreateEquipmentConfiguration(EquipmentProfileType.RTUHeatPump);
            //var rtuGasConfiguration = _equipmentConfigurationFactory.CreateEquipmentConfiguration(EquipmentProfileType.RTUGas);
            //var gasFurnaceConfiguration = _equipmentConfigurationFactory.CreateEquipmentConfiguration(EquipmentProfileType.GasFurnace);
            //var miniSplitConfiguration = _equipmentConfigurationFactory.CreateEquipmentConfiguration(EquipmentProfileType.MiniSplit);

            //var ihpFanCoilUnitsConfiguration = _equipmentConfigurationFactory.CreateEquipmentConfiguration(EquipmentProfileType.IHPFanCoilUnits);
            //var ohpHeatPumpUnitsConfiguration = _equipmentConfigurationFactory.CreateEquipmentConfiguration(EquipmentProfileType.OHPHeatPumpUnits);
            //var ventingConfiguration = _equipmentConfigurationFactory.CreateEquipmentConfiguration(EquipmentProfileType.Venting);
            //var fanConfiguration = _equipmentConfigurationFactory.CreateEquipmentConfiguration(EquipmentProfileType.Fan);
            //var damperConfiguration = _equipmentConfigurationFactory.CreateEquipmentConfiguration(EquipmentProfileType.Damper);
            //var branchControllerConfiguration = _equipmentConfigurationFactory.CreateEquipmentConfiguration(EquipmentProfileType.BranchController);
            //var waterSourceHeatPumpConfiguration = _equipmentConfigurationFactory.CreateEquipmentConfiguration(EquipmentProfileType.WaterSourceHeatPump);
            //var vavConfiguration = _equipmentConfigurationFactory.CreateEquipmentConfiguration(EquipmentProfileType.VAV);

            InitializeComponent();
        }
    }
}
