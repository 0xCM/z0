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
        public string Name {get;}

        public bool ByRef {get;}

        public bool CombineCustomName {get;}
         
        public OpAttribute()
        {
            this.Name = string.Empty;
            this.ByRef = false;
            this.CombineCustomName = true;
        }

        public OpAttribute(string name, bool combine = true)
        {
            this.Name = name;
            this.ByRef = false;
            this.CombineCustomName = combine;
        }

        public override string ToString()
            => Name;
    }
}