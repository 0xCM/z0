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

    public class GridMap
    {        
        public GridMap(GridSpec spec, IEnumerable<CellMap> cells)
        {
            this.GridSpec = spec;
            this.SegWidth = spec.SegWidth;
            this.Storage = spec.Storage;
            this.Segments = (int)GridSpec.Segments;            
            this.RowCount = (int)GridSpec.RowCount;
            this.ColCount = (int)GridSpec.ColCount;
            this.Volume = (int)GridSpec.Volume;
            this.Positions = cells.OrderBy(c => c.Position).ToArray();
        }

        readonly CellMap[] Positions;        
        
        /// <summary>
        /// The specification from which the layout was calculated
        /// </summary>
        public GridSpec GridSpec {get;}

        /// <summary>
        /// The number of rows in the layout
        /// </summary>
        public int RowCount {get;}            
        
        /// <summary>
        /// The number of columns in the layout
        /// </summary>
        public int ColCount {get;}

        /// <summary>
        /// The total number of items in the grid
        /// </summary>
        public int Volume {get;}
        
        /// <summary>
        /// The number of bits in a segment
        /// </summary>
        public int SegWidth {get;}
            
        /// <summary>
        /// The number of segment-aligned bits allocated for storage
        /// </summary>
        public int Storage {get;}

        /// <summary>
        /// The number of segment-aligned storage segments
        /// </summary>
        public int Segments {get;}

        /// <summary>
        /// Finds a cell based on linear position
        /// </summary>
        /// <param name="position">The 0-based cell position</param>
        [MethodImpl(Inline)]
        public ref readonly CellMap Cell(int position)
            => ref Positions[position];

        /// <summary>
        /// Finds a cell based on row/column coordinates
        /// </summary>
        /// <param name="position">The 0-based cell position</param>
        [MethodImpl(Inline)]
        public ref readonly CellMap Cell(int row, int col)
            => ref Cell(Pos(row, col));

        [MethodImpl(Inline)]
        public void Row(int row, CellMap[] cells)
        {
            var offset = Pos(row,0);
            Array.Copy(Positions, offset, cells, 0, ColCount);            
        }
            
        /// <summary>
        /// Finds a cell based on linear position
        /// </summary>
        /// <param name="position">The 0-based cell position</param>
        public ref readonly CellMap this[int position]
        {
            [MethodImpl(Inline)]
            get => ref Cell(position);
        }

        /// <summary>
        /// Finds a cell based on row/column coordinates
        /// </summary>
        /// <param name="position">The 0-based cell position</param>
        public ref readonly CellMap this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => ref Cell(Pos(row, col));
        }

        public override string ToString()
            => this.Format();    

        [MethodImpl(Inline)]
        public int Pos(int row, int col)
            => row*ColCount + col;

    }
}