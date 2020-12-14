using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Model
{
    public class BracketEnum : INotifyPropertyChanged
    {
        public BracketEnum() { }
        [DefaultValue(ProgramDetermines)]
        [TypeConverter(typeof(EnumDescriptionTypeConverter))]
        public enum BracketOptionEnum
        {
            [Description("Program Determines")]
            ProgramDetermines,
            [Description("Built Up Beam")]
            BuiltUpBeam,
            [Description("Hot Rolled")]
            HotRolled
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
    //[DefaultValue(ProgramDetermines)]
    //[TypeConverter(typeof(EnumDescriptionTypeConverter))]
   
  
}
