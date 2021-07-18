//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static AsmCodes;

    [Flags]
    public enum OpCodeTokenKind : ushort
    {
        None = 0,

        /// <summary>
        /// Classifies <see cref='PrefixToken'/> tokens
        /// </summary>
        Prefix = 1,

        /// <summary>
        /// Classifies <see cref='RexBToken'/> tokens
        /// </summary>
        RexBExtension = 2,

        /// <summary>
        /// Classifies <see cref='ModRmToken'/> tokens
        /// </summary>
        RegOpCodeMod = 4,

        /// <summary>
        /// Classifies <see cref='SegOverrideToken'/> tokens
        /// </summary>
        SegOverride = 8,

        /// <summary>
        /// Classifies <see cref='OffsetToken'/> tokens
        /// </summary>
        Offset = 16,

        /// <summary>
        /// Classifies <see cref='ImmSizeToken'/> tokens
        /// </summary>
        ImmSize = 32,

        /// <summary>
        /// Classifies <see cref='ExclusionToken'/> tokens
        /// </summary>
        Exclusion = 64,

        /// <summary>
        /// Classifies <see cref='FpuDigitToken'/> tokens
        /// </summary>
        FpuDigit = 128,
    }
}