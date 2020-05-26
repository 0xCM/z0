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
        /// Causes certain kinds of memory read-modify-write instructions to occur atomically.
        /// </summary>
        public readonly struct LOCK : ILegacyPrefix<XF0>
        {
            public static LOCK Value => default;
            
            public LegacyPrefixKind Group 
                => LegacyPrefixKind.Lock;
        }
    }
}