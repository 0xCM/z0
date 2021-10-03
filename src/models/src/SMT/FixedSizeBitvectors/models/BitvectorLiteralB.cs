//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models.SMT
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct FixedSizeBitvectors
    {
        /// <summary>
        /// All binaries #bX of sort (_ BitVec m) where m is the number of digits in X.
        /// </summary>
        public readonly struct BitvectorLiteralB
        {
            readonly Index<BinaryDigit> Data;

            [MethodImpl(Inline)]
            public BitvectorLiteralB(BinaryDigit[] bits)
            {
                Data = bits;
            }

            public uint N
            {
                [MethodImpl(Inline)]
                get => Data.Count;
            }

            [MethodImpl(Inline)]
            public static implicit operator BitvectorLiteralB(BinaryDigit[] bits)
                => new BitvectorLiteralB(bits);
        }
    }
}