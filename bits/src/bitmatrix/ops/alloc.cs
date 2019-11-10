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
            return new BitMatrix<T>(content);
        }

        /// <summary>
        /// Allocates a generic bitmatrix filled with a specified row
        /// </summary>
        /// <typeparam name="T">The primal type over which the bitmatrix is constructed</typeparam>
        [MethodImpl(NotInline)]
        public static BitMatrix<T> alloc<T>(BitVector<T> fill)
            where T : unmanaged
        {
            Span<T> content = new T[BitMatrix<T>.N];
            content.Fill(fill);
            return new BitMatrix<T>(content);
        }

        /// <summary>
        /// Allocates a square bitmatrix of natural order, optionally filled with a nonzero bitpattern
        /// </summary>
        /// <typeparam name="N">The square dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(NotInline)]
        public static BitMatrix<N,T> alloc<N,T>(N n = default, T fill = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {

            var dst = BitMatrix<N,T>.Alloc();
            if(gmath.nonzero(fill))
                dst.Data.Fill(fill);
            return dst;
        }

        /// <summary>
        /// Allocates a bitmatrix of natural dimensions, optionally filled with a nonzero bitpattern
        /// </summary>
        /// <typeparam name="M">The row dimension</typeparam>
        /// <typeparam name="N">The column dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(NotInline)]
        public static BitMatrix<M,N,T> alloc<M,N,T>(M m = default, N n = default, T fill = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {

            var dst = BitMatrix<M,N,T>.Alloc();
            if(gmath.nonzero(fill))
                dst.Data.Fill(fill);
            return dst;
        }

        /// <summary>
        /// Allocates a primal bitmatrix 
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="fill">The value with which the allocated matrix is filled</param>
        [MethodImpl(NotInline)]
        public static BitMatrix4 alloc(N4 n, bit fill = default)
            => BitMatrix4.Alloc(fill);

        /// <summary>
        /// Allocates a primal bitmatrix with rows filled by a specified vector
        /// </summary>
        /// <param name="fill">The row with which the allocated matrix is filled</param>
        [MethodImpl(NotInline)]
        public static BitMatrix4 alloc(BitVector4 fill)
            => BitMatrix4.Alloc(fill);

        /// <summary>
        /// Allocates a primal bitmatrix 
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="fill">The value with which the allocated matrix is filled</param>
        [MethodImpl(NotInline)]
        public static BitMatrix8 alloc(N8 n, bit fill = default)
            => BitMatrix8.Alloc(fill);

        /// <summary>
        /// Allocates a primal bitmatrix with rows filled by a specified vector
        /// </summary>
        /// <param name="fill">The row with which the allocated matrix is filled</param>
        [MethodImpl(NotInline)]
        public static BitMatrix8 alloc(BitVector8 fill)
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
        /// Allocates a primal bitmatrix with rows filled by a specified vector
        /// </summary>
        /// <param name="fill">The row with which the allocated matrix is filled</param>
        [MethodImpl(NotInline)]
        public static BitMatrix16 alloc(BitVector16 fill)
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
        /// Allocates a primal bitmatrix with rows filled by a specified vector
        /// </summary>
        /// <param name="fill">The row with which the allocated matrix is filled</param>
        [MethodImpl(NotInline)]
        public static BitMatrix32 alloc(BitVector32 fill)
            => BitMatrix32.Alloc(fill);

        /// <summary>
        /// Allocates a primal bitmatrix 
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="fill">The value with which the allocated matrix is filled</param>
        [MethodImpl(NotInline)]
        public static BitMatrix64 alloc(N64 n, bit fill = default)
            => BitMatrix64.Alloc(fill);
 
         /// <summary>
        /// Allocates a primal bitmatrix with rows filled by a specified vector
        /// </summary>
        /// <param name="fill">The row with which the allocated matrix is filled</param>
        [MethodImpl(NotInline)]
        public static BitMatrix64 alloc(BitVector64 fill)
            => BitMatrix64.Alloc(fill);
    }
}