//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Characterizes the memory layout of a BitMatrix
    /// </summary>
    public readonly struct BitGridSpec<T>
        where T : unmanaged
    {
        public static implicit operator BitGridSpec<T>((int PrimalSize, int RowCount, int ColCount) x)
            => new BitGridSpec<T>(x.PrimalSize, x.RowCount, x.ColCount);
            
        public BitGridSpec(int CellSize, int RowCount, int ColCount)
        {
            this.CellSize = CellSize;
            this.RowCount = RowCount;
            this.ColCount = ColCount;
            this.RowCellCount = CalcRowCellCount(CellSize, ColCount);
        }
        
        /// <summary>
        /// The bit size of the underlying storage type
        /// </summary>
        public readonly int CellSize;
        
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
        public readonly int RowCellCount;

        /// <summary>
        /// The number of bits stored in the grid
        /// </summary>
        public readonly int BitCount
        {
            [MethodImpl(Inline)]
            get => RowCount * ColCount;
        }

        /// <summary>
        /// Computes the minimum number of cells required to store a grid of data
        /// </summary>
        /// <param name="spec">The characterizing specification</param>
        public int TotalCellCount
        {
            [MethodImpl(Inline)]
            get => RowCount * RowCellCount;
        }

        /// <summary>
        /// Computes the length of a primal span/array that is required to store a row of data
        /// </summary>
        [MethodImpl(Inline)]
        static int CalcRowCellCount(int cellbits, int colcount)
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
            => (CellSize, RowCount, ColCount).Format();
    }
}