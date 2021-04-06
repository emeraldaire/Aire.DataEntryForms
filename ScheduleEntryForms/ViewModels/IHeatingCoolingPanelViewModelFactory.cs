using ScheduleEntryForms.Configurations;

namespace ScheduleEntryForms.ViewModels
{
    public interface IHeatingCoolingPanelViewModelFactory
    {
        HeatingCoolingPanelViewModel CreateViewModel(IHeatingCoolingConfiguration heatingCoolingConfiguration);
    }
}
