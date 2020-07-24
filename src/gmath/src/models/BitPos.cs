//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static Konst;
    using static z;

	[ApiDataType]
	public struct BitPos
	{
		/// <summary>
		/// The container-relative 0-based offset of the cell
		/// </summary>
		public uint CellIndex;

		/// <summary>
		/// The cell-relative offset of the bit
		/// </summary>
		public byte BitOffset;

		/// <summary>
		/// The bit-width of a cell
		/// </summary>
		public byte CellWidth;	

		ushort Padding;		 

		/// <summary>
		/// Defines a bit position predicated on the width of a storage cell and the 0-based linear bit index
		/// </summary>
        /// <param name="w">The storage cell width</param>
		/// <param name="index">The linear bit index</param>
		[MethodImpl(Inline)]
		public static BitPos FromBitIndex(byte w, uint index)
			=> new BitPos(w, linear(w, index), offset(w, index));

		/// <summary>
		/// Defines a bit position predicated on the width and container-relative index of a storage cell and a cell-relative bit offset
		/// </summary>
        /// <param name="w">The storage cell width</param>
		/// <param name="cellindex">The container-relative cell index</param>
		/// <param name="offset">The cell-relative bit offset</param>
		[MethodImpl(Inline)]
		public static BitPos FromCellIndex(byte w, ushort cellindex, byte offset)
			=> new BitPos(w, cellindex, offset);

		/// <summary>
		/// Defines a bit position predicated on a parametric cell type and a cell-relative bit offset
		/// </summary>
		/// <param name="cellindex">The container-relative cell index</param>
		/// <param name="offset">The cell-relative bit offset</param>
		[MethodImpl(Inline), Closures(UnsignedInts)]
		public static BitPos<T> FromCellIndex<T>(ushort cellindex, byte offset)
			where T : unmanaged
				=> BitPos<T>.Define((ushort)cellindex, offset);

		/// <summary>
		/// Defines a bit position predicated on a parametric cell type and linear bit index
		/// </summary>
		/// <param name="index">The linear bit index</param>
		[MethodImpl(Inline), Closures(UnsignedInts)]
		public static BitPos<T> FromBitIndex<T>(uint index)
			where T : unmanaged
				=> BitPos<T>.FromLinearIndex(index);
				
        /// <summary>
        /// Computes the cell index of a linear bit index
        /// </summary>
        /// <param name="w">The width of a storage cell</param>
        /// <param name="index">The linear bit index</param>
		[MethodImpl(Inline)]
        public static ushort linear(byte w, uint index) 
			=> uint16(index/w);

        /// <summary>
        /// Computes the offset of a linear bit index over storage cells of specified width
        /// </summary>
        /// <param name="w">The cell width</param>
        /// <param name="index">The linear bit index</param>
		[MethodImpl(Inline)]
        public static byte offset(byte w, uint index) 
			=> uint8(index % w);

		/// <summary>
		/// Computes a linear bit index from a cell index and cell-relative offset
		/// </summary>
		/// <param name="w">The cell width</param>
		/// <param name="cellindex">The cell index</param>
		/// <param name="offset">The cell-relative offset of the bit</param>
		[MethodImpl(Inline)]
		public static uint linear(byte w, uint cellindex, byte offset)
			=> cellindex*w + offset;

		/// <summary>
		/// Computes the order-invariant absolute distance between two positions
		/// </summary>
		/// <param name="lhs">The left position</param>
		/// <param name="rhs">The right position</param>
		[MethodImpl(Inline)]
		public static uint delta(BitPos lhs, BitPos rhs)
			=> uint32(math.abs((long)lhs.BitIndex - (long)rhs.BitIndex));

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
		public static uint operator -(BitPos lpos, BitPos rpos)
			=> delta(lpos,rpos);

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
		public static bool operator <(BitPos lpos, BitPos rpos)		
			=> lpos.BitIndex < rpos.BitIndex;		

		[MethodImpl(Inline)]
		public static bool operator <=(BitPos lpos, BitPos rpos)
			=> lpos.BitIndex <= rpos.BitIndex;

		[MethodImpl(Inline)]
		public static bool operator >(BitPos lpos, BitPos rpos)
			=> lpos.BitIndex > rpos.BitIndex;

		[MethodImpl(Inline)]
		public static bool operator >=(BitPos lpos, BitPos rpos)
			=> lpos.BitIndex >= rpos.BitIndex;

		[MethodImpl(Inline)]
		public static bool operator ==(BitPos lpos, BitPos rpos)
			=> lpos.Equals(rpos);

		[MethodImpl(Inline)]
		public static bool operator !=(BitPos lpos, BitPos rpos)
			=> !lpos.Equals(rpos);

		[MethodImpl(Inline)]
		public BitPos(byte cellwidth, uint cellindex, byte bitoffset)
		{
			CellWidth = cellwidth;
			CellIndex = cellindex;
			BitOffset = bitoffset;
			Padding = 0;
		}

		/// <summary>
		/// The linear/absolute bit index of the represented position
		/// </summary>
		public uint BitIndex
		{
			[MethodImpl(Inline)]
			get => linear(CellWidth, CellIndex, BitOffset);
		}
		
		[MethodImpl(Inline)]
        public void Add(uint bitindex)
        {
            var newindex = (uint)(BitIndex + bitindex);
            CellIndex = linear(CellWidth,newindex);
            BitOffset = offset(CellWidth, newindex);
        }

		[MethodImpl(Inline)]
        public void Sub(uint bitindex)
        {
            var newIndex = BitIndex - bitindex;
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

		[MethodImpl(Inline)]
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

		[MethodImpl(Inline)]
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
			=> string.Format("({0},{1}/{2})", BitIndex, CellIndex, BitOffset);

		public override string ToString()
			=> Format();

		public override int GetHashCode()
			=> HashCode.Combine(CellWidth, CellIndex, BitOffset);

		public override bool Equals(object rhs)
            => rhs is BitPos x && Equals(x);
	}
}