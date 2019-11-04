//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    


    /// <summary>
    /// Defines a natural bitvector parametrized by a primal component type
    /// </summary>
    /// <typeparam name="N">The vector length type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    public ref struct BitVector<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {        
        Span<T> data;
        
        /// <summary>
        /// The maximum number of bits contained in a vector component
        /// </summary>
        /// <typeparam name="T">The vector component type</typeparam>
        public static readonly BitSize SegmentCapacity = bitsize<T>();

        public static readonly BitSize BitCount = new N().value;        

        /// <summary>
        /// The minimum number of cells of type T required to store N bits
        /// </summary>
        public static int MinCellCount = BitCount/SegmentCapacity + (BitCount % SegmentCapacity == 0 ? + 0 : + 1);

        public static readonly BitSize TotalCapacity = MinCellCount * SegmentCapacity;

        public static readonly BitSize UnusedBits = TotalCapacity - BitCount;

        /// <summary>
        /// The number of bits used in the last cell
        /// </summary>
        static readonly BitSize LastUsedBits = SegmentCapacity - UnusedBits;

        static readonly BitPos MaxBitIndex = BitCount - 1;
    
        static readonly BitCellIndex<T>[] BitMap = BitSize.BitMap<T>(BitCount);

        //static readonly GridMap BitMap2 = BitGridInfo<N,N,T>.Map

        [MethodImpl(Inline)]
        public static BitVector<N,T> Alloc(T? fill = null)
        {
            Span<T> cells = new T[MinCellCount];
            if(fill.HasValue)
                cells.Fill(fill.Value);
            return new BitVector<N,T>(cells);
        }

        [MethodImpl(Inline)]
        internal static BitVector<N,T> FromArrayUnchecked(T[] src)
            => new BitVector<N,T>(src,true);

        [MethodImpl(Inline)]
        internal static BitVector<N,T> FromSpanUnchecked(Span<T> src)
            => new BitVector<N,T>(src,true);

        [MethodImpl(Inline)]
        public static BitVector<N,T> FromCell(T src)
            => new BitVector<N, T>(src);        
        
        [MethodImpl(Inline)]
        public static BitVector<N,T> FromArray(params T[] src)
            => new BitVector<N,T>(src);    

        [MethodImpl(Inline)]
        public static BitVector<N,T> FromSpan(Span<T> src)
            => new BitVector<N,T>(src);    

        [MethodImpl(Inline)]
        public static BitVector<N,T> FromBytes(Span<byte> src)
            => new BitVector<N,T>(src.As<byte,T>());    

        [MethodImpl(Inline)]
        public static implicit operator BitCells<T>(BitVector<N,T> src)
            => BitCells<T>.FromCells(src.data, (int)new N().value);

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator &(BitVector<N,T> lhs, BitVector<N,T> rhs)
            => new BitVector<N,T>(mathspan.and(lhs.data, rhs.data, lhs.data.Replicate(true)));

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator |(BitVector<N,T> lhs, BitVector<N,T> rhs)
            => new BitVector<N,T>(mathspan.or(lhs.data, rhs.data, lhs.data.Replicate(true)));

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator ^(BitVector<N,T> lhs, BitVector<N,T> rhs)
            => new BitVector<N,T>(mathspan.xor(lhs.data, rhs.data, lhs.data.Replicate(true)));

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> operator ~(BitVector<N,T> src)
            => new BitVector<N,T>(mathspan.not(src.data, src.data.Replicate(true)));                        

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static bit operator %(BitVector<N,T> lhs, BitVector<N,T> rhs)
            => lhs.Dot(rhs);

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> operator -(BitVector<N,T> src)
            => new BitVector<N,T>(mathspan.negate(src.data, src.data.Replicate(true)));                        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(BitVector<N,T> src)
            => src.Nonempty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(BitVector<N,T> src)
            => !src.Nonempty;

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector<N,T> lhs, in BitVector<N,T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector<N,T> lhs, in BitVector<N,T> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        BitVector(Span<T> src)
            : this()
        {
            require(src.Length * SegmentCapacity >= BitCount);
            this.data = src;
        }

        [MethodImpl(Inline)]
        BitVector(params T[] src)
            : this(src.AsSpan())
        {

        }

        [MethodImpl(Inline)]
        BitVector(Span<T> src, bool skipChecks)
            : this()
        {
            this.data = src;
        }

        [MethodImpl(Inline)]
        BitVector(T[] src, bool skipChecks)
        {
            this.data = src;
        }

        /// <summary>
        /// Reads a bit value
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public bit Get(BitPos pos)
        {
            ref readonly var cell = ref BitMap[CheckIndex(pos)];
            return gbits.test(Data[cell.Segment], cell.Offset);
        }
            
        /// <summary>
        /// Sets a bit value
        /// </summary>
        /// <param name="pos">The absolute bit position</param>
        /// <param name="value">The value the bit will receive</param>
        [MethodImpl(Inline)]
        public void Set(BitPos pos, bit value)
        {
            ref readonly var cell = ref BitMap[CheckIndex(pos)];
            gbits.set(ref Data[cell.Segment], (byte)cell.Offset, value);
        }

        /// <summary>
        /// A bit-level accessor/manipulator
        /// </summary>
        public bit this[BitPos index]
        {
            [MethodImpl(Inline)]
            get => Get(index);
            
            [MethodImpl(Inline)]
            set => Set(index, value);
        }

        /// <summary>
        /// Computes the scalar product between this vector and another
        /// </summary>
        /// <param name="rhs">The other vector</param>
        public bit Dot(BitVector<N,T> rhs)
        {             
            var result = bit.Off;
            for(var i=0; i<Length; i++)
                result ^= this[i] & rhs[i];
            return result;
        }

        /// <summary>
        /// The data over which the bitvector is constructed
        /// </summary>
        public Span<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => data.AsBytes();
        }

        /// <summary>
        /// The number of bits represented by the vector
        /// </summary>
        public readonly BitSize Length
        {
            [MethodImpl(Inline)]
            get => BitCount;
        }

        /// <summary>
        /// The maximum number of bits that can be represented by the vector
        /// </summary>
        public readonly BitSize Capacity
        {
            [MethodImpl(Inline)]
            get => TotalCapacity;
        }

        /// <summary>
        /// Tne number of bits allocated but which are not in use, i.e. the delta
        /// between the capacity and length
        /// </summary>
        public readonly BitSize Unused
        {
            [MethodImpl(Inline)]
            get => UnusedBits;
        }

        /// <summary>
        /// The number of allocated segments
        /// </summary>
        public int SegCount
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        /// <summary>
        /// Toggles an index-identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void Toggle(BitPos index)
        {         
            ref readonly var pos = ref BitMap[CheckIndex(index)];
            BitMaskG.toggle(ref Data[pos.Segment],  (byte)pos.Offset);
        }

        /// <summary>
        /// Enables an index-identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void Enable(BitPos index)
        {
            ref readonly var pos = ref BitMap[CheckIndex(index)];
            gbits.enable(ref Data[pos.Segment],  pos.Offset);
        }

        /// <summary>
        /// Disables an identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public void Disable(BitPos index)
        {
            ref readonly var pos = ref BitMap[CheckIndex(index)];
            gbits.disable(ref Data[pos.Segment], (byte)pos.Offset);
        }

        /// <summary>
        /// Tests the status of an identified bit
        /// </summary>
        /// <param name="index">The position of the bit to test</param>
        [MethodImpl(Inline)]
        public bool Test(BitPos index)
            => Get(index);

        /// <summary>
        /// Counts the vector's enabled bits
        /// </summary>
        [MethodImpl(Inline)]
        public int Pop()
        {
            var count = 0u;
            for(var i=0; i < MinCellCount; i++)
                count += gbits.pop(Data[i]);
            return (int)count;
        }

        /// <summary>
        /// Returns true if no bits are enabled, false otherwise
        /// </summary>
        public bool Empty
        {
            [MethodImpl(Inline)]
            get => Pop() == 0;
        }

        /// <summary>
        /// Returns true if the vector has at least one enabled bit; false otherwise
        /// </summary>
        public bool Nonempty
        {
            [MethodImpl(Inline)]
            get => Pop() != 0;
        }

        /// <summary>
        /// Returns a reference to the leading segment of the underlying storage
        /// </summary>
        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref head(data);
        }

        /// <summary>
        /// Sets all the bits in use to the specified state
        /// </summary>
        /// <param name="state">The source state</param>
        public void Fill(bit state)
        {            
            if(state)
                data.Fill(gmath.maxval<T>());
            else
                data.Clear();
        }

        /// <summary>
        /// Extracts the represented data as a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public BitString ToBitString()
            => BitString.FromScalars<T>(Data, Length); 

        [MethodImpl(Inline)]
        public string Format(bool tlz = false, bool specifier = false, int? blockWidth = null)
            => ToBitString().Format(tlz, specifier, blockWidth);

        [MethodImpl(Inline)]
        public bool Equals(in BitVector<N,T> rhs)
            => ToBitString().Equals(rhs.ToBitString());
           
        [MethodImpl(Inline)]
        static int CheckIndex(BitPos index)
            =>  index <= MaxBitIndex ? index  : Errors.ThrowOutOfRange<BitPos>(index, 0, MaxBitIndex);

        /// <summary>
        /// Counts the number of bits set up to and including the specified position
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit for which rank will be calculated</param>
        [MethodImpl(Inline)]
        public uint Rank(BitPos pos)
            => throw new NotImplementedException();

        public override bool Equals(object obj)
            => throw new NotImplementedException();
        
        public override int GetHashCode()
            => throw new NotImplementedException();
 
        public override string ToString()
            => throw new NotImplementedException();
    }


}