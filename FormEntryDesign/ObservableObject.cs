using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FormEntryDesign
{
    public class ObservableObject : INotifyPropertyChanged
    {
        //When the CurrentViewModel is changed by a NavButton, we implement 'INotifyPropertyChanged' to carry the news through to the UI.
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
