//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitMatrix
    {
        /// <summary>
        /// Projects each bit value in the source matrix to a cell in a caller-supplied conventional matrix
        /// </summary>
        /// <param name="A">The source bitmatrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref Matrix<N8, bit> unpack(in BitMatrix8 A, ref Matrix<N8,bit> Z)
        {
            gbits.unpack(A.data, Z.Data);            
            return ref Z;
        }

        /// <summary>
        /// Projects each bit value in the source matrix to a cell in a caller-supplied conventional matrix
        /// </summary>
        /// <param name="A">The source bitmatrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref Matrix<N8, bit> unpack(in BitMatrix<byte> A, ref Matrix<N8,bit> Z)
        {
            gbits.unpack(A.Data, Z.Data);            
            return ref Z;
        }

        /// <summary>
        /// Allocates a target matrix of order equivalent to that of the source and projects
        /// each bit value into the corresponding cell in the target
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <typeparam name="T">The element type of the target matrix</typeparam>
        public static Matrix<N8, bit> unpack(in BitMatrix8 A)
        {
            var Z = Matrix.alloc<N8,bit>();
            unpack(A, ref Z);
            return Z;
        }

        /// <summary>
        /// Allocates a target matrix of order equivalent to that of the source and projects
        /// each bit value into the corresponding cell in the target
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <typeparam name="T">The element type of the target matrix</typeparam>
        public static Matrix<N8, bit> unpack(in BitMatrix<byte> A)
        {
            var Z = Matrix.alloc<N8,bit>();
            unpack(A, ref Z);
            return  Z;
        }

        /// <summary>
        /// Projects each bit value in the source matrix to a cell in a caller-supplied conventional matrix
        /// </summary>
        /// <param name="A">The source bitmatrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref Matrix<N16, bit> unpack(in BitMatrix16 A, ref Matrix<N16,bit> Z)
        {
            gbits.unpack(A.Data, Z.Data);            
            return ref Z;
        }

        /// <summary>
        /// Projects each bit value in the source matrix to a cell in a caller-supplied conventional matrix
        /// </summary>
        /// <param name="A">The source bitmatrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref Matrix<N16, bit> unpack(in BitMatrix<ushort> A, ref Matrix<N16,bit> Z)
        {
            gbits.unpack(A.Data, Z.Data);            
            return ref Z;
        }

        /// <summary>
        /// Allocates a target matrix of order equivalent to that of the source and projects
        /// each bit value into the corresponding cell in the target
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <typeparam name="T">The element type of the target matrix</typeparam>
        public static Matrix<N16,bit> unpack(in BitMatrix16 A)
        {
            var Z = Matrix.alloc<N16,bit>();
            unpack(A, ref Z);
            return  Z;
        }

        /// <summary>
        /// Allocates a target matrix of order equivalent to that of the source and projects
        /// each bit value into the corresponding cell in the target
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <typeparam name="T">The element type of the target matrix</typeparam>
        public static Matrix<N16,bit> unpack(in BitMatrix<ushort> A)
        {
            var Z = Matrix.alloc<N16,bit>();
            unpack(A, ref Z);
            return  Z;
        }

        /// <summary>
        /// Projects each bit value in the source matrix to a cell in a caller-supplied conventional matrix
        /// </summary>
        /// <param name="A">The source bitmatrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref Matrix<N32, bit> unpack(in BitMatrix32 A, ref Matrix<N32,bit> Z)
        {
            gbits.unpack(A.Data, Z.Data);            
            return ref Z;
        }

        /// <summary>
        /// Projects each bit value in the source matrix to a cell in a caller-supplied conventional matrix
        /// </summary>
        /// <param name="A">The source bitmatrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref Matrix<N32, bit> unpack(in BitMatrix<uint> A, ref Matrix<N32,bit> Z)
        {
            gbits.unpack(A.Data, Z.Data);            
            return ref Z;
        }

        /// <summary>
        /// Allocates a target matrix of order equivalent to that of the source and projects
        /// each bit value into the corresponding cell in the target
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <typeparam name="T">The element type of the target matrix</typeparam>
        public static Matrix<N32,bit> unpack(in BitMatrix32 A)
        {
            var Z = Matrix.alloc<N32,bit>();
            unpack(A,ref Z);
            return  Z;
        }

        /// <summary>
        /// Allocates a target matrix of order equivalent to that of the source and projects
        /// each bit value into the corresponding cell in the target
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <typeparam name="T">The element type of the target matrix</typeparam>
        public static Matrix<N32,bit> unpack(in BitMatrix<uint> A)
        {
            var Z = Matrix.alloc<N32,bit>();
            unpack(A,ref Z);
            return  Z;
        }

        /// <summary>
        /// Projects each bit value in the source matrix to a cell in a caller-supplied conventional matrix
        /// </summary>
        /// <param name="A">The source bitmatrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref Matrix<N64, bit> unpack(in BitMatrix64 A, ref Matrix<N64,bit> Z)
        {
            gbits.unpack(A.Data, Z.Data);            
            return ref Z;
        }

        /// <summary>
        /// Projects each bit value in the source matrix to a cell in a caller-supplied conventional matrix
        /// </summary>
        /// <param name="A">The source bitmatrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref Matrix<N64, bit> unpack(in BitMatrix<ulong> A, ref Matrix<N64,bit> Z)
        {
            gbits.unpack(A.Data, Z.Data);            
            return ref Z;
        }

        /// <summary>
        /// Allocates a target matrix of order equivalent to that of the source and projects
        /// each bit value into the corresponding cell in the target
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <typeparam name="T">The element type of the target matrix</typeparam>
        public static Matrix<N64, bit> unpack(in BitMatrix64 A)
        {
            var Z = Matrix.alloc<N64,bit>();
            unpack(A, ref Z);
            return Z;
        }

        /// <summary>
        /// Allocates a target matrix of order equivalent to that of the source and projects
        /// each bit value into the corresponding cell in the target
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <typeparam name="T">The element type of the target matrix</typeparam>
        public static Matrix<N64,bit> unpack(in BitMatrix<ulong> A)
        {
            var Z = Matrix.alloc<N64,bit>();
            unpack(A, ref Z);
            return  Z;
        }

        /// <summary>
        ///  Projects the bits in the source matrix onto cells of a conventional matrix
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target matrix</param>
        /// <typeparam name="T">The element type of the target matrix</typeparam>
        public static ref Matrix<N,T> unpack<N,S,T>(in BitMatrix<S> src, ref Matrix<N,T> Z)
            where N : unmanaged, ITypeNat
            where S : unmanaged
            where T : unmanaged
        {            
            gbits.unpack(src.Data, Z.Data.AsSpan());            
            return  ref Z;
        }

        /// <summary>
        /// Projects the bits of a fixed primal bitmatrix into a generic target matrix of the same order
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="T">The element type of the target matrix</typeparam>
        public static ref Matrix<N16, T> unpack<T>(in BitMatrix16 src, ref Matrix<N16,T> dst)
            where T : unmanaged
        {
            gbits.unpack(src.Data, dst.Data.AsSpan());            
            return ref dst;
        }

        /// <summary>
        /// Projects the bits of a fixed primal bitmatrix into a generic target matrix of the same order
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="T">The element type of the target matrix</typeparam>
        public static ref Matrix<N8, T> unpack<T>(in BitMatrix8 src, ref Matrix<N8,T> dst)
            where T : unmanaged
        {
            gbits.unpack(src.data, dst.Data.AsSpan());            
            return ref dst;
        }

        /// <summary>
        /// Projects the bits of a fixed primal bitmatrix into a generic target matrix of the same order
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="T">The element type of the target matrix</typeparam>
        public static ref Matrix<N32, T> unpack<T>(in BitMatrix32 src, ref Matrix<N32,T> dst)
            where T : unmanaged
        {
            gbits.unpack(src.Data, dst.Data.AsSpan());            
            return ref dst;
        }

        /// <summary>
        /// Projects the bits of a fixed primal bitmatrix into a generic target matrix of the same order
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="T">The element type of the target matrix</typeparam>
        public static ref Matrix<N64, T> unpack<T>(in BitMatrix64 src, ref Matrix<N64,T> dst)
            where T : unmanaged
        {
            gbits.unpack(src.Data, dst.Data.AsSpan());            
            return ref dst;
        }

        /// <summary>
        /// Projects the bits of a generic sqare bitmatix of natural order into a generic target matrix of the same order
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="N">The orer type</typeparam>
        /// <typeparam name="S">The source matrix element type</typeparam>
        /// <typeparam name="T">The target matrix element type</typeparam>
        public static ref Matrix<N, T> unpack<N,S,T>(in BitMatrix<N,S> src, ref Matrix<N,T> dst)
            where S : unmanaged
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            gbits.unpack(src.Data, dst.Data.AsSpan());            
            return ref dst;
        }

        /// <summary>
        /// Projects the bits of a generic bitmatix of natural dimensions into a generic matrix of the same dimensions
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="M">The row dimension type</typeparam>
        /// <typeparam name="N">The col dimension type</typeparam>
        /// <typeparam name="S">The source matrix element type</typeparam>
        /// <typeparam name="T">The target matrix element type</typeparam>
        public static ref Matrix<M, N, T> unpack<M,N,S,T>(in BitMatrix<M,N,S> src, ref Matrix<M,N,T> dst)
            where S : unmanaged
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            gbits.unpack(src.Data, dst.Data.AsSpan());            
            return ref dst;
        }

        /// <summary>
        /// Projects the bits of a square generic bitmatix of natural order into a generic block matrix of the same order
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="M">The row dimension type</typeparam>
        /// <typeparam name="N">The col dimension type</typeparam>
        /// <typeparam name="S">The source matrix element type</typeparam>
        /// <typeparam name="T">The target matrix element type</typeparam>
        public static ref Matrix256<N, T> unpack<N,S,T>(in BitMatrix<N,S> src, ref Matrix256<N,T> dst)
            where S : unmanaged
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            gbits.unpack(src.Data, dst.Unblocked);            
            return ref dst;
        }

        /// <summary>
        /// Projects the bits of a generic bitmatix of natural dimensions into a generic block matrix of the same dimensions
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="M">The row dimension type</typeparam>
        /// <typeparam name="N">The col dimension type</typeparam>
        /// <typeparam name="S">The source matrix element type</typeparam>
        /// <typeparam name="T">The target matrix element type</typeparam>
        public static ref Matrix256<M,N,T> unpack<M,N,S,T>(in BitMatrix<M,N,S> src, ref Matrix256<M,N,T> dst)
            where S : unmanaged
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            gbits.unpack(src.Data, dst.Unblocked);            
            return ref dst;
        }
   }
}