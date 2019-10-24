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
        /// Loads an n-square bitmatrix from a memory segment
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