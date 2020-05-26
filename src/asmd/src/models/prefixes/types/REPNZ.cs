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
        /// Repeats a compare-string or scan-string operation (CMPSx and SCASx) until the rCX register equals 0 or 
        /// the zero flag (ZF) is set to 1.
        /// </summary>
        public readonly struct REPNZ : ILegacyPrefix<XF2>
        {
            public static REPNZ Value => default;
            
            public LegacyPrefixKind Group 
                => LegacyPrefixKind.Repeat;
        }
    }
}