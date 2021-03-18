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
                    return null;
                case EquipmentProfileType.WaterSourceHeatPump:
                    return null;
                case EquipmentProfileType.BranchController:
                    return null;
                case EquipmentProfileType.Damper:
                    return null;
                case EquipmentProfileType.ERV:
                    return null;
                case EquipmentProfileType.Fan:
                    return null;
                case EquipmentProfileType.Venting:
                    return null;
                case EquipmentProfileType.OHPHeatPumpUnits:
                    return null;
                case EquipmentProfileType.IHPFanCoilUnits:
                    return null;
                case EquipmentProfileType.MiniSplit:
                    return null;
                case EquipmentProfileType.GasFurnace:
                    return null;
                case EquipmentProfileType.RTUGas:
                    return new RTUGasConfiguration();
                case EquipmentProfileType.RTUHeatPump:
                    return new RTUHeatPumpConfiguration();
                case EquipmentProfileType.GRD:
                    return new GRDConfiguration();
                case EquipmentProfileType.Heater:
                    return new HeaterConfiguration();
                case EquipmentProfileType.Isolation:
                    return null;
                case EquipmentProfileType.Louver:
                    return null;
                case EquipmentProfileType.VFD:
                    return new VFDConfiguration();
                default:
                    return null;
            }
        }
    }
}