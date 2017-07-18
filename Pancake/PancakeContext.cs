using System;
using System.Collections.Generic;

namespace Pancake
{
    public class PancakeContext
    {
        public List<PropertyMap> Properties { get; set; }
    }

    public class PropertyMap
    {
        public Type Type { get; set; }

        public string Name { get; set; }
        public bool Hidden { get; set; }
        public int Order { get; set; }
    }

    public class PrimativePropertyMap : PropertyMap
    {

    }

    public class NestedPropertyMap : PropertyMap
    {
        public List<PropertyMap> Properties { get; set; }
    }

    public class EnumerablePropertyMap : PropertyMap
    {
        public int MaxCount { get; set; }
        public PropertyMap NestedTypes { get; set; }
    }
}
