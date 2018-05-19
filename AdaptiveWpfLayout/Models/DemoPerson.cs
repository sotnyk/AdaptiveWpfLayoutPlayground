using AdaptiveWpfLayout.Services;
using System.Linq;

namespace AdaptiveWpfLayout
{
    class DemoPerson: Person
    {
        public DemoPerson()
        {
            var orig = PersonsGenerator.GenerateCollection().Last();
            Id = orig.Id;
            DisplayName = orig.DisplayName;
            Birthday = orig.Birthday;
            Address = orig.Address;
            AttendingDoctor = orig.AttendingDoctor;
            DeputyDoctor = orig.DeputyDoctor;
            Email = orig.Email;
            Plans = orig.Plans;
            Files = orig.Files;
            Parameters = orig.Parameters;
        }
    }
}
