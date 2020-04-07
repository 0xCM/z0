//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    /// <summary>
    /// A data structure that covers a natural count of packed bits
    /// </summary>
    /// <typeparam name="N">The number of contained bits</typeparam>
    /// <typeparam name="T">The storage cell type</typeparam>
    public readonly ref struct BitBlock<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {        
        readonly Span<T> data;

        /// <summary>
        /// The maximum number of bits contained in an N[T] vector component
        /// </summary>
        public static int CellWidth => bitsize<T>();

        /// <summary>
        /// The number of bits represented by an N[T] vector
        /// </summary>
        public static int BitCount => nati<N>();

        /// <summary>
        /// The number of segments required to allocate an N[T] vector
        /// </summary>
        public static int CellCount 
        {
            [MethodImpl(Inline)]
            get => BitCalcs.tablecells(nati<N>(), nati<N1>(), (int)bitsize<T>());
        }
        
        /// <summary>
        /// The maximum number of bits that can be represented by an N[T] vector
        /// </summary>
        public static int BitCapacity => CellCount * CellWidth;
        
        [MethodImpl(Inline)]
        public static implicit operator BitBlock<T>(in BitBlock<N,T> x)
            => new BitBlock<T>(x.data, (int)new N().NatValue);

        [MethodImpl(Inline)]
        public static BitBlock<N,T> operator &(in BitBlock<N,T> x, in BitBlock<N,T> y)
            => new BitBlock<N,T>(gspan.and(x.data, y.data, x.data.Replicate()));

        [MethodImpl(Inline)]
        public static BitBlock<N,T> operator |(in BitBlock<N,T> x, in BitBlock<N,T> y)
            => new BitBlock<N,T>(gspan.or(x.data, y.data, x.data.Replicate()));

        [MethodImpl(Inline)]
        public static BitBlock<N,T> operator ^(in BitBlock<N,T> lhs, in BitBlock<N,T> rhs)
            => new BitBlock<N,T>(gspan.xor(lhs.data, rhs.data, lhs.data.Replicate()));

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitBlock<N,T> operator ~(in BitBlock<N,T> x)
            => new BitBlock<N,T>(gspan.not(x.data, x.data.Replicate()));                        

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static bit operator %(in BitBlock<N,T> x, in BitBlock<N,T> y)
            => BitBlocks.dot(x,y);

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitBlock<N,T> operator -(in BitBlock<N,T> x)
            => new BitBlock<N,T>(gspan.negate(x.data, x.data.Replicate()));                        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(in BitBlock<N,T> x)
            => x.Nonempty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(in BitBlock<N,T> x)
            => !x.Nonempty;

        [MethodImpl(Inline)]
        public static bit operator ==(in BitBlock<N,T> x, in BitBlock<N,T> y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bit operator !=(in BitBlock<N,T> x, in BitBlock<N,T> y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        internal BitBlock(Span<T> src)
        {
            require(src.Length * CellWidth >= BitCount);
            this.data = src;
        }

        [MethodImpl(Inline)]
        internal BitBlock(params T[] src)
            : this(src.AsSpan())
        {

        }

        [MethodImpl(Inline)]
        internal BitBlock(Span<T> src, bool skipChecks)
            => this.data = src;

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
                data.Fill(Literals.maxval<T>());
            else
                data.Clear();
        }

        [MethodImpl(Inline)]
        public bool Equals(in BitBlock<N,T> rhs)
            => data.Identical(rhs.data);           
        
        public override bool Equals(object obj)
            => throw new NotImplementedException();
        
        public override int GetHashCode()
            => throw new NotImplementedException();
 
        public override string ToString()
            => throw new NotImplementedException();
    }
}