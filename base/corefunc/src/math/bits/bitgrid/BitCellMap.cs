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
    /// Correlates a bit position with a grid row and column
    /// </summary>
    public readonly struct BitCellMap<T>
        where T : unmanaged
    {           
        public BitCellMap(ushort Segment, ushort Offset, int Position, int Row, int Col)
        {
            this.Segment = Segment;
            this.Offset = Offset;
            this.Row =Row;
            this.Col = Col;
            this.Position = Position;
        }

        /// <summary>
        /// The container-relative index of the storage segment containing the bit
        /// </summary>
        public readonly ushort Segment;
        
        /// <summary>
        /// The segment-relative bit offset
        /// </summary>
        public readonly ushort Offset;

        /// <summary>
        /// The 0-based position of the cell
        /// </summary>
        public readonly int Position;

        /// <summary>
        /// The absolute row index
        /// </summary>
        public readonly int Row;

        /// <summary>
        /// The absolute column index
        /// </summary>
        public readonly int Col;

        public string Format()
            => $"(Bit = {Position}, Segment = {Segment}, Row = {Row}, Col = {Col}, Offset = {Offset})";
    }
}