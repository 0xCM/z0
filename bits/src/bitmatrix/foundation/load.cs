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
                
        /// <summary>
        /// Loads a generic bitmatrix from a span
        /// </summary>
        /// <param name="src">The row content</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<T> load<T>(Span<T> src)
            where T : unmanaged
                => new BitMatrix<T>(src);

        [MethodImpl(Inline)]
        public static BitMatrix8 load(N8 n, byte[] src)
            => BitMatrix8.From(src);

        [MethodImpl(Inline)]
        public static BitMatrix16 load(N16 n, ushort[] src)
            => BitMatrix16.From(src);

        [MethodImpl(Inline)]
        public static BitMatrix32 load(N32 n, uint[] src)
            => BitMatrix32.From(src);

        [MethodImpl(Inline)]
        public static BitMatrix64 load(N64 n, ulong[] src)
            => BitMatrix64.From(src);

        /// <summary>
        /// Loads a square bitmatrix of natural order from an span
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
        /// Loads a square bitmatrix of natural order from an span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The matrix order type</typeparam>
        /// <typeparam name="T">The matrix cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> load<N,T>(Span<T> src)
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
        public static BitMatrix<M,N,T> load<M,N,T>(M m, N n, Span<T> src)        
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
                => BitMatrix<M,N,T>.Load(src); 

    }
}