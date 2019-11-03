//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    using static zfunc;

    public static class BitGridX
    {   

        [MethodImpl(Inline)]
        public static BitGrid<N32,N32, uint> ToGrid(this BitMatrix32 src, N32 m = default, N32 n = default)
            => BitGrid.load(src.Data,m,n);

        [MethodImpl(Inline)]
        public static BitGrid<N64,N64,ulong> ToGrid(this BitMatrix64 src, N64 m = default, N64 n = default)
            => BitGrid.load(src.Data,m,n);

        [MethodImpl(Inline)]
        public static BitString ToBitString<M,N,T>(this BitGrid<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Data.ToBitString(src.BitMap.Volume);

    }

}