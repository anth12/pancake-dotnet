using System.Collections.Generic;

namespace Pancake.Tests.Models
{
    public class ComplexModel
    {
        [Flat("String")]
        public List<string> StringList { get; set; }

        [Flat("Int")]
        public List<int> IntList { get; set; }

        [Flat("Nested Item")]
        public NestedModel Nested { get; set; }

        [Flat(Hidden = true)]
        public string HiddenProperty { get; set; }
    }

    public class NestedModel
    {
        public string Name { get; set; }
        public NestedModel Child { get; set; }
    }
}
