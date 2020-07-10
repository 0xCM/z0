//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    [AttributeUsage(AttributeTargets.Struct)]
    public class CustomSpanAttribute : Attribute
    {            
        public CustomSpanAttribute(string indicator)
        {
            this.Indicator = indicator;
        }

        public string Indicator {get;}
    }
}