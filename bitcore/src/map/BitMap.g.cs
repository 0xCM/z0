//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a bitmap over cells of unmanaged parameteric type
    /// </summary>
   public readonly struct BitMap<T> : IBitMap<T>
        where T : unmanaged
    {    
        readonly BitMap Data;

        [MethodImpl(Inline)]
        public static implicit operator BitMap(BitMap<T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public BitMap(BitMap src)
        {
            this.Data = src;
        }

        /// <summary>
        /// The (maximum) number of bits in a cell
        /// </summary>
        public BitSize BitCount 
            => Data.BitCount;

        /// <summary>
        /// The number of cells in the map codomain
        /// </summary>
        public int CellCount 
            => Data.CellCount;

        /// <summary>
        /// The size of the storage cell in bits
        /// </summary>
        public BitSize CellWidth 
            => Data.CellWidth;

        [MethodImpl(Inline)]
        public ref readonly BitIndex Index(uint pos)
            => ref Data.Index(pos);

        public ref readonly BitIndex this[uint pos]
        {
            [MethodImpl(Inline)]
            get => ref Data.Index(pos);
        }

        [MethodImpl(Inline)]
        public ref readonly uint Cell(uint pos)
            => ref Data.Cell(pos);

        [MethodImpl(Inline)]
        public ref readonly byte Offset(uint pos)
            => ref Data.Offset(pos);
    }
}