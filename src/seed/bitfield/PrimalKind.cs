//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Pow2Width;
    using static Sign8;

    using K = PrimalKindId;
    using I = PrimalKindBitField.SegIndex;

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
        U1 = w1 << I.Width | K.U1 << I.KindId,

        /// <summary>
        /// Specifies an unsigned 8-bit integer
        /// </summary>
        U8 = w8 << I.Width | K.U8 << I.KindId,

        /// <summary>
        /// Specifies an unsigned 16-bit integer
        /// </summary>
        U16 = w16 << I.Width | K.U16 << I.KindId,

        /// <summary>
        /// Specifies an unsigned 32-bit integer
        /// </summary>
        U32 = w32 << I.Width | K.U32 <<  I.KindId,

        /// <summary>
        /// Specifies an unsigned 64-bit integer
        /// </summary>
        U64  = w64 << I.Width | K.U64 <<  I.KindId,

        /// <summary>
        /// Specifies a signed 8-bit integer
        /// </summary>
        I8 = w8 << I.Width | K.I8 << I.KindId | Signed,

        /// <summary>
        /// Specifies a signed 16-bit integer
        /// </summary>
        I16 = w16 << I.Width | K.I16 << I.KindId | Signed,

        /// <summary>
        /// Specifies a signed 32-bit integer
        /// </summary>
        I32 = w32 << I.Width | K.I32 << I.KindId | Signed,

        /// <summary>
        /// Specifies a signed 64-bit integer
        /// </summary>
        I64 = w64 << I.Width | K.I64 << I.KindId | Signed,

        /// <summary>
        /// Specifies a signed 32-bit floating-point number
        /// </summary>
        F32 = w32 << I.Width | K.F32 << I.KindId,

        /// <summary>
        /// Specifies a signed 64-bit floating-point number
        /// </summary>
        F64 = w64 << I.Width | K.F64 << I.KindId,
        
        /// <summary>
        /// Specifies a signed 64-bit floating-point number
        /// </summary>
        F128 = w128 << I.Width | K.F128 <<  I.KindId,

        /// <summary>
        /// Specifies System.Object
        /// </summary>
        Object = K.Object << I.KindId,

        DBNull = K.DBNull << I.KindId,

        DateTime = w64 << I.Width | K.DateTime << I.KindId,

        /// <summary>
        /// Specifies a 16-bit unicode character
        /// </summary>
        Char16 = w16 << I.Width | K.Char16 << I.KindId,

        /// <summary>
        /// Specifies a 16-bit unicode character
        /// </summary>
        String = w0 << I.Width | K.Char16 << I.KindId,
    }
}