//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Seed;

    using static PrimalWidthFactor;
    using static Sign8;

    using K = PrimalKindId;
    using S = PrimalKindSeg;
    
    /// <summary>
    /// Defines a bitfield that identifies and describes system type primitives
    /// </summary>    
    /// <remarks>
    /// [PrimalWidthFactor:0..2 | PrimalKindId:3..6 | Sign8:7]
    /// <remarks>
    public enum PrimalKind : byte
    {
        None = 0,

        /// <summary>
        /// Specifies a boolean value
        /// </summary>
        U1 = w1 << S.Width | K.U1 << S.KindId,

        /// <summary>
        /// Specifies an unsigned 8-bit integer
        /// </summary>
        U8 = w8 << S.Width | K.U8 << S.KindId,

        /// <summary>
        /// Specifies an unsigned 16-bit integer
        /// </summary>
        U16 = w16 << S.Width | K.U16 << S.KindId,

        /// <summary>
        /// Specifies an unsigned 32-bit integer
        /// </summary>
        U32 = w32 << S.Width | K.U32 <<  S.KindId,

        /// <summary>
        /// Specifies an unsigned 64-bit integer
        /// </summary>
        U64  = w64 << S.Width | K.U64 <<  S.KindId,

        /// <summary>
        /// Specifies a signed 8-bit integer
        /// </summary>
        I8 = w8 << S.Width | K.I8 << S.KindId | Signed,

        /// <summary>
        /// Specifies a signed 16-bit integer
        /// </summary>
        I16 = w16 << S.Width | K.I16 << S.KindId | Signed,

        /// <summary>
        /// Specifies a signed 32-bit integer
        /// </summary>
        I32 = w32 << S.Width | K.I32 << S.KindId | Signed,

        /// <summary>
        /// Specifies a signed 64-bit integer
        /// </summary>
        I64 = w64 << S.Width | K.I64 << S.KindId | Signed,

        /// <summary>
        /// Specifies a signed 32-bit floating-point number
        /// </summary>
        F32 = w32 << S.Width | K.F32 << S.KindId,

        /// <summary>
        /// Specifies a signed 64-bit floating-point number
        /// </summary>
        F64 = w64 << S.Width | K.F64 << S.KindId,
        
        /// <summary>
        /// Specifies a signed 64-bit floating-point number
        /// </summary>
        F128 = w128 << S.Width | K.F128 <<  S.KindId,

        /// <summary>
        /// Specifies a 16-bit unicode character
        /// </summary>
        Char16 = w16 << S.Width | K.Char16 << S.KindId,

        /// <summary>
        /// Specifies a 16-bit unicode character
        /// </summary>
        String = w0 << S.Width | K.Char16 << S.KindId,
    }
}