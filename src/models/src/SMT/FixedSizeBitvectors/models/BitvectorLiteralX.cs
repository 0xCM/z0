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
        /// All hexadeximals #xX of sort (_ BitVec m) where m is 4 times the number of
        /// </summary>
        public readonly struct BitvectorLiteralX
        {
            readonly Index<HexDigit> Data;

            [MethodImpl(Inline)]
            public BitvectorLiteralX(HexDigit[] bits)
            {
                Data = bits;
            }

            public uint N
            {
                [MethodImpl(Inline)]
                get => Data.Count;
            }

            [MethodImpl(Inline)]
            public static implicit operator BitvectorLiteralX(HexDigit[] hex)
                => new BitvectorLiteralX(hex);
        }
    }
}