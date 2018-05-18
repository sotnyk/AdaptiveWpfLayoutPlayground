using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveWpfLayout.Services
{
    static class PersonsGenerator
    {
        private static Random _rnd = new Random(1974);

        public static IList<Person> GenerateCollection()
        {
            var res = new List<Person>();

            for (int id = 1; id < 30; ++id)
            {
                res.Add(new Person
                {
                    Id = id,
                    DisplayName = $"Name{id}, Surname{id}",
                    Birthday = DateTime.Now - TimeSpan.FromDays(_rnd.Next(4000)),
                    AttendingDoctor = "House, Gregory",
                    DeputyDoctor = "Nora, Bergman",
                    Address = $"Zichzachweg {10 + id}, {id}{id}, Tihidorf",
                    Email = $"n{id}.surname{id}@domain.com",
                    Files = GenerateDocuments(id),
                    Plans = GenerateDocuments(id),
                    Parameters = GenerateParameters(id)
                });
            }

            return res;
        }

        private static IList<Parameters> GenerateParameters(int id)
        {
            var res = new List<Parameters>();
            var names = new string[] { "HR", "RR", "SpO2" };

            for (int i = 0; i < _rnd.Next(10); ++i)
            {
                res.Add(new Parameters
                {
                    ParameterName = names[i % names.Length],
                    Value1 = _rnd.Next(120),
                    Value2 = _rnd.Next(120),
                    Value3 = _rnd.Next(120),
                    Value4 = _rnd.Next(120),
                    UploadDate = DateTime.Now - TimeSpan.FromDays(1 + i * 2),
                    PrescriptionDate = DateTime.Now - TimeSpan.FromDays(2 + i * 2),
                    PrescribedBy = "House, Gregory",
                    LastValidatedBy = i < 4 ? "House, Gregory" : "N/A",
                    LastValidationDate = i < 4 ? DateTime.Now - TimeSpan.FromDays(1 + i * 2) : (DateTime?)null
                });
            }

            return res;
        }

        private static IList<Document> GenerateDocuments(int id)
        {
            var res = new List<Document>();

            var count = _rnd.Next(10);

            for (int i = 0; i < count; ++i)
            {
                res.Add(new Document
                {
                    UploadDate = DateTime.Now - TimeSpan.FromDays(1 + i * 2),
                    PrescriptionDate = DateTime.Now - TimeSpan.FromDays(2 + i * 2),
                    PrescribedBy = "House, Gregory",
                    Comments = (i == 0) ? "Active document" : "Deactivated",
                });
            }

            return res;
        }
    }
}
