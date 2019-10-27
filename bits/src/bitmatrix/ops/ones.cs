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

    using static zfunc;
    using static As;

    partial class BitMatrix
    {        

        [MethodImpl(Inline)]
        public static BitMatrix<T> ones<T>()
            where T : unmanaged
        {
            var dst = BitMatrix.alloc<T>();
            dst.Rows.Fill(gmath.maxval<T>());
            return dst;
        }

        [MethodImpl(Inline)]
        public static BitMatrix<T> zero<T>()
            where T : unmanaged
                => BitMatrix.alloc<T>();

        /// <summary>
        /// Allocates a one-filled mxn matrix
        /// </summary>
        /// <typeparam name="M">The row dimension</typeparam>
        /// <typeparam name="N">The column dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> ones<M,N,T>(M m = default, N n = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
                => BitMatrix<M,N,T>.Ones();

        /// <summary>
        /// Returns an immutable reference to the 1-filled N-square matrix
        /// </summary>
        /// <typeparam name="M">The row dimension</typeparam>
        /// <typeparam name="N">The column dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> ones<N,T>(N n = default)
            where N : ITypeNat, new()
            where T : unmanaged
                => BitMatrix<N,T>.Ones;

        /// <summary>
        /// Returns an immutable reference to the N-square identity matrix
        /// </summary>
        /// <typeparam name="N">The column/row dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static BitMatrix<N,T> identity<N,T>(N n = default, T rep = default)
            where N : ITypeNat, new()
            where T : unmanaged
                => BitMatrix<N,T>.Identity;


    }

}