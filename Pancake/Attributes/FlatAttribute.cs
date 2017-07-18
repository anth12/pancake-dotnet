using System;
using System.Collections.Generic;
using System.Text;

namespace Pancake
{
    public class FlatAttribute : Attribute
    {
        #region Constructors

        public FlatAttribute()
        {

        }
        public FlatAttribute(string propertyName)
        {
            PropertyName = propertyName;
        }
        public FlatAttribute(bool hidden)
        {
            Hidden = hidden;
        }
        public FlatAttribute(int order)
        {
            Order = order;
        }

        public FlatAttribute(string propertyName, int order)
        {
            PropertyName = propertyName;
            Order = order;
        }

        #endregion

        public string PropertyName { get; set; }
        public bool Hidden { get; set; }
        public int? Order { get; set; }
    }
}
