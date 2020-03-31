//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;    
    using static As;

    partial class BitMatrix
    {        
        /// <summary>
        /// Projects, without allocation, a primal bitmatrix onto a generic bitmatrix of natural order
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]    
        public static BitMatrix<N8,byte> natural(in BitMatrix8 A)
            => new BitMatrix<N8,byte>(A.data);

        /// <summary>
        /// Projects, without allocation, a primal bitmatrix onto a generic bitmatrix of natural order
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]    
        public static BitMatrix<N16,byte> natural(in BitMatrix16 A)
            => new BitMatrix<N16,byte>(A.Bytes);

        /// <summary>
        /// Projects, without allocation, a primal bitmatrix onto a generic bitmatrix of natural order
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]    
        public static BitMatrix<N32,byte> natural(in BitMatrix32 A)
            => new BitMatrix<N32,byte>(A.Bytes);

        /// <summary>
        /// Projects, without allocation, a primal bitmatrix onto a generic bitmatrix of natural order
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]    
        public static BitMatrix<N64,byte> natural(in BitMatrix64 A)
            => new BitMatrix<N64,byte>(A.Bytes);

        /// <summary>
        /// Creates a square bitmatrix of natural order from a single cell
        /// </summary>
        /// <param name="data">The data cell</param>
        /// <param name="n">The order representative</param>
        /// <typeparam name="N">The order type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]    
        public static BitMatrix<N,T> natural<N,T>(T data, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitMatrix<N, T>(data);

        /// <summary>
        /// Creates a square bitmatrix of natural order from a span
        /// </summary>
        /// <param name="data">The data source</param>
        /// <param name="n">The order representative</param>
        /// <typeparam name="N">The column count type</typeparam>
        /// <typeparam name="T">The order type</typeparam>
        [MethodImpl(Inline)]    
        public static BitMatrix<N,T> natural<N,T>(Span<T> data, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitMatrix<N, T>(data);

        /// <summary>
        /// Creates a bitmatrix of natural dimensions from a single cell
        /// </summary>
        /// <param name="data">The data cell</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The column count representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The column count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]    
        public static BitMatrix<M,N,T> natural<M,N,T>(T data, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitMatrix<M, N, T>(data);

        /// <summary>
        /// Creates a bitmatrix of natural dimensions from a span
        /// </summary>
        /// <param name="data">The data source</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The column count representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The column count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]    
        public static BitMatrix<M,N,T> natural<M,N,T>(Span<T> data, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitMatrix<M, N, T>(data);

        /// <summary>
        /// Computes the minimum number of cells required to store a bitmatrix of natural dimensions where each row is data-type aligned
        /// </summary>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int totalcells<M,N,T>(M m = default, N n = default, T t =default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitCalcs.mincells<N,T>() * nati<M>();

        [MethodImpl(Inline)]
        public static TableIndex tableindex<M,N,T>(int row, int col, M m = default, N n = default, T t =default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var rowCellCount = uint16(BitCalcs.mincells<N,T>());
            var rowOffset = uint32(rowCellCount*row);
            return TableIndex.Define(
                CellIndex: uint16(rowOffset + BitSize.div(col,t)), 
                RowCellCount: rowCellCount,
                BitOffset: uint8(BitSize.mod(col,t)), 
                BitIndex: uint32(rowOffset + col), 
                RowIndex: row, 
                ColIndex: col);                    
        }

        /// <summary>
        /// Computes the bitwise AND between two square bitmatrices of common natural order and stores the
        /// result a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The first source operand</param>
        /// <param name="B">The second source operand</param>
        /// <param name="C">The target</param>
        /// <typeparam name="N">The matrix order</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly BitMatrix<N,T> and<N,T>(in BitMatrix<N,T> A, in BitMatrix<N,T> B, in BitMatrix<N,T> C)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            gspan.and(A.Data, B.Data, C.Data);
            return ref C;
        }

        /// <summary>
        /// Computes the bitwise AND between two square bitmatrices of common order
        /// </summary>
        /// <param name="A">The first source operand</param>
        /// <param name="B">The second source operand</param>
        /// <typeparam name="N">The matrix order</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> and<N,T>(in BitMatrix<N,T> A, in BitMatrix<N,T> B)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => and(A, B, alloc<N,T>());


        [MethodImpl(Inline)]
        public static ref BitMatrix<N,T> xor<N,T>(in BitMatrix<N,T> A, in BitMatrix<N,T> B, ref BitMatrix<N,T> C)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            gspan.xor(A.Data, B.Data, C.Data);
            return ref C;
        }

        /// <summary>
        /// Computes the bitwise AND between two square bitmatrices of common order
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> xor<N,T>(in BitMatrix<N,T> A, in BitMatrix<N,T> B)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var C = alloc<N,T>();
            return xor(in A, in B, ref C);
        }
    }
}