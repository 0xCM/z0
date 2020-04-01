//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using PR = ParamRefKind;

    /// <summary>
    /// Classifies method *value* parameters
    /// </summary>
    [Flags]
    public enum MethodParamClass : uint
    {
        /// <summary>
        /// The empty class
        /// </summary>
        None = 0,

        /// <summary>
        /// Classifies paramters that are declared with the "in" modifier
        /// </summary>
        In = PR.In,

        /// <summary>
        /// Classifies paramters that are declared with the "out" modifier
        /// </summary>
        Out = PR.Out,

        /// <summary>
        /// Classifies paramters that are declared with the "ref" modifier
        /// </summary>
        Ref = PR.Ref,

        /// <summary>
        /// Classifies paramters that require 8-bit immediate values
        /// </summary>
        Imm8 = byte.MaxValue + 1,

        /// <summary>
        /// Classifies paramters that require 16-bit immediate values
        /// </summary>
        Imm16 = Imm8 << 1,

        /// <summary>
        /// Classifies paramters that require 32-bit immediate values
        /// </summary>
        Imm32 = Imm16 << 1,

        /// <summary>
        /// Classifies paramters that require 64-bit immediate values
        /// </summary>
        Imm64 = Imm32 << 1,

        /// <summary>
        /// Classifies paramters that are of numeric kind
        /// </summary>
        Numeric = sbyte.MinValue * sbyte.MinValue,

        /// <summary>
        /// Classifies paramters that are of blocked kind
        /// </summary>
        Blocked = Numeric << 1,

        /// <summary>
        /// Classifies paramters of fixed kind
        /// </summary>
        Fixed = Blocked << 1,

        /// <summary>
        /// Classifies paramters that are of vectorized kind
        /// </summary>
        CpuVector = Fixed << 1,

        /// <summary>
        /// Classifies paramters of bitvector kind
        /// </summary>
        BitVector = CpuVector << 1,

        /// <summary>
        /// Classifies paramters of bitmatrix kind
        /// </summary>
        BitMatrix = BitVector << 1,

        /// <summary>
        /// Classifies paramters of bitgrid kind
        /// </summary>
        BitGrid = BitMatrix << 1,
    }
}