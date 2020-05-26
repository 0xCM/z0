//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    partial class Prefixes
    {
        /// <summary>
        /// Forces use of the current CS segment for memory operands
        /// </summary>
        public readonly struct CSOV : ILegacyPrefix<X2E>
        {
            public static CSOV Value => default;
            
            public LegacyPrefixKind Group 
                => LegacyPrefixKind.SO;
        }
    }
}