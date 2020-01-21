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
    /// Identifies bitmatrix operations 
    /// </summary>
    public class BitMatrixOpAttribute : OpAttribute
    {
        public BitMatrixOpAttribute()
        {

        }

        public BitMatrixOpAttribute(string name)
            : base(name)
        {

        }

    }
}