//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Characterizes the memory layout of a BitMatrix
    /// </summary>
    public readonly struct BitGridSpec
    {
        /// <summary>
        /// Defines a bit layout grid as determined by specified type parameters
        /// </summary>
        /// <param name="m">The number of grid rows</param>
        /// <param name="n">The number of grid columns</param>
        /// <param name="rep"></param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The column count type</typeparam>
        /// <typeparam name="T">The storage type</typeparam>
        [MethodImpl(Inline)]
        public static BitGridSpec define<M,N,T>(M m = default, N n = default, T rep = default)
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
            where T : unmanaged
                => new BitGridSpec(bitsize<T>(), natval(m), natval(n));

        [MethodImpl(Inline)]
        public BitGridSpec(int CellSize, int RowCount, int ColCount)
        {
            this.CellWidth = CellSize;
            this.RowCount = RowCount;
            this.ColCount = ColCount;
            this.RowCells = CalcRowCells(CellSize, ColCount);
        }
        
        /// <summary>
        /// The bit size of the underlying storage type
        /// </summary>
        public readonly int CellWidth;
        
        /// <summary>
        /// The number of grid rows
        /// </summary>
        public readonly int RowCount;
        
        /// <summary>
        /// The number of grid columns
        /// </summary>
        public readonly int ColCount;

        /// <summary>
        /// The minimum number of a cells in a primal array/span required to store a row of data 
        /// </summary>
        public readonly int RowCells;

        /// <summary>
        /// The number of bits stored in the grid
        /// </summary>
        public readonly int TotalBits
        {
            [MethodImpl(Inline)]
            get => RowCount * ColCount;
        }

        /// <summary>
        /// Computes the minimum number of cells required to store a grid of data
        /// </summary>
        /// <param name="spec">The characterizing specification</param>
        public int TotalCells
        {
            [MethodImpl(Inline)]
            get => RowCount * RowCells;
        }

        /// <summary>
        /// Computes the length of a primal span/array that is required to store a row of data
        /// </summary>
        [MethodImpl(Inline)]
        static int CalcRowCells(int cellbits, int colcount)
        {
            if(cellbits >= colcount)
                return 1;
            else
            {
                var q = Math.DivRem(colcount, cellbits, out int r);                
                return r == 0 ? q : q + 1;
            }
        }

        public string Format()
            => (CellWidth, RowCount, ColCount).Format();
    }
}