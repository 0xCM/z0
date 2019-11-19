//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class BitMatrix
    {        
        /// <summary>
        /// Creates a new generic bitmatrix where each row is initialized to a common source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>
        [MethodImpl(NotInline)]
        public static BitMatrix<T> broadcast<T>(BitVector<T> src)
            where T : unmanaged
                => new BitMatrix<T>(src);

        /// <summary>
        /// Overwrites each row of a generic bitmatrix with a specified source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="A">The target matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>
        [MethodImpl(Inline)]
        public static ref BitMatrix<T> broadcast<T>(BitVector<T> x, ref BitMatrix<T> A)
            where T : unmanaged
        {
            A.Data.Fill(x);
            return ref A;
        }

        /// <summary>
        /// Creates a new generic bitmatrix where each row is initialized to a common source vector
        /// </summary>
        /// <param name="row">The source vector used to fill each row</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>
        [MethodImpl(NotInline)]
        public static BitMatrix<N,T> broadcast<N,T>(in BitVector<N,T> row)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var matrix = alloc<N,T>();
            var count = BitVector<N,T>.SegCount;
            var n= natval<N>();
            ref readonly var src = ref row.Head;
            ref var dst = ref matrix.Head;
            for(var i=0; i< n; i++)
                memcpy(in src, ref seek(ref dst, i*count), (uint)count);
            return matrix;
        }

        /// <summary>
        /// Creates a new generic bitmatrix where each row is initialized to a common source vector
        /// </summary>
        /// <param name="row">The source vector used to fill each row</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>
        [MethodImpl(NotInline)]
        public static BitMatrix<M,N,T> broadcast<M,N,T>(in BitVector<N,T> row, M m = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
        {
            var matrix = alloc<M,N,T>();
            var count = BitVector<N,T>.SegCount;
            var n= natval<N>();
            ref readonly var src = ref row.Head;
            ref var dst = ref matrix.Head;
            for(var i=0; i< n; i++)
                memcpy(in src, ref seek(ref dst, i*count), (uint)count);
            return matrix;
        }


        /// <summary>
        /// Creates a new primal bitmatrix where each row is initialized to a common source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 broadcast(BitVector8 x)
        {
            var A = alloc(n8);
            A.Bytes.Fill(x);
            return A;
        }

        /// <summary>
        /// Overwrites each row of a primal bitmatrix with a specified source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="A">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref BitMatrix8 broadcast(BitVector8 x, ref BitMatrix8 A)
        {
            A.Bytes.Fill(x);
            return ref A;
        }

        /// <summary>
        /// Creates a new primal bitmatrix where each row is initialized to a common source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitMatrix16 broadcast(BitVector16 x)
        {
            var A = alloc(n16);
            A.Data.Fill(x);
            return A;
        }

        /// <summary>
        /// Overwrites each row of a primal bitmatrix with a specified source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="A">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref BitMatrix16 broadcast(BitVector16 x, ref BitMatrix16 A)
        {
            A.Data.Fill(x);
            return ref A;
        }

        /// <summary>
        /// Creates a new primal bitmatrix where each row is initialized to a common source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitMatrix32 broadcast(BitVector32 x)
        {
            var A = alloc(n32);
            A.Data.Fill(x);
            return A;
        }

        /// <summary>
        /// Overwrites each row of a primal bitmatrix with a specified source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="A">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref BitMatrix32 broadcast(BitVector32 x, ref BitMatrix32 A)
        {
            A.Data.Fill(x);
            return ref A;
        }

        /// <summary>
        /// Creates a new primal bitmatrix where each row is initialized to a common source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitMatrix64 broadcast(BitVector64 x)
        {
            var A = alloc(n64);
            A.Bytes.AsUInt64().Fill(x);
            return A;
        }

        /// <summary>
        /// Overwrites each row of a primal bitmatrix with a specified source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="A">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref BitMatrix64 broadcast(BitVector64 x, ref BitMatrix64 A)
        {
            A.Data.Fill(x);
            return ref A;
        }
    }
}