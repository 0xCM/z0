//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using W = DataWidth;

    partial struct RuleModels
    {
        [System.Flags]
        public enum IntegerKind : ushort
        {
            None = 0,

            /// <summary>
            /// Classifies signed integral types
            /// </summary>
            Signed = Pow2x16.P2ᐞ15,

            Bit = W.W1,

            Int2u = W.W2,

            Int2i = W.W2 | Signed,

            Int3u = W.W3,

            Int3i = W.W3 | Signed,

            Int4u = W.W4,

            Int4i = W.W4 | Signed,

            Int5u = W.W5,

            Int5i = W.W5 | Signed,

            Int6u = W.W6,

            Int6i = W.W6 | Signed,

            Int7u = W.W7,

            Int7i = W.W7 | Signed,

            Int8u = W.W8,

            Int8i = W.W8 | Signed,

            Int16u = W.W16,

            Int16i = W.W16 | Signed,

            Int32u = W.W32,

            Int32i = W.W32 | Signed,

            Int64u = W.W64,

            Int64i = W.W64 | Signed,

            Int128u = W.W128,

            Int128i = W.W128 | Signed,

            Int256u = W.W256,

            Int256i = W.W256 | Signed,

            Int512u = W.W512,

            Int512i = W.W512 | Signed,
        }
    }
}