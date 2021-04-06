using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleEntryForms.Configurations.EquipmentConfigurations
{
    public class OHPHeatPumpUnitsConfiguration : IEquipmentConfiguration
    {
        public IElectricalConfiguration ElectricalConfiguration { get ; set; }
        public IHeatingCoolingConfiguration HeatingCoolingConfiguration { get ; set; }

        public OHPHeatPumpUnitsConfiguration()
        {
            SetElectricalConfiguration();
            SetHeatingCoolingConfiguration();
        }

        private void SetHeatingCoolingConfiguration()
        {
            HeatingCoolingConfiguration = new HeatingCoolingConfiguration()
            {
                HeatingMBH = true,
                HeatingHSPF = true,
                CoolingMBH = true,
                CoolingSEER_EER = true,
            };
        }
        private void SetElectricalConfiguration()
        {
            ElectricalConfiguration = new ElectricalConfiguration()
            {
                VoltPhase = true,
                MaximumCurrentAmps = true,
                MaximumOverCurrentProtection = true,
            };
        }
    }
}
