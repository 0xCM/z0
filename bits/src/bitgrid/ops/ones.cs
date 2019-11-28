//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitGrid
    {        
        [MethodImpl(Inline)]
        public static ref readonly BitGrid<M,N,T> ones<M,N,T>(in BitGrid<M,N,T> dst)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
        {
            broadcast(maxval<T>(), dst);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static BitGrid<M,N,T> ones<M,N,T>(M m = default, N n = default, T zero = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
        {
            var dst = alloc<M,N,T>();
            ones(dst);
            return dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly BitGrid<T> ones<T>(in BitGrid<T> dst)
            where T : unmanaged
        {
            broadcast(maxval<T>(), dst);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static BitGrid<T> ones<T>(int rows, int cols, T zero = default)
            where T : unmanaged
        {
            var dst = alloc<T>(rows,cols);
            ones(dst);
            return dst;
        }

        [MethodImpl(Inline)]
        public static BitGrid32<T> ones<T>(N32 n, T zero = default)
            where T : unmanaged
                => uint.MaxValue;

        [MethodImpl(Inline)]
        public static BitGrid64<T> ones<T>(N64 n, T zero = default)
            where T : unmanaged
                => ulong.MaxValue;

        [MethodImpl(Inline)]
        public static BitGrid128<T> ones<T>(N128 n, T zero = default)
            where T : unmanaged
                => ginx.vones<T>(n);

        [MethodImpl(Inline)]
        public static BitGrid256<T> ones<T>(N256 n, T zero = default)
            where T : unmanaged
                => ginx.vones<T>(n);

        [MethodImpl(Inline)]
        public static BitGrid128<M,N,T> ones<M,N,T>(N128 width, M m = default, N n = default, T zero = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => ginx.vones<T>(width);

        [MethodImpl(Inline)]
        public static BitGrid256<M,N,T> ones<M,N,T>(N256 width, M m = default, N n = default, T zero = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => ginx.vones<T>(width);

    }
}
