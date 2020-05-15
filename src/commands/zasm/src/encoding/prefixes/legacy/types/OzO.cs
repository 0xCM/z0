//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct OzO : ILegacyPrefix<X66>
    {
        public static OzO Value => default;
             
        public LegacyPrefixGroup Group 
            => LegacyPrefixGroup.OzO;
    }
}