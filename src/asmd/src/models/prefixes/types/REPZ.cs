//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Prefixes
    {
        public readonly struct REPZ : ILegacyPrefix<XF3>
        {
            public static REPZ Value => default;
            
            public LegacyPrefixGroup Group 
                => LegacyPrefixGroup.Repeat;
        }
    }
}