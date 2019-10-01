//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    using static zfunc;

    public struct BitVector8<T> : IFixedScalarBits<BitVector8<T>, T>
        where T : unmanaged
    {        
        BitVector8 data;
        
        [MethodImpl(Inline)]
        public static implicit operator BitVector8(BitVector8<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator BitVector8<T>(BitVector8 src)
            => From(src);

        /// <summary>
        /// <summary>
        /// Computes the component-wise AND of the operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector8<T> operator &(BitVector8<T> x, BitVector8<T> y)
            => bitvector.and(x.data, y.data);

        /// <summary>
        /// Computes the bitwise OR of the source operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector8<T> operator |(BitVector8<T> x, BitVector8<T> y)
            => bitvector.or(x.data,y.data);

        /// <summary>
        /// Computes the XOR of the source operands. 
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector8<T> operator ^(BitVector8<T> x, BitVector8<T> y)
            => bitvector.xor(x.data,y.data);

        /// <summary>
        /// Computes the bitwise complement of the operand. 
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector8<T> operator ~(BitVector8<T> x)
            => bitvector.flip(x.data);

        [MethodImpl(Inline)]
        public static BitVector8<T> From(T src)
            => new BitVector8<T>(src);

        [MethodImpl(Inline)]
        public static BitVector8<T> From(BitVector8 src)
            => new BitVector8<T>(src);

        [MethodImpl(Inline)]
        public BitVector8(T src)
        {
            this.data = As.uint8(src);
        }

        [MethodImpl(Inline)]
        public BitVector8(BitVector8 src)
        {
            this.data = src;
        }

        public BitVector8<T> this[Range range] 
        {
            [MethodImpl(Inline)]
            get => From(data[range]);
        }

        public Bit this[BitPos pos] 
        { 
            [MethodImpl(Inline)]
            get => data[pos]; 
            
            [MethodImpl(Inline)]
            set => data[pos] = value; 
        }

        public BitVector8<T> this[BitPos first, BitPos last] 
        {
            [MethodImpl(Inline)]
            get => From(data[first,last]);
        }

        public T Scalar 
        {
            [MethodImpl(Inline)]
            get => As.generic<T>(data);
        }

        public Span<byte> Bytes 
        {
            [MethodImpl(Inline)]
            get => data.Bytes;
        }

        public BitSize Capacity 
        {
            [MethodImpl(Inline)]
            get => data.Capacity;
        }

        public BitSize Length 
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }

        public bool Empty 
        {
            [MethodImpl(Inline)]
            get => data.Empty;
        }

        public bool Nonempty 
        {
            [MethodImpl(Inline)]
            get => data.Nonempty;
        }

        [MethodImpl(Inline)]
        public BitVector8<T> Between(BitPos first, BitPos last)        
            => From(data.Between(first,last));

        [MethodImpl(Inline)]
        public ref byte Byte(int index)
            => ref data.Byte(index);

        [MethodImpl(Inline)]
        public void Disable(BitPos pos)
            => data.Disable(pos);

        [MethodImpl(Inline)]
        public Bit Dot(BitVector8<T> rhs)
            => data.Dot(rhs.data);

        [MethodImpl(Inline)]
        public void Enable(BitPos pos)
            => data.Enable(pos);

        [MethodImpl(Inline)]
        public BitVector8<T> Gather(BitVector8<T> mask)
            => From(data.Gather(mask.data));

        [MethodImpl(Inline)]
        public Bit Get(BitPos pos)
            => data.Get(pos);

        [MethodImpl(Inline)]
        public BitVector8<T> Lsb(int n)
            => From(data.Lsb(n));

        [MethodImpl(Inline)]
        public BitVector8<T> Msb(int n)
            => From(data.Msb(n));

        [MethodImpl(Inline)]
        public BitSize Nlz()
            => data.Nlz();

        [MethodImpl(Inline)]
        public BitSize Ntz()
            => data.Ntz();

        [MethodImpl(Inline)]
        public void Permute(Perm p)
            => data.Permute(p);

        [MethodImpl(Inline)]
        public BitSize Pop()
            => data.Pop();

        [MethodImpl(Inline)]
        public uint Rank(BitPos pos)
            => data.Rank(pos);

        [MethodImpl(Inline)]
        public BitVector8<T> Replicate()
            => From(data);

        [MethodImpl(Inline)]
        public BitVector8<T> Replicate(Perm p)
            => From(data.Replicate(p));

        [MethodImpl(Inline)]
        public void Reverse()
            => data.Reverse();

        [MethodImpl(Inline)]
        public BitVector8<T> Rol(uint offset)
        {
            data.Rol(offset);
            return this;
        }

        [MethodImpl(Inline)]
        public BitVector8<T> Ror(uint offset)
        {
            data.Ror(offset);
            return this;
        }

        [MethodImpl(Inline)]
        public void Set(BitPos pos, Bit value)
            => data.Set(pos,value);

        [MethodImpl(Inline)]
        public BitVector8<T> Sll(uint offset)
        {
            data.Sll(offset);
            return this;
        }

        [MethodImpl(Inline)]
        public BitVector8<T> Srl(uint offset)
        {
            data.Srl(offset);
            return this;
        }

        [MethodImpl(Inline)]
        public bool Test(BitPos pos)
            => data.Test(pos);
        
        [MethodImpl(Inline)]
        public BitVector8<T> And(BitVector8<T> y)
        {
            data.And(y.data);
            return this;
        }

        [MethodImpl(Inline)]
        public BitVector8<T> Or(BitVector8<T> y)
        {
            data.Or(y.data);
            return this;
        }

        [MethodImpl(Inline)]
        public BitVector8<T> XOr(BitVector8<T> y)
        {
            data.XOr(y.data);
            return this;
        }

        [MethodImpl(Inline)]
        public BitVector8<T> Flip()
        {
            data.Flip();
            return this;
        }

        [MethodImpl(Inline)]
        public BitString ToBitString()
            => data.ToBitString();

        [MethodImpl(Inline)]
        public string Format(bool tlz, bool specifier, int? blockWidth)
            => data.Format(tlz,specifier,blockWidth);

        [MethodImpl(Inline)]
        public bool Equals(BitVector8<T> x)
            => data.Equals(x.data);

        public override bool Equals(object other)
            => other is BitVector8<T> x && Equals(x);

        public override int GetHashCode()
            => data.GetHashCode();

        public override string ToString()
            => Scalar.ToString();
    }
 
}