//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum NatClosureKind : byte
    {
        None = 0,
        
        /// <summary>
        /// Indicates closure is specified for an explicitly-specified set naturals
        /// </summary>
        Individuals = 1,

        /// <summary>
        /// Indicates closure is specified for an inclusive range of naturals
        /// </summary>
        Range = 2,

        /// <summary>
        /// Indicates closure is specified for an inclusive range of natural powers of 2
        /// </summary>
        Powers2 = 3,
    }

}