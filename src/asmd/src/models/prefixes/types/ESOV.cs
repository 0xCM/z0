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
        public readonly struct ESOV : ILegacyPrefix<X26>
        {
            public static ESOV Value => default;

            public LegacyPrefixGroup Group 
                => LegacyPrefixGroup.SO;
        }

    }
}