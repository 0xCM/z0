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
    using System.Runtime.InteropServices;

    using static zfunc;

    /// <summary>
    /// Correlates an cell index with a coordinate in a rectangular grid
    /// </summary>

    public readonly struct CellMap
    {                
        /// <summary>
        /// The zero-based row index
        /// </summary>
        public readonly ushort Row;

        /// <summary>
        /// The zero-based column index
        /// </summary>
        public readonly ushort Col;

        /// <summary>
        /// The container-relative segment in which the cell is located
        /// </summary>
        public readonly ushort Segment;

		/// <summary>
		/// The segment-relative offset
		/// </summary>
		public readonly ushort Offset;

		/// <summary>
		/// The absolute/linear zero-based cell position
		/// </summary>
        public readonly uint Position;


        [MethodImpl(Inline)]
        public CellMap(in CellIndex index, ushort row, ushort col)
        {
            this.Row = row;
            this.Col = col;
            this.Segment = index.Segment;
            this.Offset = index.Offset;
            this.Position = index.Position;
        }

        [MethodImpl(Inline)]
        public CellMap(uint pos, ushort seg, ushort offset, ushort row, ushort col)
        {
            this.Row = row;
            this.Col = col;
            this.Segment = seg;
            this.Offset = offset;
            this.Position = pos;
        }

        public string Format()
            => $"({Row},{Col},{Position})";

        public override string ToString()
            => Format();
    }
}