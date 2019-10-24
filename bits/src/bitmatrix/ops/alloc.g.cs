//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {
        [MethodImpl(Inline)]
        public static BitMatrix<T> load<T>(Span<T> rows)
            where T : unmanaged
                => new BitMatrix<T>(rows);

        [MethodImpl(NotInline)]
        public static BitMatrix<T> alloc<T>()
            where T : unmanaged
                => new BitMatrix<T>(new Span<T>(new T[BitMatrix<T>.N]));

        /// <summary>
        /// Allocates a zero-filled n-square matrix
        /// </summary>
        /// <typeparam name="N">The square dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> alloc<N,T>(N n = default, T rep = default)
            where N : ITypeNat, new()
            where T : unmanaged
                => BitMatrix<N,T>.Alloc();
        
        /// <summary>
        /// Allocates a zero-filled mxn bitmatrix
        /// </summary>
        /// <typeparam name="M">The row dimension</typeparam>
        /// <typeparam name="N">The column dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> alloc<M,N,T>(M m = default, N n = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
                => BitMatrix<M,N,T>.Alloc();
    }

}