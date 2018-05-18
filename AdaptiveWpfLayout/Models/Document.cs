using GalaSoft.MvvmLight;
using System;

namespace AdaptiveWpfLayout
{
    class Document : ViewModelBase
    {
        public DateTime UploadDate { get; set; }
        public DateTime PrescriptionDate { get; set; }
        public string PrescribedBy { get; set; }
        public string Comments { get; set; }
    }
}
