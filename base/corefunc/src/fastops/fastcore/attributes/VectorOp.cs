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
    /// Identifies vectorized operations
    /// </summary>
    public class VectorOpAttribute : OpAttribute
    {
        public VectorOpAttribute()
        {

        }

        public VectorOpAttribute(string name)
            : base(name)
        {

        }
    }


}