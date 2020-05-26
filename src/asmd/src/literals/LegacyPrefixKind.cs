//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;

    using static Seed;

    /// <summary>
    /// Defines legacy prefix partitions related, but not identical to, the legacy
    /// prefix groups specified in Intel Vol2A 2.1.1
    /// </summary>
    [Flags]
    public enum LegacyPrefixKind : byte
    {
        None = 0,

        /// <summary>
        /// Classifies the operand size override prefix
        /// </summary>
        OzO = 1,

        /// <summary>
        /// Classifies the address size override prefix
        /// </summary>
        AzO = 2,

        /// <summary>
        /// Classifies segment override prefixes
        /// </summary>
        SO = 4,

        /// <summary>
        /// Classifies the lock prefix
        /// </summary>
        Lock = 8,

        /// <summary>
        /// Classifies repeat override prefixes
        /// </summary>
        Repeat = 16,
    }
}