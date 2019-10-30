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
        /// Allocates a zero-filled square bitmatrix of natural order
        /// </summary>
        /// <typeparam name="N">The square dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> natural<N,T>()
            where N : ITypeNat, new()
            where T : unmanaged
                => BitMatrix<N,T>.Alloc();

        /// <summary>
        /// Projects, without allocation, a primal bitmatrix onto a generic bitmatrix of natural order
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]    
        public static BitMatrix<N8,byte> natural(BitMatrix8 A)
            => BitMatrix<N8,byte>.Load(A.Bytes);

        /// <summary>
        /// Projects, without allocation, a primal bitmatrix onto a generic bitmatrix of natural order
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]    
        public static BitMatrix<N16,byte> natural(BitMatrix16 A)
            => BitMatrix<N16,byte>.Load(A.Bytes);

        /// <summary>
        /// Projects, without allocation, a primal bitmatrix onto a generic bitmatrix of natural order
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]    
        public static BitMatrix<N32,byte> natural(BitMatrix32 A)
            => BitMatrix<N32,byte>.Load(A.Bytes);

        /// <summary>
        /// Projects, without allocation, a primal bitmatrix onto a generic bitmatrix of natural order
        /// </summary>
        /// <param name="A">The source matrix</param>
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
    }

}