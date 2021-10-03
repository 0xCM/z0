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
        public readonly struct Bitvector<N,T>
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            readonly bits<N,T> Data;

            [MethodImpl(Inline)]
            public Bitvector(bits<N,T> src)
            {
                Data = src;
            }
        }
    }
}