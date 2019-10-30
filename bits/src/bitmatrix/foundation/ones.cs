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
        /// <summary>
        /// Allocates a 1-filled generic bitmatrix
        /// </summary>
        /// <typeparam name="T">The matrix primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<T> ones<T>()
            where T : unmanaged
                => BitMatrix.broadcast<T>(BitVector.ones<T>());

        /// <summary>
        /// Allocates a 0-filled generic bitmatrix
        /// </summary>
        /// <typeparam name="T">The matrix primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<T> zero<T>()
            where T : unmanaged
                => BitMatrix.alloc<T>();

        /// <summary>
        /// Allocates a generic identity matrix
        /// </summary>
        /// <typeparam name="T">The matrix primal type</typeparam>
        public static BitMatrix<T> identity<T>()
            where T : unmanaged
        {            
            var dst = zero<T>();
            var len = bitsize<T>();
            var one = gmath.one<T>();
            for(var i=0; i < len; i++)
                dst[i] = gmath.sll(one,i);
            return dst;
        }

        /// <summary>
        /// Allocates a 1-filled natural bitmatrix
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
        /// Allocates a 1-filled bitmatrix of natural order
        /// </summary>
        /// <typeparam name="M">The row dimension</typeparam>
        /// <typeparam name="N">The column dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> ones<N,T>(N n = default)
            where N : ITypeNat, new()
            where T : unmanaged
        {                                
            var A = BitMatrix<N,T>.Alloc();
            A.Data.Fill(gmath.maxval<T>());
            return A;
        }

    }

}