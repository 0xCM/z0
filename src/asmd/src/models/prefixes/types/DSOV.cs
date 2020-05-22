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
        public readonly struct DSOV : ILegacyPrefix<X32>
        {
            public static DSOV Value => default;
            
            public LegacyPrefixGroup Group 
                => LegacyPrefixGroup.SO;
        }
    }
}