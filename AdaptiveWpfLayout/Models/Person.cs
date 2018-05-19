using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;

namespace AdaptiveWpfLayout
{
    class Person: ViewModelBase
    {
        public long Id { get; set; }
        public string DisplayName { get; set; }
        public DateTime Birthday { get; set; }
        public string Age { get => (DateTime.Now.Year - Birthday.Year).ToString() + " y"; }
        public string Address { get; set; }
        public string AttendingDoctor { get; set; }
        public string DeputyDoctor { get; set; }
        public string Email { get; set; }
        public IList<Document> Plans { get; set; } = new List<Document>();
        public IList<Document> Files { get; set; } = new List<Document>();
        public IList<Parameters> Parameters { get; set; } = new List<Parameters>();
    }
}
