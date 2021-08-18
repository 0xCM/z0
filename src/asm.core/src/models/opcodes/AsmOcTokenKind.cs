//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmOpCodeTokens;

    public enum AsmOcTokenKind : byte
    {
        /// <summary>
        /// Classifies the untoken
        /// </summary>
        None = 0,

        /// <summary>
        /// Classifies the 256 literal hex bytes [0xOO, 0x01, ..., 0xFF]
        /// </summary>
        Byte,

        /// <summary>
        /// Classifies <see cref='RexToken'/> tokens
        /// </summary>
        Rex,

        /// <summary>
        /// Classifies <see cref='VexToken'/> tokens
        /// </summary>
        Vex,

        /// <summary>
        /// Classifies <see cref='EvexToken'/> tokens
        /// </summary>
        Evex,

        /// <summary>
        /// Classifies <see cref='EscapeToken'/> prefix tokens
        /// </summary>
        EscapePrefix,

        /// <summary>
        /// <summary>
        /// Classifies <see cref='RexBToken'/> tokens
        /// </summary>
        RexBExtension,

        /// <summary>
        /// Classifies <see cref='ModRmToken'/> tokens
        /// </summary>
        RegOpCodeMod,

        /// <summary>
        /// Classifies <see cref='SegOverrideToken'/> tokens
        /// </summary>
        SegOverride,

        /// <summary>
        /// Classifies <see cref='DispToken'/> tokens
        /// </summary>
        Disp,

        /// <summary>
        /// Classifies <see cref='ImmSizeToken'/> tokens
        /// </summary>
        ImmSize,

        /// <summary>
        /// Classifies <see cref='ExclusionToken'/> tokens
        /// </summary>
        Exclusion,

        /// <summary>
        /// Classifies <see cref='FpuDigitToken'/> tokens
        /// </summary>
        FpuDigit,

        /// <summary>
        /// Classifies <see cref='MaskToken'/> tokens
        /// </summary>
        Mask,

        /// <summary>
        /// Classifies <see cref='OpCodeOperator'/> tokens
        /// </summary>
        Operator,
    }
}