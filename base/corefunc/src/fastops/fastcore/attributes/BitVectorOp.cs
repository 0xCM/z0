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
    /// Identifies bitvector operations 
    /// </summary>
    public class BitVectorOpAttribute : OpAttribute
    {
        public BitVectorOpAttribute()
        {

        }

        public BitVectorOpAttribute(string name)
            : base(name)
        {

        }

    }
}