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
        static Vector128<T> gcell<T>(in Vector128<T> g, int index, T data)
            where T : unmanaged
                => g.WithElement(index, data);

        [MethodImpl(Inline)]
        static Vector256<T> gcell<T>(in Vector256<T> g, int index, T data)
            where T : unmanaged
                => g.WithElement(index, data);


       /// <summary>
        /// Retuns a zero-filled bitgrid
        /// </summary>
        /// <param name="n">The width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        static BitGrid16<T> bg16<T>(int rows, int cols, ushort data)
            where T : unmanaged
                => new BitGrid16<T>(data, rows, cols);

        /// <summary>
        /// Retuns a zero-filled bitgrid
        /// </summary>
        /// <param name="n">The width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        static BitGrid32<T> bg32<T>(int rows, int cols, uint data)
            where T : unmanaged
                => new BitGrid32<T>(data, rows, cols);

        /// <summary>
        /// Retuns a zero-filled bitgrid
        /// </summary>
        /// <param name="n">The width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        static BitGrid64<T> bg64<T>(int rows, int cols, ulong data)
            where T : unmanaged
                => new BitGrid64<T>(data, rows, cols);

        [MethodImpl(Inline)]
        static BitGrid16<M,N,T> alloc16<M,N,T>(M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new BitGrid16<M, N, T>(z16);

        [MethodImpl(Inline)]
        static BitGrid32<M,N,T> alloc32<M,N,T>(M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new BitGrid32<M, N, T>(z32);

        [MethodImpl(Inline)]
        static BitGrid64<M,N,T> alloc64<M,N,T>(M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new BitGrid64<M, N, T>(z64);

        [MethodImpl(Inline)]
        static BitGrid128<M,N,T> alloc128<M,N,T>(M m = default, N n = default, T fill = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new BitGrid128<M, N, T>(ginx.vbroadcast(n128, fill));

        [MethodImpl(Inline)]
        static BitGrid256<M,N,T> alloc256<M,N,T>(M m = default, N n = default, T fill = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => new BitGrid256<M, N, T>(ginx.vbroadcast(n256, fill));
    }

}