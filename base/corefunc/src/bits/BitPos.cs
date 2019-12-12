//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
	using static zfunc;
		 
	public struct BitPos
	{
		/// <summary>
		/// Constructs a bit cell index from a cell and bit offset
		/// </summary>
		/// <param name="index">The linear index</param>
		[MethodImpl(Inline)]
		public static BitPos FromCellIndex(byte capacity, uint cell, byte offset)
			=> new BitPos(capacity, cell, offset);

		/// <summary>
		/// Constructs a bit cell index from a linear/absolute bit index
		/// </summary>
		/// <param name="index">The linear index</param>
		[MethodImpl(Inline)]
		public static BitPos FromBitIndex(byte capacity, uint index)
			=> new BitPos(capacity, CalcCellIndex(capacity, index), CalcBitOffset(capacity, index));

        /// <summary>
        /// Computes the cell index of a linear bit index
        /// </summary>
        /// <param name="index">The source index</param>
		[MethodImpl(Inline)]
        public static uint CalcCellIndex(byte capacity, uint index) 
			=> index/capacity;

        /// <summary>
        /// Computes the offset of a linear index
        /// </summary>
        /// <param name="index">The source index</param>
		[MethodImpl(Inline)]
        public static byte CalcBitOffset(byte capacity, uint index) 
			=> (byte)(index % capacity);

		/// <summary>
		/// Computes a linear bit index from a cell index and cell-relative offset
		/// </summary>
		/// <param name="capacity">The cell capacity</param>
		/// <param name="cell">The cell index</param>
		/// <param name="offset">The cell offset</param>
		[MethodImpl(Inline)]
		public static uint CalcBitIndex(byte capacity, uint cell, byte offset)
			=> cell*capacity + offset;

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
		public byte Capacity;			 

		[MethodImpl(Inline)]
		public static BitPos operator +(BitPos index, uint bitcount)
		{
			index.Add(bitcount);
            return index;
		}

		[MethodImpl(Inline)]
		public static BitPos operator -(BitPos index, uint bitcount)
		{
            index.Sub(bitcount);
            return index;
		}

		[MethodImpl(Inline)]
		public static uint operator -(BitPos lhs, BitPos rhs)
			=> lhs.CountTo(rhs);

		[MethodImpl(Inline)]
		public static BitPos operator --(BitPos index)
		{
            index.Dec();
            return index;
		}

		[MethodImpl(Inline)]
		public static BitPos operator ++(BitPos index)
		{
			index.Inc();
            return index;
		}

		[MethodImpl(Inline)]
		public static bool operator <(BitPos lhs, BitPos rhs)		
			=> lhs.BitIndex < rhs.BitIndex;		

		[MethodImpl(Inline)]
		public static bool operator <=(BitPos lhs, BitPos rhs)
			=> lhs.BitIndex <= rhs.BitIndex;

		[MethodImpl(Inline)]
		public static bool operator >(BitPos lhs, BitPos rhs)
			=> lhs.BitIndex > rhs.BitIndex;

		[MethodImpl(Inline)]
		public static bool operator >=(BitPos lhs, BitPos rhs)
			=> lhs.BitIndex >= rhs.BitIndex;

		[MethodImpl(Inline)]
		public static bool operator ==(BitPos lhs, BitPos rhs)
			=> lhs.Equals(rhs);

		[MethodImpl(Inline)]
		public static bool operator !=(BitPos lhs, BitPos rhs)
			=> !lhs.Equals(rhs);

		[MethodImpl(Inline)]
		public BitPos(byte capacity, uint cell, byte offset)
		{
			this.CellIndex = cell;
			this.BitOffset = offset;
			this.Capacity = capacity;
		}

		/// <summary>
		/// The linear/absolute position of the bit
		/// </summary>
		public uint BitIndex
		{
			[MethodImpl(Inline)]
			get => this.CellIndex * Capacity + BitOffset;
		}

		[MethodImpl(Inline)]
		public uint CountTo(BitPos other)
			=> (uint)Math.Abs((long)BitIndex - (long)other.BitIndex) + 1;

		[MethodImpl(Inline)]
        public void Add(uint rhs)
        {
            var bitpos = (uint)(BitIndex + rhs);
            this.CellIndex = CalcCellIndex(bitpos);
            this.BitOffset = CalcBitOffset(bitpos);
        }

        [MethodImpl(Inline)]
        void UpdateFrom(uint index)
        {
            this.CellIndex = CalcCellIndex(index);
            this.BitOffset = CalcBitOffset(index);
        }

        [MethodImpl(Inline)]
        void Reset()
        {
            this.CellIndex = 0;
            this.BitOffset = 0;
        }

		[MethodImpl(Inline)]
        public void Sub(uint rhs)
        {
            var newIndex = BitIndex - rhs;
            if(newIndex > 0)
                UpdateFrom((uint)newIndex);
            else
                Reset();
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
                    BitOffset = (byte)(Capacity - 1);
                    --CellIndex;
                }            
            }
        }

		[MethodImpl(Inline)]
        public void Inc()
        {
            if(BitOffset < Capacity - 1)
                BitOffset++;
            else
            {
                CellIndex++;
                BitOffset = 0;
            }
        }

        /// <summary>
        /// Computes the cell index of a linear bit index
        /// </summary>
        /// <param name="bitpos">The source index</param>
		[MethodImpl(Inline)]
        uint CalcCellIndex(uint bitpos) 
			=> bitpos/Capacity;

        /// <summary>
        /// Computes the offset of a linear index
        /// </summary>
        /// <param name="bitpos">The source index</param>
		[MethodImpl(Inline)]
        byte CalcBitOffset(uint bitpos) 
			=> (byte)(bitpos % Capacity);

		/// <summary>
		/// Computes a linear bit index from a cell index and cell-relative offset
		/// </summary>
		/// <param name="capacity">The cell capacity</param>
		/// <param name="cell">The cell index</param>
		/// <param name="offset">The cell offset</param>
		[MethodImpl(Inline)]
		uint CalcBitIndex(uint cell, byte offset)
			=> cell*Capacity + offset;


		[MethodImpl(Inline)]
		public bool Equals(BitPos rhs)
			=> CellIndex == rhs.CellIndex
            && BitOffset == rhs.BitOffset
			&& Capacity == rhs.Capacity;

		public string Format()
			=> string.Format("({0},{1}/{2})", BitIndex, CellIndex, BitOffset);

		public override string ToString()
			=> Format();

		public override int GetHashCode()
			=> HashCode.Combine(Capacity, CellIndex, BitOffset);

		public override bool Equals(object rhs)
            => rhs is BitPos x && Equals(x);

	}		 

	/// <summary>
	/// Identifies a bit position within a contiguous sequence of T-element values
	/// </summary>
	public struct BitPos<T> 
        where T : unmanaged
	{
		/// <summary>
		/// The container-relative 0-based offset of the segment
		/// </summary>
		public ushort Segment;

		/// <summary>
		/// The segment-relative offset of the bit
		/// </summary>
		public ushort Offset;

        /// <summary>
        /// The zero position
        /// </summary>
		public static BitPos<T> Zero => default(BitPos<T>);

		/// <summary>
		/// Specifies the number of bits that can be placed in one segment
		/// </summary>
		public static ushort SegCapacity => (ushort)bitsize<T>();

        /// <summary>
        /// Computes the segment of a linear index
        /// </summary>
        /// <param name="index">The source index</param>
		[MethodImpl(Inline)]
        static ushort IndexSegment(uint index) => (ushort)(index/SegCapacity);

        /// <summary>
        /// Computes the offset of a linear index
        /// </summary>
        /// <param name="index">The source index</param>
		[MethodImpl(Inline)]
        static ushort IndexOffset(uint index) => (ushort)(index % SegCapacity);

		/// <summary>
		/// Constructs a bit position from a linear/absolute index
		/// </summary>
		/// <param name="index">The linear index</param>
		[MethodImpl(Inline)]
		public static BitPos<T> FromIndex(uint index)
			=> new BitPos<T>(IndexSegment(index), IndexOffset(index));

		[MethodImpl(Inline)]
		public static BitPos<T>operator +(BitPos<T> pos, uint bitcount)
		{
			pos.Add(bitcount);
            return pos;
		}

		[MethodImpl(Inline)]
		public static BitPos<T> operator -(BitPos<T> lhs, uint bitcount)
		{
            lhs.Sub(bitcount);
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
        public static implicit operator BitPos<T>((ushort SegId, byte BitOffset) x)
            => Define(x.SegId, x.BitOffset);

		[MethodImpl(Inline)]
		public static BitPos<T> Define(ushort SegIdx, byte BitOffset)
			=> new BitPos<T>(SegIdx, BitOffset);

		[MethodImpl(Inline)]
		BitPos(uint Segment, uint Offset)
		{
			this.Segment = (ushort)Segment;
			this.Offset = (ushort)Offset;
		}

		[MethodImpl(Inline)]
		public BitPos(ushort Segment, byte Offset)
		{
			this.Segment = Segment;
			this.Offset = Offset;
		}

		public int LinearIndex
		{
			[MethodImpl(Inline)]
			get => this.Segment * SegCapacity + this.Offset;
		}

		[MethodImpl(Inline)]
		public int CountTo(BitPos<T> other)
			=> Math.Abs(this.LinearIndex - other.LinearIndex) + 1;

		[MethodImpl(Inline)]
        public void Add(uint rhs)
        {
            var newIndex = (uint)(LinearIndex + rhs);
            this.Segment = IndexSegment(newIndex);
            this.Offset = IndexOffset(newIndex);
        }

        [MethodImpl(Inline)]
        void UpdateFrom(uint index)
        {
            this.Segment = IndexSegment(index);
            this.Offset = IndexOffset(index);
        }

        [MethodImpl(Inline)]
        void Reset()
        {
            this.Segment = 0;
            this.Offset = 0;
        }

		[MethodImpl(Inline)]
        public void Sub(uint rhs)
        {
            var newIndex = LinearIndex - rhs;
            if(newIndex > 0)
                UpdateFrom((uint)newIndex);
            else
                Reset();
        }

		[MethodImpl(Inline)]
        public void Dec()
        {
            if(Offset > 0)
                --Offset;
            else
            {
                if(Segment != 0)
                {
                    Offset = (byte)(SegCapacity - 1);
                    --Segment;
                }            
            }
        }

		[MethodImpl(Inline)]
        public void Inc()
        {
            if(Offset < SegCapacity - 1)
                Offset++;
            else
            {
                Segment++;
                Offset = 0;
            }
        }

		[MethodImpl(Inline)]
		public bool Equals(BitPos<T> rhs)
			=> this.Segment == rhs.Segment 
            && this.Offset == rhs.Offset;

		public string Format()
			=> string.Format("({0},{1}/{2})", LinearIndex, Segment, Offset);

		public override string ToString()
			=> Format();

		public override int GetHashCode()
			=> LinearIndex.GetHashCode();

		public override bool Equals(object rhs)
            => rhs is BitPos<T> x && Equals(x);
	}
}
