//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;
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
		/// Constructs a bit position from a linear/absolute index
		/// </summary>
		/// <param name="bitindex">The linear index</param>
		[MethodImpl(Inline)]
		public static BitPos<T> FromLinearIndex(uint bitindex)
			=> new BitPos<T>(BitPos.linear(CellWidth, bitindex), BitPos.offset(CellWidth, bitindex));

		[MethodImpl(Inline)]
		public BitPos(ushort cellindex, ushort bitoffset)
		{
			CellIndex = cellindex;
			BitOffset = bitoffset;
		}

		public int LinearIndex
		{
			[MethodImpl(Inline)]
			get => CellIndex * CellWidth + BitOffset;
		}

		[MethodImpl(Inline)]
		public int CountTo(BitPos<T> src)
			=> Math.Abs(LinearIndex - src.LinearIndex) + 1;

		[MethodImpl(Inline)]
        public void Add(uint src)
        {
            var newIndex = (uint)(LinearIndex + src);
            CellIndex = linear(CellWidth,newIndex);
            BitOffset = offset(CellWidth,newIndex);
        }

		[MethodImpl(Inline)]
        public void Sub(uint rhs)
        {
            var newindex = ScalarCast.uint32(LinearIndex - rhs);
            if(newindex > 0)
			{
				CellIndex = linear(CellWidth,newindex);
				BitOffset = offset(CellWidth,newindex);
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
		public bool Equals(BitPos<T> rhs)
			=> CellIndex == rhs.CellIndex
            && BitOffset == rhs.BitOffset;

		public string Format()
			=> string.Format("({0},{1}/{2})", LinearIndex, CellIndex, BitOffset);

		public override string ToString()
			=> Format();

		public override int GetHashCode()
			=> LinearIndex.GetHashCode();

		public override bool Equals(object rhs)
            => rhs is BitPos<T> x && Equals(x);

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
		public static int operator -(BitPos<T> a, BitPos<T> b)
		{
			return a.CountTo(b);
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
		public static bool operator ==(BitPos<T> a, BitPos<T> b)
			=> a.Equals(b);

		[MethodImpl(Inline)]
		public static bool operator !=(BitPos<T> a, BitPos<T> b)
			=> !a.Equals(b);

		[MethodImpl(Inline)]
		public static bool operator <(BitPos<T> lhs, BitPos<T> rhs)
			=> lhs.LinearIndex < rhs.LinearIndex;

		[MethodImpl(Inline)]
		public static bool operator <=(BitPos<T> lhs, BitPos<T> rhs)
			=> lhs.LinearIndex <= rhs.LinearIndex;

		[MethodImpl(Inline)]
		public static bool operator >(BitPos<T> lhs, BitPos<T> rhs)
			=> lhs.LinearIndex > rhs.LinearIndex;

		[MethodImpl(Inline)]
		public static bool operator >=(BitPos<T> lhs, BitPos<T> rhs)
			=> lhs.LinearIndex >= rhs.LinearIndex;

		[MethodImpl(Inline)]
        public static implicit operator BitPos<T>((ushort cellindex, byte bitoffset) x)
            => new BitPos<T>(x.cellindex, x.bitoffset);

		[MethodImpl(Inline)]
		public static BitPos<T> Define(ushort cellindex, byte bitoffset)
			=> new BitPos<T>(cellindex, bitoffset);

        /// <summary>
        /// The zero position
        /// </summary>
		public static BitPos<T> Zero
			=> default(BitPos<T>);

		/// <summary>
		/// Specifies the number of bits that can be placed in one segment
		/// </summary>
		public static ushort CellWidth
			=> width<T>(w16);
	}
}