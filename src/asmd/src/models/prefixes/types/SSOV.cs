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
        public readonly struct SSOV : ILegacyPrefix<X36>
        {
            public static SSOV Value => default;

            public LegacyPrefixKind Group 
                => LegacyPrefixKind.SO;
        }

    }
}