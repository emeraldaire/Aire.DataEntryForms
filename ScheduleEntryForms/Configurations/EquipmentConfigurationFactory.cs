using ScheduleEntryForms.Configurations.EquipmentConfigurations;
using ScheduleEntryForms.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleEntryForms.Configurations
{
    public class EquipmentConfigurationFactory : IEquipmentConfigurationFactory
    {
        
        public IEquipmentConfiguration CreateEquipmentConfiguration(EquipmentProfileType equipmentProfileType)
        {
            switch (equipmentProfileType)
            {
                case EquipmentProfileType.VAV:
                    return new VAVConfiguration();
                case EquipmentProfileType.WaterSourceHeatPump:
                    return new WaterSourceHeatPumpConfiguration();
                case EquipmentProfileType.BranchController:
                    return new BranchControllerConfiguration();
                case EquipmentProfileType.Damper:
                    return new DamperConfiguration();
                case EquipmentProfileType.ERV:
                    return new ERVConfiguration();
                case EquipmentProfileType.Fan:
                    return new FanConfiguration();
                case EquipmentProfileType.Venting:
                    return new VentingConfiguration();
                case EquipmentProfileType.OHPHeatPumpUnits:
                    return new OHPHeatPumpUnitsConfiguration();
                case EquipmentProfileType.IHPFanCoilUnits:
                    return new IHPFanCoilUnitsConfiguration();
                case EquipmentProfileType.MiniSplit:
                    return new MiniSplitConfiguration();
                case EquipmentProfileType.GasFurnace:
                    return new GasFurnaceConfiguration();
                case EquipmentProfileType.RTUGas:
                    return new RTUGasConfiguration();
                case EquipmentProfileType.RTUHeatPump:
                    return new RTUHeatPumpConfiguration();
                case EquipmentProfileType.GRD:
                    return new GRDConfiguration();
                case EquipmentProfileType.Heater:
                    return new HeaterConfiguration();
                case EquipmentProfileType.Isolation:
                    return new IsolationConfiguration();
                case EquipmentProfileType.Louver:
                    return new LouverConfiguration();
                case EquipmentProfileType.VFD:
                    return new VFDConfiguration();
                default:
                    return null;
            }
        }
    }
}