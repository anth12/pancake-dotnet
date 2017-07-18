using System;
using System.Collections.Generic;
using System.Text;

namespace Pancake.Fluent
{
    public class PancakeRegistration
    {
        public PancakeConfig<TModel> Register<TModel>()
        {
            return new PancakeConfig<TModel>();
        }
    }
}
