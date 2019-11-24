//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    /// <summary>
    /// Defines a natural bitvector parametrized by a primal component type
    /// </summary>
    /// <typeparam name="N">The vector length type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    public readonly ref struct BitCells<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {        
        readonly Span<T> data;

        /// <summary>
        /// The maximum number of bits contained in an N[T] vector component
        /// </summary>
        public static int SegWidth => bitsize<T>();

        /// <summary>
        /// The number of bits represented by an N[T] vector
        /// </summary>
        public static int BitCount => natval<N>();

        /// <summary>
        /// The number of segments required to allocate an N[T] vector
        /// </summary>
        public static int SegCount 
        {
            [MethodImpl(Inline)]
            get => BitCalcs.segcount(natval<N>(), natval<N1>(), (ushort)bitsize<T>());
        }
        
        /// <summary>
        /// The maximum number of bits that can be represented by an N[T] vector
        /// </summary>
        public static int TotalCapacity => SegCount * SegWidth;

        /// <summary>
        /// Tne number of bits allocated but which are not in use, i.e. the delta between the capacity and length
        /// </summary>
        public static int UnusedCapacity => TotalCapacity - BitCount;

        [MethodImpl(NotInline)]
        public static BitCells<N,T> Alloc(T? fill = null)
        {                        
            Span<T> cells = new T[SegCount];
            if(fill.HasValue)
                cells.Fill(fill.Value);
            return new BitCells<N,T>(cells, true);
        }

        [MethodImpl(Inline)]
        internal static BitCells<N,T> FromArrayUnchecked(T[] src)
            => new BitCells<N,T>(src,true);

        [MethodImpl(Inline)]
        internal static BitCells<N,T> FromSpanUnchecked(Span<T> src)
            => new BitCells<N,T>(src,true);

        [MethodImpl(Inline)]
        public static BitCells<N,T> FromCell(T src)
            => new BitCells<N, T>(src);        
        
        [MethodImpl(Inline)]
        public static BitCells<N,T> FromArray(params T[] src)
            => new BitCells<N,T>(src);    

        [MethodImpl(Inline)]
        public static BitCells<N,T> FromSpan(Span<T> src)
            => new BitCells<N,T>(src);    

        [MethodImpl(Inline)]
        public static BitCells<N,T> FromBytes(Span<byte> src)
            => new BitCells<N,T>(src.As<byte,T>());    

        [MethodImpl(Inline)]
        public static implicit operator BitCells<T>(in BitCells<N,T> src)
            => new BitCells<T>(src.data, (int)new N().NatValue);

        [MethodImpl(Inline)]
        public static BitCells<N,T> operator &(in BitCells<N,T> lhs, in BitCells<N,T> rhs)
            => new BitCells<N,T>(mathspan.and(lhs.data, rhs.data, lhs.data.Replicate(true)));

        [MethodImpl(Inline)]
        public static BitCells<N,T> operator |(in BitCells<N,T> lhs, in BitCells<N,T> rhs)
            => new BitCells<N,T>(mathspan.or(lhs.data, rhs.data, lhs.data.Replicate(true)));

        [MethodImpl(Inline)]
        public static BitCells<N,T> operator ^(in BitCells<N,T> lhs, in BitCells<N,T> rhs)
            => new BitCells<N,T>(mathspan.xor(lhs.data, rhs.data, lhs.data.Replicate(true)));

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitCells<N,T> operator ~(in BitCells<N,T> src)
            => new BitCells<N,T>(mathspan.not(src.data, src.data.Replicate(true)));                        

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static bit operator %(in BitCells<N,T> lhs, in BitCells<N,T> rhs)
            => lhs.Dot(rhs);

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitCells<N,T> operator -(in BitCells<N,T> src)
            => new BitCells<N,T>(mathspan.negate(src.data, src.data.Replicate(true)));                        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(in BitCells<N,T> src)
            => src.Nonempty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(in BitCells<N,T> src)
            => !src.Nonempty;

        [MethodImpl(Inline)]
        public static bool operator ==(in BitCells<N,T> lhs, in BitCells<N,T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitCells<N,T> lhs, in BitCells<N,T> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        internal BitCells(Span<T> src)
        {
            require(src.Length * SegWidth >= BitCount);
            this.data = src;
        }

        [MethodImpl(Inline)]
        internal BitCells(params T[] src)
            : this(src.AsSpan())
        {

        }

        [MethodImpl(Inline)]
        internal BitCells(Span<T> src, bool skipChecks)
        {
            this.data = src;
        }

        [MethodImpl(Inline)]
        internal BitCells(T[] src, bool skipChecks)
        {
            this.data = src;
        }
            
        /// <summary>
        /// A bit-level accessor/manipulator
        /// </summary>
        public bit this[int bitpos]
        {
            [MethodImpl(Inline)]
            get => BitGrid.readbit(in Head, bitpos);
            
            [MethodImpl(Inline)]
            set => BitGrid.setbit(bitpos, value, ref Head);
        }

        /// <summary>
        /// Computes the scalar product between this vector and another
        /// </summary>
        /// <param name="rhs">The other vector</param>
        [MethodImpl(Inline)]
        public bit Dot(in BitCells<N,T> rhs)
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

        /// <summary>
        /// The number of bits represented by the vector
        /// </summary>
        public readonly BitSize Length
        {
            [MethodImpl(Inline)]
            get => BitCount;
        }

        /// <summary>
        /// Counts the vector's enabled bits
        /// </summary>
        [MethodImpl(Inline)]
        public int Pop()
        {
            var count = 0u;
            for(var i=0; i < data.Length; i++)
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
            => BitString.from(Data, Length); 

        [MethodImpl(Inline)]
        public string Format(bool tlz = false, bool specifier = false, int? blockWidth = null)
            => ToBitString().Format(tlz, specifier, blockWidth);

        [MethodImpl(Inline)]
        public bool Equals(in BitCells<N,T> rhs)
            => ToBitString().Equals(rhs.ToBitString());
           
        
        public override bool Equals(object obj)
            => throw new NotImplementedException();
        
        public override int GetHashCode()
            => throw new NotImplementedException();
 
        public override string ToString()
            => throw new NotImplementedException();
    }
}