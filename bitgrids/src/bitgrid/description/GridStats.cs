//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed; 
    using static Memories;
    
    public class GridStats
    {        
        [MethodImpl(Inline)]
        public static GridStats Define(GridMap src)
            => new GridStats
            {
                Name = $"{src.RowCount}x{src.ColCount}",
                RowCount = src.RowCount,
                ColCount = src.ColCount,
                SegWidth = src.SegWidth,
                SorageSegs = src.SegCount,
                StorageBits = src.StorageBits,
                StorageBytes = src.StorageBytes,
                PointCount = src.PointCount,
                Vec128Count = src.Vec128Count,
                Vec128Remainder = src.Vec128Remainder,
                Vec256Count = src.Vec256Count,
                Vec256Remainder = src.Vec256Remainder
            };
        
        GridStats()
        {

        }

        [PropInfo("name","The description name")]
        public string Name {get;set;}

        /// <summary>
        /// The number of grid rows
        /// </summary>
        [PropInfo("rows","The number of grid rows")]
        public ushort RowCount {get;set;}
        
        /// <summary>
        /// The number of grid columns
        /// </summary>
        [PropInfo("cols","The number of grid columns")]
        public ushort ColCount {get;set;}

        /// <summary>
        /// The number of bits in a storage segment
        /// </summary>
        [PropInfo("segsize","The number of bits in a storage segment")]
        public ushort SegWidth {get;set;}

        /// <summary>
        /// The number of points covered by the grid
        /// </summary>
        [PropInfo("points", "The number of points covered by the grid")]
        public int PointCount {get;set;}

        /// <summary>
        /// The number of segment-aligned segments required for storage
        /// </summary>
        [PropInfo("segs","The number of segment-aligned segments required for storage")]
        public int SorageSegs {get;set;}

        /// <summary>
        /// The number of segment-aligned bits required for storage
        /// </summary>
        [PropInfo("bits","The number of segment-aligned bits required for storage")]
        public int StorageBits {get;set;}

        /// <summary>
        /// The number of segment-aligned bytes bits required for storage
        /// </summary>
        [PropInfo("bytes","The number of segment-aligned bytes bits required for storage")]
        public int StorageBytes {get;set;}
            
        /// <summary>
        /// The number of whole 128-bit vectors required for storage
        /// </summary>
        [PropInfo("v128","The number of whole 128-bit vectors required for storage")]
        public int Vec128Count {get;set;}

        /// <summary>
        /// The number bytes that do not fit into a whole number of 128-bit vectors
        /// </summary>
        [PropInfo("v128/r")]
        public int Vec128Remainder  {get;set;}
        
        /// <summary>
        /// The number of whole 256-bit vectors required for storage
        /// </summary>
        [PropInfo("v256")]
        public int Vec256Count {get;set;}
            
        /// <summary>
        /// The number bytes that do not fit into a whole number of 256-bit vectors
        /// </summary>
        [PropInfo("v256/r")]
        public int Vec256Remainder {get;set;}            
    }
}