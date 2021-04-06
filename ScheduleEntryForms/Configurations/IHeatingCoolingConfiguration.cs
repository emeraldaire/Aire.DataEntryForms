namespace ScheduleEntryForms.Configurations
{
    public interface IHeatingCoolingConfiguration
    {
        bool HeatingAFUE { get; set; }
        bool HeatingNumberOfStages { get; set; }
        bool HeatingInputMBH { get; set; }
        bool HeatingOutputMBH { get; set; }
        bool HeatingMBH { get; set; }
        bool HeatingHSPF { get; set; }
        bool HeatingAuxKiloWatts { get; set; }

        bool CoolingTons { get; set; }
        bool CoolingMBH { get; set; }
        bool CoolingSEER_EER { get; set; }
        bool CoolingSEER { get; set; }

    }
}