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
        
        [MethodImpl(Inline)]
        public static implicit operator BitCells<T>(in BitCells<N,T> x)
            => new BitCells<T>(x.data, (int)new N().NatValue);

        [MethodImpl(Inline)]
        public static BitCells<N,T> operator &(in BitCells<N,T> x, in BitCells<N,T> y)
            => new BitCells<N,T>(mathspan.and(x.data, y.data, x.data.Replicate(true)));

        [MethodImpl(Inline)]
        public static BitCells<N,T> operator |(in BitCells<N,T> x, in BitCells<N,T> y)
            => new BitCells<N,T>(mathspan.or(x.data, y.data, x.data.Replicate(true)));

        [MethodImpl(Inline)]
        public static BitCells<N,T> operator ^(in BitCells<N,T> lhs, in BitCells<N,T> rhs)
            => new BitCells<N,T>(mathspan.xor(lhs.data, rhs.data, lhs.data.Replicate(true)));

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitCells<N,T> operator ~(in BitCells<N,T> x)
            => new BitCells<N,T>(mathspan.not(x.data, x.data.Replicate(true)));                        

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static bit operator %(in BitCells<N,T> x, in BitCells<N,T> y)
            => BitCells.dot(x,y);

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitCells<N,T> operator -(in BitCells<N,T> x)
            => new BitCells<N,T>(mathspan.negate(x.data, x.data.Replicate(true)));                        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(in BitCells<N,T> x)
            => x.Nonempty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(in BitCells<N,T> x)
            => !x.Nonempty;

        [MethodImpl(Inline)]
        public static bit operator ==(in BitCells<N,T> x, in BitCells<N,T> y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bit operator !=(in BitCells<N,T> x, in BitCells<N,T> y)
            => !x.Equals(y);

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

        /// <summary>
        /// The data over which the bitvector is constructed
        /// </summary>
        public Span<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
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
        /// The number of represented bits
        /// </summary>
        public readonly int Width
        {
            [MethodImpl(Inline)]
            get => BitCount;
        }

        /// <summary>
        /// The number of allocated cells
        /// </summary>
        public readonly int Length
        {
            [MethodImpl(Inline)]
            get => data.Length;
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


        [MethodImpl(Inline)]
        public bool Equals(in BitCells<N,T> rhs)
            => data.Identical(rhs.data);
           
        
        public override bool Equals(object obj)
            => throw new NotImplementedException();
        
        public override int GetHashCode()
            => throw new NotImplementedException();
 
        public override string ToString()
            => throw new NotImplementedException();
    }
}