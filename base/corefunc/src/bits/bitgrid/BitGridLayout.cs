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

    public class BitGridLayout
    {        
        [MethodImpl(Inline)]
        public static BitGridLayout Define<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitGridSpec(bitsize<T>(), (int)n.NatValue,(int)n.NatValue).CalcLayout<T>();

        public BitGridLayout(BitGridSpec spec, IEnumerable<BitCellMap> Cells)
        {
            this.GridSpec = spec;
            this.RowCount = spec.RowCount;
            this.ColCount = spec.ColCount;
            this.BitCount = spec.TotalBits;
            this.RowCellCount = spec.RowCells;
            this.TotalCellCount = spec.TotalCells;
            this.RowLayout = CreateLayoutIndex(Cells);
            this.CellSize = spec.CellWidth;
            require(spec.RowCount == RowLayout.Count);
            require(spec.ColCount == RowLayout.First().Value.Length);                         
        }

        readonly IReadOnlyDictionary<int, BitCellMap[]> RowLayout;
       
        /// <summary>
        /// The specification from which the layout was calculated
        /// </summary>
        public readonly BitGridSpec GridSpec;

        /// <summary>
        /// The number of rows in the layout
        /// </summary>
        public readonly int RowCount;
        
        /// <summary>
        /// The number of columns in the layout
        /// </summary>
        public readonly int ColCount;

        /// <summary>
        /// The number of bits stored in the grid, given by <see cref='RowCount'/> * <see cref='ColCount'/>
        /// </summary>
        public readonly BitSize BitCount;

        /// <summary>
        /// The number of bits in a cell
        /// </summary>
        public readonly BitSize CellSize;

        /// <summary>
        /// The minimum number of cells sufficient to store a row of grid data
        /// </summary>
        public readonly int RowCellCount;

        /// <summary>
        /// The length of a span required to store all cells
        /// </summary>
        public readonly int TotalCellCount;

        
        [MethodImpl(Inline)]
        public Span<BitCellMap> Row(int row)
            => RowLayout[row];            

        [MethodImpl(Inline)]
        public BitCellMap Cell(int row, int col)
            => RowLayout[row][col];            

        public Span<BitCellMap> this[int row]
        {
            [MethodImpl(Inline)]
            get => Row(row);
        }

        public BitCellMap this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => Cell(row, col);
        }

        public string Format()
        {
            var format = text();
            format.Append($"RowCount = {RowCount}, ");
            format.Append($"ColCount = {ColCount}, ");
            format.Append($"CellCount = {BitCount}, ");
            format.Append($"RowSegLength = {RowCellCount}");
            format.AppendLine();
            for(var row = 0; row<RowCount; row++)
            {
                var rowData = Row(row);
                for(var i=0; i<rowData.Length; i++)
                    format.AppendLine(rowData[i].Format());
            }
            return format.ToString();
        }

        public override string ToString()
            => Format();    
 
        static IReadOnlyDictionary<int, BitCellMap[]> CreateLayoutIndex(IEnumerable<BitCellMap> Cells)
                => Cells.GroupBy(x => x.Row).Select(x => (x.Key, x.OrderBy(u => u.Position).ToArray())).ToDictionary();

    }
}