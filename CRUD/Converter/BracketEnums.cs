using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Converter
{
    public class BracketEnums : INotifyPropertyChanged
    {


        public BracketEnums()
        {
        
        }
        public enum BracketOptionEnums
        {
            [Description("ProgramDetermines")]
            ProgramDetermines,
            [Description("BuiltUpBeam")]
            BuiltUpBeam,
            [Description("HotRolled")]
            HotRolled
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
