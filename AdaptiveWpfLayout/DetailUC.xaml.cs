using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AdaptiveWpfLayout
{
    /// <summary>
    /// Interaction logic for DetailUC.xaml
    /// </summary>
    public partial class DetailUC : UserControl
    {
        public DetailUC()
        {
            InitializeComponent();
            if (ViewModelBase.IsInDesignModeStatic) return;
        }

        private const int OneColumnDesignWidth = 1150;
        private int? _columns = null;

        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
            if (e.Property.Name == nameof(ActualWidth))
            {
                if (ActualWidth < OneColumnDesignWidth)
                {
                    if (_columns == 1) return;
                    Column1.Width = new GridLength(0, GridUnitType.Pixel);
                    Grid.SetColumn(FilesGrid, 0);
                    Grid.SetRow(FilesGrid, 3);
                    Grid.SetColumnSpan(FieldsPanel, 1);
                    Grid.SetColumnSpan(ParametersPanel, 1);
                    _columns = 1;
                }
                else
                {
                    if (_columns == 2) return;
                    Column1.Width = new GridLength(1, GridUnitType.Star);
                    Grid.SetColumn(FilesGrid, 1);
                    Grid.SetRow(FilesGrid, 2);
                    Grid.SetColumnSpan(FieldsPanel, 2);
                    Grid.SetColumnSpan(ParametersPanel, 2);
                    _columns = 2;
                }
            }
        }

        private void Grid_AutoGeneratingColumn_HideInDesign(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyName == nameof(ViewModelBase.IsInDesignMode))
                e.Cancel = true;
        }        
    }
}
