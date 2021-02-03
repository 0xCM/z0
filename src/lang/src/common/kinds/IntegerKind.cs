//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using static DataWidth;

    [System.Flags]
    public enum IntegerKind : ushort
    {
        None = 0,

        /// <summary>
        /// Classifies signed integral types
        /// </summary>
        Signed = Pow2x16.P2ᐞ15,

        Bit = W1,

        Int2u = W2,

        Int2i = W2 | Signed,

        Int3u = W3,

        Int3i = W3 | Signed,

        Int4u = W4,

        Int4i = W4 | Signed,

        Int5u = W5,

        Int5i = W5 | Signed,

        Int6u = W6,

        Int6i = W6 | Signed,

        Int7u = W7,

        Int7i = W7 | Signed,

        Int8u = W8,

        Int8i = W8 | Signed,

        Int16u = W16,

        Int16i = W16 | Signed,

        Int32u = W32,

        Int32i = W32 | Signed,

        Int64u = W64,

        Int64i = W64 | Signed,

        Int128u = W128,

        Int128i = W128 | Signed,

        Int256u = W256,

        Int256i = W256 | Signed,

        Int512u = W512,

        Int512i = W512 | Signed,
    }
}