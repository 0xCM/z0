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
        /// Allocates a zero-filled generic bitmatrix
        /// </summary>
        /// <typeparam name="T">The primal type over which the bitmatrix is constructed</typeparam>
        [MethodImpl(NotInline)]
        public static BitMatrix<T> alloc<T>()
            where T : unmanaged
        {
            Span<T> content = new T[BitMatrix<T>.N];
            // if(gmath.nonzero(fill))
            //     content.Fill(fill);            
            return new BitMatrix<T>(content);
        }

        /// <summary>
        /// Allocates a primal bitmatrix 
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="fill">The value with which the allocated matrix is filled</param>
        [MethodImpl(NotInline)]
        public static BitMatrix8 alloc(N8 n, bit fill = default)
            => BitMatrix8.Alloc(fill);

        /// <summary>
        /// Allocates a primal bitmatrix 
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="fill">The value with which the allocated matrix is filled</param>
        [MethodImpl(NotInline)]
        public static BitMatrix16 alloc(N16 n, bit fill = default)
            => BitMatrix16.Alloc(fill);

        /// <summary>
        /// Allocates a primal bitmatrix 
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="fill">The value with which the allocated matrix is filled</param>
        [MethodImpl(NotInline)]
        public static BitMatrix32 alloc(N32 n, bit fill = default)
            => BitMatrix32.Alloc(fill);

        /// <summary>
        /// Allocates a primal bitmatrix 
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="fill">The value with which the allocated matrix is filled</param>
        [MethodImpl(NotInline)]
        public static BitMatrix64 alloc(N64 n, bit fill = default)
            => BitMatrix64.Alloc(fill);


    }
}