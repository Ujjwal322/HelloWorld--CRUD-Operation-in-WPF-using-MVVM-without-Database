using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Service
{
   public class PersonDataAccess : IPerson
    {
        public IEnumerable<Model.Person> GetAllDetails()
        {
            var List_Data = new List<Model.Person>();
            List_Data.Add(new Model.Person()
            {
                Name = "Ujjwal",
                SID = 50679,
                Location = "Vadodara",
                EDate = "16-10-2016"
            }
                );

            List_Data.Add(new Model.Person()
            {
                Name = "Nisrag",
                SID = 50668,
                Location = "Surat",
                EDate = "15-10-2016"
            }
            );

            List_Data.Add(new Model.Person()
            {
                Name = "Balkesh",
                SID = 50669,
                Location = "Ahemdabad",
                EDate = "14-10-2016"
            }
            );

            List_Data.Add(new Model.Person()
            {
                Name = "Nilesh",
                SID = 50469,
                Location = "Vadodara",
                EDate = "14-10-2016"
            }
            );


            List_Data.Add(new Model.Person()
            {
                Name = "Hiren",
                SID = 50569,
                Location = "Pune",
                EDate = "14-10-2016"
            }
            );

            return List_Data;

        }

    }
}
