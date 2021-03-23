using ScheduleEntryForms.Configurations;

namespace ScheduleEntryForms.ViewModels
{
    public interface IElectricalPanelViewModelFactory
    {
        ElectricalPanelViewModel CreateViewModel(IElectricalConfiguration electricalConfiguration);
    }
}