using AdaptiveWpfLayout.Services;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace AdaptiveWpfLayout
{
    class MainWindowViewModel: ViewModelBase
    {
        public ObservableCollection<Person> Items { get; set; }

        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Person>(PersonsGenerator.GenerateCollection());
        }
    }
}
