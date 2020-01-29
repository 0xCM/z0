//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class OpHostAttribute : Attribute
    {
        public OpHostAttribute(string Name)
        {
            this.Name = Name;
        }

        public string Name {get;}

    }

}

