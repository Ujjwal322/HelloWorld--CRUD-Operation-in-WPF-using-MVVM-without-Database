using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Model
{
    public class Person

    {
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private int _SID;

        public int SID
        {
            get { return _SID; }
            set { _SID = value; }
        }
        private string _Location;

        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }
        private string _EDate;

        public string EDate
        {
            get { return _EDate; }
            set { _EDate = value; }
        }
    }
}
