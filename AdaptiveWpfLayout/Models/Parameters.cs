using GalaSoft.MvvmLight;
using System;

namespace AdaptiveWpfLayout
{
    class Parameters : ViewModelBase
    {
        public string ParameterName { get; set; }
        public float Value1 { get; set; }
        public float Value2 { get; set; }
        public float Value3 { get; set; }
        public float Value4 { get; set; }
        public DateTime UploadDate { get; set; }
        public DateTime PrescriptionDate { get; set; }
        public string PrescribedBy { get; set; }
        public DateTime? LastValidationDate { get; set; }
        public string LastValidatedBy { get; set; }
    }
}
