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
        public readonly struct Bitvector<T>
            where T : unmanaged
        {
            readonly bits<T> Data;

            [MethodImpl(Inline)]
            public Bitvector(bits<T> src)
            {
                Data = src;
            }

            public uint N
            {
                [MethodImpl(Inline)]
                get => Data.N;
            }
        }
    }
}