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
        public readonly struct FSOV : ILegacyPrefix<X64>
        {
            public static FSOV Value => default;

            public LegacyPrefixKind Group 
                => LegacyPrefixKind.SO;
        }
    }
}