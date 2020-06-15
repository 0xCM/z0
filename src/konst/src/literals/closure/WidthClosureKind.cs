//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum WidthClosureKind : byte
    {
        None = 0,
        
        /// <summary>
        /// Indicates closure is specified for an explicitly-specified set naturals
        /// </summary>
        Individuals = 1,

        /// <summary>
        /// Indicates closure is specified for a continuous power-of-two sequence
        /// </summary>
        Range = 2,
    }
}