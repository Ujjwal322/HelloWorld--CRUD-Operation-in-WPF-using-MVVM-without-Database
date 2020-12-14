using CRUD.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.Helper;

namespace CRUD.ViewModel
{
   public class CountryViewModel: ViewModelBase
    {

        public CountryViewModel()
        {
            StartUp();
        }

        public void StartUp()
        {
            LoadDetails();
        }

        public void LoadDetails()
        {
            var p = IPersonService.GetAllDetails();
            MasterData = new ObservableCollection<Model.Person>(p);

        }

        private IPerson _IPersonService;
        public IPerson IPersonService
        {
            get
            {

                if (_IPersonService == null)
                {
                    _IPersonService = new PersonDataAccess();
                }

                return _IPersonService;
            }

            set
            {
                _IPersonService = value;

            }
        }

        private ObservableCollection<Model.Person> _MasterData;
        public ObservableCollection<Model.Person> MasterData
        {
            get { return _MasterData; }
            set
            {
                SetPropertry(ref this._MasterData, value);
            }
        }
    }
}
