//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
	using static zfunc;
	using static As;

	public struct BitPos
	{
		/// <summary>
		/// Constructs a bit cell index from a linear/absolute bit index
		/// </summary>
		/// <param name="bitindex">The linear index</param>
		[MethodImpl(Inline)]
		public static BitPos FromBitIndex(byte cellwidth, uint bitindex)
			=> new BitPos(cellwidth, CalcCellIndex(cellwidth, bitindex), CalcBitOffset(cellwidth, bitindex));

		/// <summary>
		/// Constructs a bit cell index from a cell and bit offset
		/// </summary>
		/// <param name="index">The linear index</param>
		[MethodImpl(Inline)]
		public static BitPos FromCellIndex(byte cellwidth, ushort cellindex, byte bitoffset)
			=> new BitPos(cellwidth, cellindex, bitoffset);

		/// <summary>
		/// Constructs a bit cell index from a cell and bit offset
		/// </summary>
		/// <param name="index">The linear index</param>
		[MethodImpl(Inline)]
		public static BitPos<T> FromCellIndex<T>(ushort cellindex, byte bitoffset)
			where T : unmanaged
				=> BitPos<T>.Define((ushort)cellindex, bitoffset);

		/// <summary>
		/// Constructs a bit cell index from a linear/absolute bit index
		/// </summary>
		/// <param name="bitindex">The linear index</param>
		[MethodImpl(Inline)]
		public static BitPos<T> FromBitIndex<T>(uint bitindex)
			where T : unmanaged
				=> BitPos<T>.FromBitIndex(bitindex);
				
        /// <summary>
        /// Computes the cell index of a linear bit index
        /// </summary>
        /// <param name="bitindex">The source index</param>
		[MethodImpl(Inline)]
        public static ushort CalcCellIndex(byte cellwidth, uint bitindex) 
			=> uint16(bitindex/cellwidth);

        /// <summary>
        /// Computes the offset of a linear index
        /// </summary>
        /// <param name="bitindex">The source index</param>
		[MethodImpl(Inline)]
        public static byte CalcBitOffset(byte cellwidth, uint bitindex) 
			=> uint8(bitindex % cellwidth);

		/// <summary>
		/// Computes a linear bit index from a cell index and cell-relative offset
		/// </summary>
		/// <param name="cellwidth">The cell capacity</param>
		/// <param name="cellindex">The cell index</param>
		/// <param name="bitoffset">The cell offset</param>
		[MethodImpl(Inline)]
		public static uint CalcBitIndex(byte cellwidth, uint cellindex, byte bitoffset)
			=> cellindex*cellwidth + bitoffset;

		/// <summary>
		/// Computes the order-invariant/absolute distance between two positions
		/// </summary>
		/// <param name="lpos">The left position</param>
		/// <param name="rpos">The right position</param>
		/// <returns></returns>
		[MethodImpl(Inline)]
		public static uint Distance(BitPos lpos, BitPos rpos)
			=> uint32(Math.Abs((long)lpos.BitIndex - (long)rpos.BitIndex));// + 1;

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

		[MethodImpl(Inline)]
		public static BitPos operator +(BitPos pos, uint bitindex)
		{
			pos.Add(bitindex);
            return pos;
		}

		[MethodImpl(Inline)]
		public static BitPos operator -(BitPos pos, uint bitindex)
		{
            pos.Sub(bitindex);
            return pos;
		}

		[MethodImpl(Inline)]
		public static uint operator -(BitPos lpos, BitPos rpos)
			=> Distance(lpos,rpos);

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
			this.CellWidth = cellwidth;
			this.CellIndex = cellindex;
			this.BitOffset = bitoffset;
		}

		/// <summary>
		/// The linear/absolute bit index of the represented position
		/// </summary>
		public uint BitIndex
		{
			[MethodImpl(Inline)]
			get => CalcBitIndex(CellWidth, CellIndex, BitOffset);
		}
		
		[MethodImpl(Inline)]
        public void Add(uint bitindex)
        {
            var newindex = (uint)(BitIndex + bitindex);
            this.CellIndex = CalcCellIndex(CellWidth,newindex);
            this.BitOffset = CalcBitOffset(CellWidth, newindex);
        }

		[MethodImpl(Inline)]
        public void Sub(uint bitindex)
        {
            var newIndex = BitIndex - bitindex;
            if(newIndex > 0)
			{
				CellIndex = CalcCellIndex(CellWidth, bitindex);
				BitOffset = CalcBitOffset(CellWidth, bitindex);
			}
            else
            {
				this.CellIndex = 0;
				this.BitOffset = 0;
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
