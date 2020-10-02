//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Identifies the primal numeric kinds
    /// </summary>
    /// <remarks>
    /// As a bitfield, Width = [0..2], Sign = [3], Floating = [4]
    /// <remarks>
    public enum PrimalNumericKind : byte
    {
        None = 0,

        /// <summary>
        /// Specifies an unsigned 8-bit integer
        /// </summary>
        U8 = 0b00011,

        /// <summary>
        /// Specifies an unsigned 16-bit integer
        /// </summary>
        U16 = 0b00100,

        /// <summary>
        /// Specifies an unsigned 32-bit integer
        /// </summary>
        U32 = 0b00101,

        /// <summary>
        /// Specifies an unsigned 64-bit integer
        /// </summary>
        U64 = 0b00110,

        /// <summary>
        /// Specifies a signed 8-bit integer
        /// </summary>
        I8 = 0b01011,

        /// <summary>
        /// Specifies a signed 16-bit integer
        /// </summary>
        I16 = 0b01100,

        /// <summary>
        /// Specifies a signed 32-bit integer
        /// </summary>
        I32 = 0b01101,

        /// <summary>
        /// Specifies a signed 64-bit integer
        /// </summary>
        I64 = 0b01110,

        /// <summary>
        /// Specifies a signed 32-bit floating-point number
        /// </summary>
        F32 = 0b10101,

        /// <summary>
        /// Specifies a signed 64-bit floating-point number
        /// </summary>
        F64 = 0b10110,
    }

    public readonly struct PrimalNumericKindE
    {
        public const PrimalNumericKind WidthMask = (PrimalNumericKind)0b0111;

        public const PrimalNumericKind SignMask = (PrimalNumericKind)0b1000;

        public const PrimalNumericKind FloatMask = (PrimalNumericKind)0b10000;
    }
}