//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Hex8Seq;

    /// <summary>
    /// [0100 0001] | W:0 | R:0 | X:0 | B:1
    /// </summary>
    [Flags]
    public enum RexPrefixCode : byte
    {
        /// <summary>
        /// [0100 0000] => [W:0 | R:0 | X:0 | B:0]
        /// </summary>
        [Symbol("REX", "[0100 0000] => [W:0 | R:0 | X:0 | B:0]")]
        Base = x40,

        /// <summary>
        /// Extends one of:
        /// - The reg field in the ModR/M byte
        /// - The index field in the SIB byte
        /// - The reg field in the opcode byte
        /// </summary>
        [Symbol("REX.B", "[0100 0001] => [W:0 | R:0 | X:0 | B:1]")]
        B = x41,

        /// <summary>
        /// Extends the index field in the SIB byte
        /// </summary>
        [Symbol("REX.X", "[0100 0010] => [W:0 | R:0 | X:1 | B:0]")]
        X = x42,

        /// <summary>
        /// Extends the reg field in the ModR/M byte
        /// </summary>
        [Symbol("REX.R", "[0100 0100] =>[W:0 | R:1 | X:0 | B:0]")]
        R = x44,

        /// <summary>
        /// Wide, enables 64-bit execution
        /// </summary>
        [Symbol("REX.W", "[0100 1000] => [W:1 | R:0 | X:0 | B:0]")]
        W = x48,
    }
}