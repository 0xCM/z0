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

    /// <summary>
    /// Defines a 256-bit bitmap over cells of unmanaged parameteric type
    /// </summary>
    public readonly struct BitMap256<T> : IBitMap<T>
        where T : unmanaged
    {
        readonly BitMap Data;        

        public static readonly BitMap256<T> TheOnly = Map256();
        
        [MethodImpl(Inline)]
        BitMap256(BitMap src)
        {
            Data = src;
        }

        public ref readonly BitIndex this[uint pos]
        {
            [MethodImpl(Inline)]
            get => ref Index(pos);
        }

        public BitSize BitCount
        {
            [MethodImpl(Inline)]
            get => 256;
        }

        /// <summary>
        /// The size of a storage cell in bits
        /// </summary>
        public BitSize CellWidth
            => Data.CellWidth;
        
        /// <summary>
        /// The number of cells in the maping range
        /// </summary>
        public int CellCount 
            => Data.CellCount;

        [MethodImpl(Inline)]
        public ref readonly BitIndex Index(uint pos)
            => ref Data.Index(pos);

        [MethodImpl(Inline)]
        public ref readonly uint Cell(uint pos)
            => ref Data.Cell(pos);

        [MethodImpl(Inline)]
        public ref readonly byte Offset(uint pos)
            => ref Data.Offset(pos);

        /// <summary>
        /// Creates the mapping specialized for the parameteric closure
        /// </summary>
        static BitMap256<T> Map256()        
        {
            const int bitcount = 256;
            var cellwidth = bitsize<T>();
            var cellcount = Vector256<T>.Count;
            var indices = new BitIndex[bitcount];
            for(var cell = 0u; cell < cellcount; cell++)
            for(byte bit = 0; bit < cellwidth; bit++)
                indices[cell*cellwidth + bit] = new BitIndex(cell, bit);
            return new BitMap256<T>(BitMap.FromIndices(cellcount, cellwidth, indices));
        } 
    }
}