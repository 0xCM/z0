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

    /// <summary>
    /// Identifies operations that have one or more natural selectors
    /// </summary>
    public class NatOpAttribute : OpAttribute
    {
        public NatOpAttribute()
        {

        }

        public NatOpAttribute(string name)
            : base(name)
        {

        }

    }
}