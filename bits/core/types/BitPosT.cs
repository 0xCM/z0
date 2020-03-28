//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static Core;
	using static As;
	using static BitPos;

	/// <summary>
	/// Identifies a bit position within a contiguous sequence of T-element values together with their cell index/bit offsets 
	/// </summary>
	[StructLayout(LayoutKind.Sequential,Size = 32)]
	public struct BitPos<T> 
        where T : unmanaged
	{
		/// <summary>
		/// The container-relative 0-based offset of the segment
		/// </summary>
		public ushort CellIndex;

		/// <summary>
		/// The segment-relative offset of the bit
		/// </summary>
		public ushort BitOffset;

        /// <summary>
        /// The zero position
        /// </summary>
		public static BitPos<T> Zero => default(BitPos<T>);

		/// <summary>
		/// Specifies the number of bits that can be placed in one segment
		/// </summary>
		public static byte CellWidth => uint8(bitsize<T>());

		/// <summary>
		/// Constructs a bit position from a linear/absolute index
		/// </summary>
		/// <param name="bitindex">The linear index</param>
		[MethodImpl(Inline)]
		public static BitPos<T> FromBitIndex(uint bitindex)
			=> new BitPos<T>(
					BitPos.CalcCellIndex(CellWidth,bitindex), 
					BitPos.CalcBitOffset(CellWidth, bitindex));

		[MethodImpl(Inline)]
		public static BitPos<T>operator +(BitPos<T> pos, uint count)
		{
			pos.Add(count);
            return pos;
		}

		[MethodImpl(Inline)]
		public static BitPos<T> operator -(BitPos<T> lhs, uint count)
		{
            lhs.Sub(count);
            return lhs;
		}

		[MethodImpl(Inline)]
		public static int operator -(BitPos<T> lhs, BitPos<T> rhs)
		{
			return lhs.CountTo(rhs);
		}

		[MethodImpl(Inline)]
		public static BitPos<T> operator --(BitPos<T> src)
		{
            src.Dec();
            return src;
		}

		[MethodImpl(Inline)]
		public static BitPos<T> operator ++(BitPos<T> src)
		{
			src.Inc();
            return src;
		}

		[MethodImpl(Inline)]
		public static bool operator ==(BitPos<T> lhs, BitPos<T> rhs)
			=> lhs.Equals(rhs);

		[MethodImpl(Inline)]
		public static bool operator !=(BitPos<T> lhs, BitPos<T> rhs)
			=> !lhs.Equals(rhs);

		[MethodImpl(Inline)]
		public static bool operator <(BitPos<T> lhs, BitPos<T> rhs)		
			=> lhs.BitIndex < rhs.BitIndex;		

		[MethodImpl(Inline)]
		public static bool operator <=(BitPos<T> lhs, BitPos<T> rhs)
			=> lhs.BitIndex <= rhs.BitIndex;

		[MethodImpl(Inline)]
		public static bool operator >(BitPos<T> lhs, BitPos<T> rhs)
			=> lhs.BitIndex > rhs.BitIndex;

		[MethodImpl(Inline)]
		public static bool operator >=(BitPos<T> lhs, BitPos<T> rhs)
			=> lhs.BitIndex >= rhs.BitIndex;

		[MethodImpl(Inline)]
        public static implicit operator BitPos<T>((ushort cellindex, byte bitoffset) x)
            => Define(x.cellindex, x.bitoffset);

		[MethodImpl(Inline)]
		public static BitPos<T> Define(ushort cellindex, byte bitoffset)
			=> new BitPos<T>(cellindex, bitoffset);


		[MethodImpl(Inline)]
		public BitPos(ushort cellindex, byte bitoffset)
		{
			this.CellIndex = cellindex;
			this.BitOffset = bitoffset;
		}

		public int BitIndex
		{
			[MethodImpl(Inline)]
			get => this.CellIndex * CellWidth + this.BitOffset;
		}

		[MethodImpl(Inline)]
		public int CountTo(BitPos<T> other)
			=> Math.Abs(this.BitIndex - other.BitIndex) + 1;

		[MethodImpl(Inline)]
        public void Add(uint rhs)
        {
            var newIndex = (uint)(BitIndex + rhs);
            this.CellIndex = CalcCellIndex(CellWidth,newIndex);
            this.BitOffset = CalcBitOffset(CellWidth,newIndex);
        }

		[MethodImpl(Inline)]
        public void Sub(uint rhs)
        {
            var newindex = uint32(BitIndex - rhs);
            if(newindex > 0)
			{
				this.CellIndex = CalcCellIndex(CellWidth,newindex);
				this.BitOffset = CalcBitOffset(CellWidth,newindex);
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
		public bool Equals(BitPos<T> rhs)
			=> this.CellIndex == rhs.CellIndex 
            && this.BitOffset == rhs.BitOffset;

		public string Format()
			=> string.Format("({0},{1}/{2})", BitIndex, CellIndex, BitOffset);

		public override string ToString()
			=> Format();

		public override int GetHashCode()
			=> BitIndex.GetHashCode();

		public override bool Equals(object rhs)
            => rhs is BitPos<T> x && Equals(x);
	}
}