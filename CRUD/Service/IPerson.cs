using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Service
{
    public interface IPerson
    {
        IEnumerable<Model.Person> GetAllDetails();
    }
}
