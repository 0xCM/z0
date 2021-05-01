//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

	[ApiHost]
	public partial struct BitPos
	{
		/// <summary>
		/// A container-relative 0-based cell offset
		/// </summary>
		public uint CellIndex;

		/// <summary>
		/// A cell-relative bit offset
		/// </summary>
		public ushort BitOffset;

		/// <summary>
		/// The bit-width of a cell
		/// </summary>
		public ushort CellWidth;

		[MethodImpl(Inline)]
		public BitPos(ushort cellwidth, uint cellindex, ushort bitoffset)
		{
			CellWidth = cellwidth;
			CellIndex = cellindex;
			BitOffset = bitoffset;
		}

		/// <summary>
		/// Defines a bit position predicated on the width of a storage cell and the 0-based linear bit index
		/// </summary>
        /// <param name="w">The storage cell width</param>
		/// <param name="index">The linear bit index</param>
		[MethodImpl(Inline), Op]
		public static BitPos init(ushort w, uint index)
			=> new BitPos(w, linear(w, index), offset(w, index));

		/// <summary>
		/// Defines a bit position predicated on the width and container-relative index of a storage cell and a cell-relative bit offset
		/// </summary>
        /// <param name="w">The storage cell width</param>
		/// <param name="cellindex">The container-relative cell index</param>
		/// <param name="offset">The cell-relative bit offset</param>
		[MethodImpl(Inline), Op]
		public static BitPos FromCellIndex(ushort w, ushort cellindex, ushort offset)
			=> new BitPos(w, cellindex, offset);

		/// <summary>
		/// Defines a bit position predicated on a parametric cell type and a cell-relative bit offset
		/// </summary>
		/// <param name="cellindex">The container-relative cell index</param>
		/// <param name="offset">The cell-relative bit offset</param>
		[MethodImpl(Inline), Op, Closures(UnsignedInts)]
		public static BitPos<T> FromCellIndex<T>(ushort cellindex, byte offset)
			where T : unmanaged
				=> BitPos<T>.Define((ushort)cellindex, offset);

		/// <summary>
		/// Defines a bit position predicated on a parametric cell type and linear bit index
		/// </summary>
		/// <param name="index">The linear bit index</param>
		[MethodImpl(Inline), Op, Closures(UnsignedInts)]
		public static BitPos<T> FromBitIndex<T>(uint index)
			where T : unmanaged
				=> BitPos<T>.FromLinearIndex(index);

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
            var newindex = (uint)(LinearIndex + bitindex);
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
                    BitOffset = (byte)(CellWidth - 1);
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