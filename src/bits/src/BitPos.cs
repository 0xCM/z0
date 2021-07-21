//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

	[ApiHost]
	public struct BitPos
	{
        const NumericKind Closure = UnsignedInts;

		/// <summary>
		/// Computes the order-invariant absolute distance between two positions
		/// </summary>
		/// <param name="a">The left position</param>
		/// <param name="b">The right position</param>
		[MethodImpl(Inline), Op]
		public static uint delta(BitPos a, BitPos b)
			=> ScalarCast.uint32(core.abs((long)a.LinearIndex - (long)b.LinearIndex));

        /// <summary>
        /// Computes the cell index of a linear bit index
        /// </summary>
        /// <param name="w">The width of a storage cell</param>
        /// <param name="index">The linear bit index</param>
		[MethodImpl(Inline)]
        public static uint linear(uint w, uint index)
			=> index/w;

		/// <summary>
		/// Computes a linear bit index from a cell index and cell-relative offset
		/// </summary>
		/// <param name="w">The cell width</param>
		/// <param name="cellindex">The cell index</param>
		/// <param name="offset">The cell-relative offset of the bit</param>
		[MethodImpl(Inline)]
		public static uint linear(uint w, uint cellindex, uint offset)
			=> cellindex*w + offset;

        /// <summary>
        /// Computes the offset of a linear bit index over storage cells of specified width
        /// </summary>
        /// <param name="w">The cell width</param>
        /// <param name="index">The linear bit index</param>
		[MethodImpl(Inline), Op]
        public static byte offset(uint w, uint index)
			=> ScalarCast.uint8(index % w);

		/// <summary>
		/// Defines a bit position predicated on the width of a storage cell and the 0-based linear bit index
		/// </summary>
        /// <param name="w">The storage cell width</param>
		/// <param name="index">The linear bit index</param>
		[MethodImpl(Inline), Op]
		public static BitPos init(uint w, uint index)
			=> new BitPos(w, linear(w, index), offset(w, index));

		/// <summary>
		/// Defines a bit position predicated on the width and container-relative index of a storage cell and a cell-relative bit offset
		/// </summary>
        /// <param name="w">The storage cell width</param>
		/// <param name="cellindex">The container-relative cell index</param>
		/// <param name="offset">The cell-relative bit offset</param>
		[MethodImpl(Inline), Op]
		public static BitPos FromCellIndex(uint w, uint cellindex, uint offset)
			=> new BitPos(w, cellindex, offset);

		/// <summary>
		/// Defines a bit position predicated on a parametric cell type and a cell-relative bit offset
		/// </summary>
		/// <param name="cellindex">The container-relative cell index</param>
		/// <param name="offset">The cell-relative bit offset</param>
		[MethodImpl(Inline), Op, Closures(UnsignedInts)]
		public static BitPos<T> FromCellIndex<T>(uint cellindex, uint offset)
			where T : unmanaged
				=> BitPos<T>.Define(cellindex, offset);

        /// <summary>
        /// Defines a bit position, relative to a T-valued sequence, predicated on a linear index
        /// </summary>
        /// <param name="index">The sequence-relative index of the target bit</param>
        /// <typeparam name="T">The sequence element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitPos<T> position<T>(uint index)
            where T : unmanaged
				=> new BitPos<T>(BitPos.linear(width<T>(), index), BitPos.offset(width<T>(), index));

        /// <summary>
        /// Defines a bit position, relative to a T-valued sequence, predicated on a linear index
        /// </summary>
		/// <param name="index">The linear index</param>
        /// <param name="cell">The cell index</param>
        /// <param name="offset">The cell-relative offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
		public static void bitpos<T>(uint index, out uint cell, out uint offset)
            where T : unmanaged
        {
            var w = width<T>(w16);
			cell = BitPos.linear(w, index);
            offset = BitPos.offset(w, index);
        }

        /// <summary>
		/// A container-relative 0-based cell offset
		/// </summary>
		public uint CellIndex;

		/// <summary>
		/// A cell-relative bit offset
		/// </summary>
		public uint BitOffset;

		/// <summary>
		/// The bit-width of a cell
		/// </summary>
		public uint CellWidth;

		[MethodImpl(Inline)]
		public BitPos(uint cellwidth, uint cellindex, uint bitoffset)
		{
			CellWidth = cellwidth;
			CellIndex = cellindex;
			BitOffset = bitoffset;
		}

		/// <summary>
		/// The linear/absolute bit index of the represented position
		/// </summary>
		public uint LinearIndex
		{
			[MethodImpl(Inline)]
			get => linear(CellWidth, CellIndex, BitOffset);
		}

		[MethodImpl(Inline), Op]
        public void Add(uint bitindex)
        {
            var newindex = LinearIndex + bitindex;
            CellIndex = linear(CellWidth,newindex);
            BitOffset = offset(CellWidth, newindex);
        }

		[MethodImpl(Inline), Op]
        public void Sub(uint bitindex)
        {
            var newIndex = LinearIndex - bitindex;
            if(newIndex > 0)
			{
				CellIndex = linear(CellWidth, bitindex);
				BitOffset = offset(CellWidth, bitindex);
			}
            else
            {
				CellIndex = 0;
				BitOffset = 0;
			}
        }

		[MethodImpl(Inline), Op]
        public void Dec()
        {
            if(BitOffset > 0)
                --BitOffset;
            else
            {
                if(CellIndex != 0)
                {
                    BitOffset = CellWidth - 1;
                    --CellIndex;
                }
            }
        }

		[MethodImpl(Inline), Op]
        public void Inc()
        {
            if(BitOffset < CellWidth - 1)
                BitOffset++;
            else
            {
                CellIndex++;
                BitOffset = 0;
            }
        }

		[MethodImpl(Inline)]
		public bool Equals(BitPos rhs)
			=> CellIndex == rhs.CellIndex
            && BitOffset == rhs.BitOffset
			&& CellWidth == rhs.CellWidth;

		public string Format()
			=> string.Format("({0},{1}/{2})", LinearIndex, CellIndex, BitOffset);

		public override string ToString()
			=> Format();

		public override int GetHashCode()
			=> HashCode.Combine(CellWidth, CellIndex, BitOffset);

		public override bool Equals(object rhs)
            => rhs is BitPos x && Equals(x);

		[MethodImpl(Inline)]
		public static BitPos operator +(BitPos pos, uint count)
		{
			pos.Add(count);
            return pos;
		}

		[MethodImpl(Inline)]
		public static BitPos operator -(BitPos pos, uint count)
		{
            pos.Sub(count);
            return pos;
		}

		[MethodImpl(Inline)]
		public static uint operator -(BitPos a, BitPos b)
			=> delta(a,b);

		[MethodImpl(Inline)]
		public static BitPos operator --(BitPos pos)
		{
            pos.Dec();
            return pos;
		}

		[MethodImpl(Inline)]
		public static BitPos operator ++(BitPos pos)
		{
			pos.Inc();
            return pos;
		}

		[MethodImpl(Inline)]
		public static bool operator <(BitPos a, BitPos b)
			=> a.LinearIndex < b.LinearIndex;

		[MethodImpl(Inline)]
		public static bool operator <=(BitPos a, BitPos b)
			=> a.LinearIndex <= b.LinearIndex;

		[MethodImpl(Inline)]
		public static bool operator >(BitPos a, BitPos b)
			=> a.LinearIndex > b.LinearIndex;

		[MethodImpl(Inline)]
		public static bool operator >=(BitPos a, BitPos b)
			=> a.LinearIndex >= b.LinearIndex;

		[MethodImpl(Inline)]
		public static bool operator ==(BitPos a, BitPos b)
			=> a.Equals(b);

		[MethodImpl(Inline)]
		public static bool operator !=(BitPos a, BitPos b)
			=> !a.Equals(b);
	}
}