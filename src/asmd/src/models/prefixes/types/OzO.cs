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
        public readonly struct OzO : ILegacyPrefix<X66>
        {
            public static OzO Value => default;
                
            public LegacyPrefixGroup Group 
                => LegacyPrefixGroup.OzO;
        }
    }
}