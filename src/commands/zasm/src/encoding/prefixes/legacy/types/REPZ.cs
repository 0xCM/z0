//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct REPZ : ILegacyPrefix<XF3>
    {
        public static REPZ Value => default;
        
        public LegacyPrefixGroup Group 
            => LegacyPrefixGroup.Repeat;
    }
}