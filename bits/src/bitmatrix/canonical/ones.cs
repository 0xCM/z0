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
                => BitMatrix.fill<T>(BitVector.ones<T>());

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


    }

}