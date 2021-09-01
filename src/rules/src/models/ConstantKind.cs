//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using NK = Rules.NumericKind;
    using LK = LiteralKind;
    using DK = Rules.DataKind;

    partial struct Rules
    {
        [System.Flags]
        public enum ConstantKind : ushort
        {
            None = 0,

            /// <summary>
            /// A bit/bool
            /// </summary>
            Bit = NK.Bit,

            /// <summary>
            /// An 8-bit unsigned integer
            /// </summary>
            Int8u = NK.Int8u,

            /// <summary>
            /// A 8-bit signed integer
            /// </summary>
            Int8i = NK.Int8i,

            /// <summary>
            /// A 16-bit unsigned integer
            /// </summary>
            Int16u = NK.Int16u,

            /// <summary>
            /// A 16-bit signed integer
            /// </summary>
            Int16i = NK.Int16i,

            /// <summary>
            /// A 32-bit unsigned integer
            /// </summary>
            Int32u = NK.Int32u,

            /// <summary>
            /// A 32-bit signed integer
            /// </summary>
            Int32i = NK.Int32i,

            /// <summary>
            /// A 64-bit unsigned integer
            /// </summary>
            Int64u = NK.Int64u,

            /// <summary>
            /// A 64-bit signed integer
            /// </summary>
            Int64i = NK.Int64i,

            /// <summary>
            /// A 32-bit float
            /// </summary>
            Float32 = NK.Float32,

            /// <summary>
            /// A 64-bit float
            /// </summary>
            Float64 = NK.Float64,

            /// <summary>
            /// A 128-bit float
            /// </summary>
            Float128 = NK.Float128,

            /// <summary>
            /// A 16-bit character
            /// </summary>
            Char16 = LK.C16,

            /// <summary>
            /// A string
            /// </summary>
            String = LK.String,

            /// <summary>
            /// A bit sequence of literal length
            /// </summary>
            BitSeq = Bit | DK.Seq,

            /// <summary>
            /// A u8 sequence of literal length
            /// </summary>
            Int8uSeq = Int8u | DK.Seq,

            /// <summary>
            /// An i8 sequence of literal length
            /// </summary>
            Int8iSeq = Int8i | DK.Seq,

            /// <summary>
            /// A u16 sequence of literal length
            /// </summary>
            Int16uSeq = Int16u | DK.Seq,

            /// <summary>
            /// An i16 sequence of literal length
            /// </summary>
            Int16iSeq = Int16i | DK.Seq,

            /// <summary>
            /// A u32 sequence of literal length
            /// </summary>
            Int32uSeq = Int32u | DK.Seq,

            /// <summary>
            /// An i32 sequence of literal length
            /// </summary>
            Int32iSeq = Int32i | DK.Seq,

            /// <summary>
            /// An f32 sequence of literal length
            /// </summary>
            Float32Seq = Float32 | DK.Seq,

            /// <summary>
            /// An i64 sequence of literal length
            /// </summary>
            Int64iSeq = Int64i | DK.Seq,

            /// <summary>
            /// An f64 sequence of literal length
            /// </summary>
            Float64Seq = Float64 | DK.Seq,

            /// <summary>
            /// An f128 sequence of literal length
            /// </summary>
            Float128Seq = Float128 | DK.Seq,

            /// <summary>
            /// A character sequence of literal length
            /// </summary>
            Char16Seq = Char16 | DK.Seq,

            /// <summary>
            /// A string sequence of literal length
            /// </summary>
            StringSeq = String | DK.Seq,
        }
    }
}