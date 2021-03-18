using System.Collections.Generic;
using System.Windows.Input;

namespace ScheduleEntryForms.ViewModels
{
    public interface IElectricalInformationPanelViewModel
    {
        int AuxKiloWatts { get; set; }
        double FanHP { get; set; }
        double FullLoadAmps { get; set; }
        bool HasHPWatt { get; set; }
        bool HasMCA { get; set; }
        int HPWatt { get; set; }
        int KiloWatts { get; set; }
        double MaximumCurrentAmps { get; set; }
        double MaximumOverCurrentProtection { get; set; }
        double RatedAmps { get; set; }
        string SelectedVoltPhase { get; set; }
        ICommand TestDataCommand { get; set; }
        List<string> VoltPhaseList { get; set; }
    }
}