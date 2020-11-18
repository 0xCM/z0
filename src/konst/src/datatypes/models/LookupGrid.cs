//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct LookupGrid<I,J,S,T>
        where I : unmanaged
        where J : unmanaged
        where S : unmanaged
    {
        internal readonly S[,] Index;

        internal readonly T[] Values;

        [MethodImpl(Inline)]
        internal LookupGrid(S[,] src, T[] dst)
        {
            Index = src;
            Values = dst;
        }

        public ref T this[I i, J j]
        {
            [MethodImpl(Inline)]
            get => ref Values[uint64(Index[uint64(i), uint64(j)])];
        }
    }
}