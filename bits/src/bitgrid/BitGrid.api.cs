//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public static unsafe class BitGrid
    {
        [MethodImpl(NotInline)]
        public static BitGrid<M,N,T> alloc<M,N,T>(M m = default, N n = default, T zero = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var map = BitGridInfo<M,N,T>.Map;
            Span<T> data = new T[map.Segments];
            return new BitGrid<M, N, T>(data, map);
        }

        [MethodImpl(NotInline)]
        public static BitGrid<M,N,T> load<M,N,T>(Span<T> src, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var map = BitGridInfo<M,N,T>.Map;
            require(src.Length == map.Segments);
            return new BitGrid<M, N, T>(src, map);
        }

        [MethodImpl(Inline)]
        public static void fill<M,N,T>(BitGrid<M,N,T> grid, bit state)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => grid.Data.Fill(state ? gmath.maxval<T>() : gmath.zero<T>());


        [MethodImpl(Inline)]
        public static ref BitGrid2 and(in BitGrid2 g1, in BitGrid2 g2, ref BitGrid2 g3)
        {
            var pX = g1.HeadPtr;
            var pY = g2.HeadPtr;
            var pZ = g3.HeadPtr;
            ginx.vand(n128, pX, pY, pZ);
            return ref g3;
        }

        [MethodImpl(Inline)]
        public static ref BitGrid<M,N,T> and<M,N,T>(in BitGrid<M,N,T> g1, in BitGrid<M,N,T> g2, ref BitGrid<M,N,T> g3)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var pX = g1.HeadPtr;
            var pY = g2.HeadPtr;
            var pZ = g3.HeadPtr;
            ginx.vand(n128, pX, pY, pZ);
            return ref g3;
        }

    }

    class BitGridInfo<M,N,T>
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        public static readonly GridMap Map = GridLayout.map<M,N,T>();
    }
}