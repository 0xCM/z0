//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;


    public abstract class TypeClosuresAttribute : Attribute
    {
        protected TypeClosuresAttribute(ulong selected)
        {
            this.Selected = selected;
        }

        public ulong Selected {get;}
    }

}