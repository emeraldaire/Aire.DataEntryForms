using ScheduleEntryForms.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleEntryForms.Configurations
{
    public class EquipmentConfigurationFactory : IEquipmentConfigurationFactory
    {
        public object CreateConfiguration(EquipmentProfileType equipmentProfileType)
        {
            switch (equipmentProfileType)
            {
                case EquipmentProfileType.VAV:
                    return null;
                    break;
                case EquipmentProfileType.WaterSourceHeatPump:
                    return null;
                    break;
                case EquipmentProfileType.BranchController:
                    return null;
                    break;
                case EquipmentProfileType.Damper:
                    return null;
                    break;
                case EquipmentProfileType.ERV:
                    return null;
                    break;
                case EquipmentProfileType.Fan:
                    return null;
                    break;
                case EquipmentProfileType.Venting:
                    return null;
                    break;
                case EquipmentProfileType.OHPHeatPumpUnits:
                    return null;
                    break;
                case EquipmentProfileType.IHPFanCoilUnits:
                    return null;
                    break;
                case EquipmentProfileType.MiniSplit:
                    return null;
                    break;
                case EquipmentProfileType.GasFurnace:
                    return null;
                    break;
                case EquipmentProfileType.RTUGas:
                    return null;
                    break;
                case EquipmentProfileType.RTUHeatPump:
                    return null;
                    break;
                case EquipmentProfileType.GRD:
                    return null;
                    break;
                case EquipmentProfileType.Heater:
                    return null;
                    break;
                case EquipmentProfileType.Isolation:
                    return null;
                    break;
                case EquipmentProfileType.Louver:
                    return null;
                    break;
                case EquipmentProfileType.VFD:
                    return new VFDConfiguration();
                    break;
                default:
                    return null;
                    break;
            }
        }
    }
}