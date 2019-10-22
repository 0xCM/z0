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

    public struct BitVector<T>
        where T : unmanaged
    {
        T data;

        /// <summary>
        /// Creates a bitvector defined by a single cell or portion thereof
        /// </summary>
        /// <param name="src">The source cell</param>
        [MethodImpl(Inline)]
        public static BitVector<T> From(T src)
            => new BitVector<T>(src);

        /// <summary>
        /// Creates a bitvector from a span of bytes
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="n">The bitvector length</param>
        [MethodImpl(Inline)]
        public static BitVector<T> From(Span<byte> src)
            => From(src.TakeScalar<T>());

        /// <summary>
        /// Loads an bitvector of minimal size from a source bitstring
        /// </summary>
        /// <param name="src">The bitstring source</param>
        [MethodImpl(Inline)]
        public static BitVector<T> From(BitString src)
            => From(src.ToPackedBytes());

        [MethodImpl(Inline)]
        public static implicit operator BitVector<T>(T src)
            => new BitVector<T>(src);

        /// <summary>
        /// Computes the bitwias AND between the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector<T> operator &(BitVector<T> x, BitVector<T> y)
            => bitvector.and(x,y);

        /// <summary>
        /// Computes the bitwias AND between the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector<T> operator |(BitVector<T> x, BitVector<T> y)
            => bitvector.or(x,y);

        /// <summary>
        /// Computes the bitwise XOR between the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector<T> operator ^(BitVector<T> x, BitVector<T> y)
            => bitvector.xor(x,y);

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static bit operator %(BitVector<T> x, BitVector<T> y)
            => bitvector.dot(x,y);

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector<T> operator ~(BitVector<T> src)
            => bitvector.not(src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(BitVector<T> src)
            => src.Nonempty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(BitVector<T> src)
            => !src.Nonempty;

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector<T> x, in BitVector<T> y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector<T> x, in BitVector<T> y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        BitVector(T src)
            => this.data = src;

        /// <summary>
        /// The number of bits represented by the vector
        /// </summary>
        public readonly uint Length 
        {
            [MethodImpl(Inline)]
            get => bitsize<T>();
        }

        /// <summary>
        /// Presents the represented data as a span of bytes
        /// </summary>
        public readonly Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(data);
        }

        /// <summary>
        /// A bit-level accessor/manipulator
        /// </summary>
        public bit this[int index]
        {
            [MethodImpl(Inline)]
            get => Get(index);
            
            [MethodImpl(Inline)]
            set => Set(index, value);
        }

        /// <summary>
        /// Is true if no bits are enabled, false otherwise
        /// </summary>
        public bool Empty
        {
            [MethodImpl(Inline)]
            get => Pop() == 0;
        }

        /// <summary>
        /// Is true if the vector has at least one enabled bit; false otherwise
        /// </summary>
        public readonly bool Nonempty
        {
            [MethodImpl(Inline)]
            get => Pop() != 0;
        }

        /// <summary>
        /// Reads a bit value
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public readonly bit Get(int pos)
            => gbits.test(data, pos);

        /// <summary>
        /// Sets a bit value
        /// </summary>
        /// <param name="pos">The absolute bit position</param>
        /// <param name="value">The value the bit will receive</param>
        [MethodImpl(Inline)]
        public void Set(int pos, bit value)
            => data = gbits.set(ref data, (byte)pos, value);

        /// <summary>
        /// Tests the status of an identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to test</param>
        [MethodImpl(Inline)]
        public bool Test(int pos)
            => gbits.test(data, pos);

        /// <summary>
        /// Enables an identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void Enable(int pos)
            => data = gbits.set(ref data, (byte)pos, bit.On);

        /// <summary>
        /// Disables an identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public void Disable(int pos)
            => data = gbits.disable(ref data, (byte)pos);

        /// <summary>
        /// Computes the scalar product between this vector and another of identical length
        /// </summary>
        /// <param name="y">The right vector</param>
        public bit Dot(BitVector<T> y)
        {
            require(this.Length == y.Length);

            var result = bit.Off;
            for(var i=0; i<Length; i++)
                result ^= this[i] & y[i];
            return result;
        }

        /// <summary>
        /// Specifies a reference to the leading cell
        /// </summary>
        public T Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// Extracts the represented data as a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitString ToBitString()
            => BitString.FromScalar<T>(data); 

        /// <summary>
        /// Counts the vector's enabled bits
        /// </summary>
        [MethodImpl(Inline)]
        public readonly uint Pop()
            => gbits.pop(data);

        /// <summary>
        /// Sets all the bits to align with the source value
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        public void Fill(bit value)
        {
            var primal = PrimalInfo.Get<T>();
            if(value)
                data = gmath.maxval<T>();
            else
                data = default(T);
        }

        [MethodImpl(Inline)]
        public bool Equals(in BitVector<T> y)
            => ToBitString().Equals(y.ToBitString());

        [MethodImpl(Inline)]
        public string Format(bool tlz = false, bool specifier = false, int? blockWidth = null)
            => ToBitString().Format(tlz, specifier, blockWidth);

        public override bool Equals(object obj)
            => throw new NotImplementedException();
        
        public override int GetHashCode()
            => throw new NotImplementedException();
    
        public override string ToString()
            => throw new NotImplementedException();

    }

}
