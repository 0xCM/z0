//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Forces use of the current CS segment for memory operands
    /// </summary>
    public readonly struct CSOV : ILegacyPrefix<X2E>
    {
        public static CSOV Value => default;
        
        public LegacyPrefixGroup Group 
            => LegacyPrefixGroup.SO;
    }
}