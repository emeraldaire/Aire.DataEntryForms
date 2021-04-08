using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleEntryForms.Configurations.EquipmentConfigurations
{
    public class IHPFanCoilUnitsConfiguration : IEquipmentConfiguration
    {
        public IElectricalConfiguration ElectricalConfiguration { get; set; }
        public IHeatingCoolingConfiguration HeatingCoolingConfiguration { get ; set; }

        public IHPFanCoilUnitsConfiguration()
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
                HeatingAuxKiloWatts = true,
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
                MaximumOverCurrentProtection = true
            };
        }
    }
}
