//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Pow2x16;

    using LK = ClrLiteralKind;

    public enum ConstantKind : ushort
    {
        None = 0,

        /// <summary>
        /// A bit/bool
        /// </summary>
        Bit = LK.U1,

        /// <summary>
        /// An 8-bit unsigned integer
        /// </summary>
        u8 = LK.U8,

        /// <summary>
        /// A 16-bit unsigned integer
        /// </summary>
        u16 = LK.U16,

        /// <summary>
        /// A 32-bit unsigned integer
        /// </summary>
        u32 = LK.U32,

        /// <summary>
        /// A 64-bit unsigned integer
        /// </summary>
        u64 = LK.U64,

        /// <summary>
        /// A 8-bit signed integer
        /// </summary>
        i8 = LK.I8,

        /// <summary>
        /// A 16-bit signed integer
        /// </summary>
        i16 = LK.I16,

        /// <summary>
        /// A 32-bit signed integer
        /// </summary>
        i32 =  LK.I32,

        /// <summary>
        /// A 64-bit signed integer
        /// </summary>
        i64 = LK.I64,

        /// <summary>
        /// A 32-bit float
        /// </summary>
        f32 = LK.F32,

        /// <summary>
        /// A 64-bit float
        /// </summary>
        f64 = LK.F64,

        /// <summary>
        /// A 128-bit float
        /// </summary>
        f128 = LK.F128,

        /// <summary>
        /// A 16-bit character
        /// </summary>
        c16 = LK.C16,

        /// <summary>
        /// A string
        /// </summary>
        String = LK.String,

        /// <summary>
        /// Identifies a constant sequence
        /// </summary>
        Seq = P2ᐞ06,

        /// <summary>
        /// A bit sequence of literal length
        /// </summary>
        u1Seq = Bit | Seq,

        /// <summary>
        /// A u8 sequence of literal length
        /// </summary>
        u8Seq = u8 | Seq,

        /// <summary>
        /// A u16 sequence of literal length
        /// </summary>
        u16Seq = u16 | Seq,

        /// <summary>
        /// A u32 sequence of literal length
        /// </summary>
        u32Seq = u32 | Seq,

        /// <summary>
        /// An i8 sequence of literal length
        /// </summary>
        i8Seq = i8 | Seq,

        /// <summary>
        /// An i16 sequence of literal length
        /// </summary>
        i16Seq = i16 | Seq,

        /// <summary>
        /// An i32 sequence of literal length
        /// </summary>
        i32Seq = i32 | Seq,

        /// <summary>
        /// An i64 sequence of literal length
        /// </summary>
        i64Seq = i64 | Seq,

        /// <summary>
        /// An f32 sequence of literal length
        /// </summary>
        f32Seq = f32 | Seq,

        /// <summary>
        /// An f64 sequence of literal length
        /// </summary>
        f64Seq = f64 | Seq,

        /// <summary>
        /// An f128 sequence of literal length
        /// </summary>
        f128Seq = f128 | Seq,

        /// <summary>
        /// A character sequence of literal length
        /// </summary>
        c16Seq = c16 | Seq,

        /// <summary>
        /// A string sequence of literal length
        /// </summary>
        StringSeq = String | Seq,
    }
}