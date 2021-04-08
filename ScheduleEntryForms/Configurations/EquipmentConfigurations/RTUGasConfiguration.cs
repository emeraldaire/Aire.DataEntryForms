using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleEntryForms.Configurations.EquipmentConfigurations
{
    public class RTUGasConfiguration : IEquipmentConfiguration
    {
        public IElectricalConfiguration ElectricalConfiguration { get ; set ; }
        public IHeatingCoolingConfiguration HeatingCoolingConfiguration { get; set; }

        public RTUGasConfiguration()
        {
            SetElectricalConfiguration();
            SetHeatingCoolingConfiguration();
        }

        private void SetHeatingCoolingConfiguration()
        {
            HeatingCoolingConfiguration = new HeatingCoolingConfiguration()
            {
                HeatingAFUE = true,
                HeatingInputMBH = true,
                HeatingOutputMBH = true,
                CoolingTons = true,
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
