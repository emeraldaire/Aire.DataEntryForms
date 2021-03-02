using FormEntryDesign;

namespace ScheduleEntryForms.ViewModels
{
    public class UniversalEquipmentHeaderViewModel : ViewModelBase
    {
        private string _equipmentTag;

        public string EquipmentTag
        {
            get { return _equipmentTag; }
            set 
            { 
                _equipmentTag = value;
                OnPropertyChanged();
            }
        }

        public UniversalEquipmentHeaderViewModel()
        {
            EquipmentTag = "hello Nhan";
        }




    }
}
