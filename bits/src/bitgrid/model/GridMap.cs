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
        public GridMap(in GridSpec spec)
        {
            this.Spec = spec;
            this.RowCount = spec.RowCount;
            this.ColCount = spec.ColCount;
            this.SegWidth = spec.SegWidth;
            this.Moniker = GridMoniker.Define((ushort)RowCount,(ushort)ColCount, (ushort)SegWidth);
            this.StorageBits = spec.StorageBits;
            this.StorageBytes = spec.StorageBytes;
            this.SegCount = spec.StorageSegs;            
            this.PointCount = spec.RowCount * spec.ColCount;
            this.Vec128Remainder = spec.StorageBytes % 16;
            this.Vec128Count = spec.StorageBytes / 16 + (this.Vec128Remainder != 0 ? 1 : 0);
            this.Vec256Remainder = spec.StorageBytes % 32;
            this.Vec256Count = spec.StorageBytes / 32 + (this.Vec256Remainder != 0 ? 1 : 0);
            this._Positions = defer( () => BitGrid.cells(Spec));
        }

        Lazy<CellMap[]> _Positions;
        
        CellMap[] Positions => _Positions.Value;        
        
        GridSpec Spec {get;}

        /// <summary>
        /// The number of rows in the layout
        /// </summary>
        public int RowCount {get;}            
        
        /// <summary>
        /// The number of columns in the layout
        /// </summary>
        public int ColCount {get;}

        /// <summary>
        /// The total number of items covered by the grid
        /// </summary>
        public int PointCount {get;}
        
        /// <summary>
        /// The number of bits in a segment
        /// </summary>
        public int SegWidth {get;}
            
        /// <summary>
        /// The number of segment-aligned bits required for storage
        /// </summary>
        public int StorageBits {get;}

        /// <summary>
        /// The number of segment-aligned bytes bits required for storage
        /// </summary>
        public int StorageBytes {get;}

        /// <summary>
        /// The number of segment-aligned storage segments
        /// </summary>
        public int SegCount {get;}

        /// <summary>
        /// The number of whole 128-bit vectors required for storage
        /// </summary>
        public int Vec128Count {get;set;}

        /// <summary>
        /// The number bytes that do not fit into a whole number of 128-bit vectors
        /// </summary>
        public int Vec128Remainder  {get;set;}
        
        /// <summary>
        /// The number of whole 256-bit vectors required for storage
        /// </summary>
        public int Vec256Count {get;set;}
            
        /// <summary>
        /// The number bytes that do not fit into a whole number of 256-bit vectors
        /// </summary>
        public int Vec256Remainder {get;set;}
            
        /// <summary>
        /// A semantic identifier that distinguishes that grid for which statistics ar given
        /// </summary>
        public GridMoniker Moniker{get;}

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
        public void GetRow(int row, CellMap[] cells)
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