//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {
        /// <summary>
        /// Allocates a zero-filled square bitmatrix of natural order
        /// </summary>
        /// <typeparam name="N">The square dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> natural<N,T>()
            where N : ITypeNat, new()
            where T : unmanaged
                => BitMatrix<N,T>.Alloc();

        [MethodImpl(Inline)]    
        public static BitMatrix<N8,byte> natural(BitMatrix8 A)
            => BitMatrix<N8,byte>.Load(A.Bytes);

        [MethodImpl(Inline)]    
        public static BitMatrix<N16,byte> natural(BitMatrix16 A)
            => BitMatrix<N16,byte>.Load(A.Bytes);

        [MethodImpl(Inline)]    
        public static BitMatrix<N32,byte> natural(BitMatrix32 A)
            => BitMatrix<N32,byte>.Load(A.Bytes);

        [MethodImpl(Inline)]    
        public static BitMatrix<N64,byte> natural(BitMatrix64 A)
            => BitMatrix<N64,byte>.Load(A.Bytes);

        
        /// <summary>
        /// Allocates a zero-filled bitmatrix of natural dimensions
        /// </summary>
        /// <typeparam name="M">The row dimension</typeparam>
        /// <typeparam name="N">The column dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> natural<M,N,T>(M m = default, N n = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
                => BitMatrix<M,N,T>.Alloc();

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
        /// Loads an MxN bitmatrix from a memory segment
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The matrix order</param>
        /// <typeparam name="N">The matrix order type</typeparam>
        /// <typeparam name="T">The matrix cell type</typeparam>
        [MethodImpl(NotInline)]
        public static BitMatrix<M,N,T> load<M,N,T>(T[] src, M m = default, N n = default)        
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
                => BitMatrix<M,N,T>.Load(src); 

        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> load<M,N,T>(M m = default, N n = default, params T[] src)        
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
                => BitMatrix<M,N,T>.Load(src); 

    }

}