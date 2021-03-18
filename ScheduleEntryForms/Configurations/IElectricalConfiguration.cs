namespace ScheduleEntryForms.Configurations
{
    public interface IElectricalConfiguration
    {
        bool AuxKiloWatts { get; set; }
        bool FanHP { get; set; }
        bool FullLoadAmps { get; set; }
        bool HpWatt { get; set; }
        bool KiloWatts { get; set; }
        bool MaximumCurrentAmps { get; set; }
        bool MaximumOverCurrentProtection { get; set; }
        bool RatedAmps { get; set; }
        bool VoltPhase { get; set; }
    }
}