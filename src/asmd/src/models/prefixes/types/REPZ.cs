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
        public readonly struct REPZ : ILegacyPrefix<XF3>
        {
            public static REPZ Value => default;
            
            public LegacyPrefixKind Group 
                => LegacyPrefixKind.Repeat;
        }
    }
}