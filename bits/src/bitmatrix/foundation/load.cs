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

    partial class BitMatrix
    {        

        [MethodImpl(Inline)]
        public static BitMatrix<T> load<T>(Span<T> rows)
            where T : unmanaged
                => new BitMatrix<T>(rows);


        [MethodImpl(Inline)]
        public static BitMatrix<T> load<T>(RowBits<T> src)
            where T : unmanaged
        {
            if(src.RowCount != bitsize<T>())
                Errors.Throw($"{bitsize<T>()} != {src.RowCount}");

            return load(src.data);                
        }

        /// <summary>
        /// Creates a canonical permutation matrix by swapping matrix rows of the identity matrix as specified by a permutation
        /// </summary>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static BitMatrix64 from(Perm<N64> spec)
        {
            var id = BitMatrix64.Identity;
            permute(spec, ref id);
            return id;
        }

        /// <summary>
        /// Loads an n-square bitmatrix from an array
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The matrix order</param>
        /// <typeparam name="N">The matrix order type</typeparam>
        /// <typeparam name="T">The matrix cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> load<N,T>(T[] src, N n = default)        
            where N : ITypeNat, new()
            where T : unmanaged
                => BitMatrix<N,T>.Load(src); 

        /// <summary>
        /// Loads an n-square bitmatrix from an span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The matrix order</param>
        /// <typeparam name="N">The matrix order type</typeparam>
        /// <typeparam name="T">The matrix cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> load<N,T>(N n, Span<T> src)
            where N : ITypeNat, new()
            where T : unmanaged
                => BitMatrix<N,T>.Load(src); 

        /// <summary>
        /// Loads an MxN natural bitmatrix from an array
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="n">The matrix order</param>
        /// <typeparam name="N">The matrix order type</typeparam>
        /// <typeparam name="T">The matrix cell type</typeparam>
        [MethodImpl(NotInline)]
        public static BitMatrix<M,N,T> load<M,N,T>(T[] src, M m = default, N n = default)        
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
                => BitMatrix<M,N,T>.Load(src); 

    }

}