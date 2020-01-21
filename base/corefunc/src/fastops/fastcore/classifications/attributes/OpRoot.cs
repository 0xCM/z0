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

    public class OpAttribute : Attribute
    {
        public OpAttribute()
        {
            this.Name = string.Empty;
        }

        public OpAttribute(string name)
        {
            this.Name = name;
        }

        public string Name {get;}

        public override string ToString()
            => Name;
    }
}