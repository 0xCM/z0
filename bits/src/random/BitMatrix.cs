//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using BM = Z0.BitMatrix;

    public static partial class BitRng
    {

        /// <summary>
        /// Produces a generic bitmatrix predicated on a primal type
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="T">The defining primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<T> BitMatrix<T>(this IPolyrand random)
            where T : unmanaged
        {                        
            var bytes = math.square(Z0.BitMatrix<T>.N) >> 3;
            var data = random.Span<byte>((int)bytes);
            return Z0.BitMatrix.load(data.As<byte,T>());
        }

        [MethodImpl(Inline)]
        public static ref BitMatrix<T> BitMatrix<T>(this IPolyrand random, ref BitMatrix<T> dst)
            where T : unmanaged
        {                        
            random.StreamTo((int)Z0.BitMatrix<T>.N, ref dst.Head);
            return ref dst;            
        }

        /// <summary>
        /// Produces a 4x4 bitmatrix from a random source
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitMatrix4 BitMatrix4(this IPolyrand random)
            => Z0.BitMatrix4.From(random.Next<ushort>());

        /// <summary>
        /// Produces a 4x4 bitmatrix from a random source
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitMatrix4 BitMatrix(this IPolyrand random, N4 n4)
            => Z0.BitMatrix4.From(random.Next<ushort>());

        /// <summary>
        /// Produces a 8x8 bitmatrix from a random source
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 BitMatrix8(this IPolyrand random)
            => Z0.BitMatrix8.From(random.Next<ulong>());

        /// <summary>
        /// Produces a 8x8 bitmatrix from a random source
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 BitMatrix(this IPolyrand random, N8 n)
            => Z0.BitMatrix8.From(random.Next<ulong>());

        /// <summary>
        /// Produces a 16x16 bitmatrix from a random source
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitMatrix16 BitMatrix16(this IPolyrand random)
            => Z0.BitMatrix16.From(random.Array<ushort>(16));

        /// <summary>
        /// Produces a 16x16 bitmatrix from a random source
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitMatrix16 BitMatrix(this IPolyrand random, N16 n)
            => Z0.BitMatrix16.From(random.Array<ushort>(16));

        /// <summary>
        /// Produces a 32x32 bitmatrix from a random source
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitMatrix32 BitMatrix32(this IPolyrand random)
            => Z0.BitMatrix32.From(random.Array<uint>(32));

        /// <summary>
        /// Produces a 32x32 bitmatrix from a random source
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitMatrix32 BitMatrix(this IPolyrand random, N32 n)
            => Z0.BitMatrix32.From(random.Array<uint>(32));

        /// <summary>
        /// Produces a 64x64 bitmatrix from a random source
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitMatrix64 BitMatrix64(this IPolyrand random)
            => Z0.BitMatrix64.From(random.Array<ulong>(64));        

        /// <summary>
        /// Produces a 64x64 bitmatrix from a random source
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitMatrix64 BitMatrix(this IPolyrand random, N64 n)
            => Z0.BitMatrix64.From(random.Array<ulong>(64));        
    
        /// <summary>
        /// Produces a generic bitmatrix of natural dimensions
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The matrix order</param>
        /// <param name="rep">A scalar representative</param>
        /// <typeparam name="N">The order type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> BitMatrix<M,N,T>(this IPolyrand random, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BM.load(m, n, random.Span<T>(BitGridSpec.Define(m,n,default(T)).TotalCellCount));

        /// <summary>
        /// Produces an generic bitmatrix of natural order
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The matrix order</param>
        /// <typeparam name="N">The order type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> BitMatrix<N,T>(this IPolyrand random, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BM.load(n,random.Span<T>(BitGridSpec.Define(n,n,default(T)).TotalCellCount));                
 
        /// <summary>
        /// Allocates and populates a bitgrid
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The matrix order</param>
        /// <param name="rep">A scalar representative</param>
        /// <typeparam name="N">The order type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid<M,N,T> BitGrid<M,N,T>(this IPolyrand random, M m = default, N n = default, T zero = default)
            where M : unmanaged,ITypeNat
            where N : unmanaged,ITypeNat
            where T : unmanaged
        {
            var map = GridLayout.map(m,n,zero);
            var data = random.Span<T>(map.Segments);
            return Z0.BitGrid.load(data, m, n);
        }

        /// <summary>
        /// Allocates and populates a bitgrid
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The matrix order</param>
        /// <param name="rep">A scalar representative</param>
        /// <typeparam name="N">The order type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid<M,N,T> Fill<M,N,T>(this IPolyrand random, BitGrid<M,N,T> dst)
            where M : unmanaged,ITypeNat
            where N : unmanaged,ITypeNat
            where T : unmanaged
        {
            random.StreamTo(dst.BitMap.Segments, ref dst.Head);
            return dst;
        }

    }
}