//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Numerics;

    using static zfunc;
    using static Bits;
    using static Bytes;

    /// <summary>
    /// Defines a 4-bit bitvector
    /// </summary>
    public struct BitVector4 : IFixedScalarBits<BitVector4,byte>
    {
        internal byte data;

        public static readonly BitVector4 Zero = default;

        public static readonly BitSize BitSize = 4;

        public static readonly BitPos FirstPos = 0;

        public static readonly BitPos LastPos = BitSize - 1;


        /// <summary>
        /// Allocates a zero-filled vector
        /// </summary>
        public static BitVector4 Alloc()
            => new BitVector4();

        /// <summary>
        /// Creates a permutation-defined mask
        /// </summary>
        /// <param name="spec">The permutation</param>
        public static BitVector4 Mask(Perm spec)
        {
            var mask = Alloc();
            var n = math.min(spec.Length, mask.Length);
            for(var i = 0; i < n; i++)
                mask[spec[i]] = i; 
            return mask;
        }

        [MethodImpl(Inline)]
        public static BitVector4 FromParts(Bit? x0 = null, Bit? x1 = null, Bit? x2 = null, Bit? x3 = null)
        {
            var data = (byte)0;
            if(x0 == 1) data |= (1 << 0);
            if(x1 == 1) data |= (1 << 1);
            if(x2 == 1) data |= (1 << 2);
            if(x3 == 1) data |= (1 << 3);
            return data;
        }

        /// <summary>
        /// Constructs a bitvector from the 4 least significant bits of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector4 FromLo(byte src)        
            => new BitVector4((byte)(src & 0xF));

        /// <summary>
        /// Constructs a bitvector from the 4 most significant bits of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector4 FromHi(byte src)        
            => new BitVector4((byte)((src >> 4) & 0xF));

        /// <summary>
        /// Creates a vector from the lower 4 bits of a byte
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector4 FromScalar(byte src)
            => FromLo(src);

        /// <summary>
        /// Creates a vector from the primal source value with which it aligns
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector4 FromBitString(BitString src)
            => new BitVector4(src.IsEmpty ? (byte)0 : src.Pack()[0]);            

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N4,byte>(in BitVector4 src)
            => BitVector<N4,byte>.FromCells(src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitVector4(in byte src)
            => new BitVector4(src);

        [MethodImpl(Inline)]
        public static implicit operator byte(in BitVector4 src)
            => src.data;

        /// <summary>
        /// Computes the XOR of the source operands. 
        /// Note that this operator is equivalent to the addition operator (+)
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector4 operator ^(in BitVector4 lhs, in BitVector4 rhs)
            => (byte)(lhs.data ^ rhs.data);

        /// <summary>
        /// Computes the bitwise AND of the source operands
        /// Note that the AND operator is equivalent to the (*) operator
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector4 operator &(in BitVector4 lhs, in BitVector4 rhs)
            => (byte)(lhs.data & rhs.data);

        /// <summary>
        /// Computes the bitwise OR of the source operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector4 operator |(in BitVector4 lhs, in BitVector4 rhs)
            => bitvector.or(lhs,rhs);

        /// <summary>
        /// Computes the bitwise complement
        /// </summary>
        /// <param name="x">The left bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 operator ~(BitVector4 src)
            => bitvector.flip(src);

        /// <summary>
        /// Computes the component-wise sum of the source operands. 
        /// Note that this operator is equivalent to the XOR operator (^)
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector4 operator +(in BitVector4 lhs, in BitVector4 rhs)
            => bitvector.xor(lhs,rhs);

        /// <summary>
        /// Computes the product of the operands. 
        /// Note that this operator is equivalent to the AND operator (&)
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector4 operator *(in BitVector4 lhs, in BitVector4 rhs)
            => (byte)(lhs.data & rhs.data);

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit operator %(BitVector4 lhs, BitVector4 rhs)
            => bitvector.dot(lhs,rhs);

        [MethodImpl(Inline)]
        public static BitVector4 operator -(in BitVector4 src)
            => bitvector.negate(src);

        /// <summary>
        /// Subtracts the second operand from the first. 
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector4 operator - (BitVector4 lhs, BitVector4 rhs)
            => bitvector.sub(lhs,rhs);

        [MethodImpl(Inline)]
        public static BitVector4 operator >>(BitVector4 lhs, int offset)
            => bitvector.srl(lhs,offset);

        [MethodImpl(Inline)]
        public static BitVector4 operator <<(BitVector4 lhs, int offset)
            => bitvector.sll(lhs,offset);

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector4 lhs, in BitVector4 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector4 lhs, in BitVector4 rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public BitVector4(byte data)
        {
            this.data = TakeHi(math.sll(data,4));
        }

        public Bit this[BitPos pos]
        {
            [MethodImpl(Inline)]
            get => Get(pos);
            
            [MethodImpl(Inline)]
            set => Set(pos,value);
        }

        public BitVector4 this[Range range]
        {
            [MethodImpl(Inline)]
            get => Between(range.Start.Value, range.End.Value);
        }

        public BitVector4 this[BitPos lpos, BitPos rpos]
        {
            [MethodImpl(Inline)]
            get => Between(lpos, rpos);
        }

        /// <summary>
        /// The number of bits represented by the vector
        /// </summary>
        public readonly BitSize Length
        {
            [MethodImpl(Inline)]
            get => 4;
        }

        /// <summary>
        /// The maximum number of bits that can be represented by the vector
        /// </summary>
        public readonly BitSize Capacity
        {
            [MethodImpl]
            get => Length;
        }

        /// <summary>
        /// Returns true if all bits are disabled, false otherwise
        /// </summary>
        public readonly bool Empty
        {
            [MethodImpl(Inline)]
            get => data == 0;
        }

        /// <summary>
        /// Returns true if at least one bit is enabled, false otherwise
        /// </summary>
        public readonly bool Nonempty
        {
            [MethodImpl(Inline)]
            get => !Empty;
        }

        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="rhs">The right operand</param>
        public readonly Bit Dot(BitVector4 rhs)
            => bitvector.dot(this,rhs);

        /// <summary>
        /// Computes in-place the bitwise AND of the source vector and another,
        /// returning the result to the caller
        /// </summary>
        /// <param name="y">The other vector</param>
        [MethodImpl(Inline)]
        public BitVector4 And(BitVector4 y)
        {
            data &= y.data;
            return this;
        }

        /// <summary>
        /// Computes in-place the bitwise OR of the source vector and another,
        /// returning the result to the caller
        /// </summary>
        /// <param name="y">The other vector</param>
        [MethodImpl(Inline)]
        public BitVector4 Or(BitVector4 y)
        {
            data |= y.data;
            return this;
        }

        /// <summary>
        /// Computes in-place the bitwise XOR of the source vector and another,
        /// returning the result to the caller
        /// </summary>
        /// <param name="y">The other vector</param>
        [MethodImpl(Inline)]
        public BitVector4 XOr(BitVector4 y)
        {
            data ^= y.data;
            return this;
        }


        /// <summary>
        /// Computes in-place the bitwise complement of the source vector,
        /// returning the result to the caller
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector4 Flip()
        {
            data = TakeHi((byte)((byte)(~data) << 4));
            return this;
        }

        [MethodImpl(Inline)]
        static byte TakeHi(byte src)        
            => (byte)((src >> 4) & 0xF);


        /// <summary>
        /// Enables a bit if it is disabled
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void Enable(BitPos pos)
            => data |= (byte)(1 << pos);

        /// <summary>
        /// Disables a bit if it is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public void Disable(BitPos pos)
            => data &= (byte)~((byte)(1 << pos));

        /// <summary>
        /// Sets a bit value
        /// </summary>
        /// <param name="pos">The position of the bit to set</param>
        /// <param name="value">The bit value</param>
        [MethodImpl(Inline)]
        public void Set(BitPos pos, Bit value)
        {
            if(value) 
                data |= (byte)(1 << pos);
            else
                data &= (byte)~((byte)(1 << pos));
        }

        /// <summary>
        /// Determines whether a bit is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public readonly bool Test(BitPos pos)
            => (data & (1 << pos)) != 0;

        /// <summary>
        /// Reads a bit value
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public readonly Bit Get(BitPos pos)
            => Test(pos);

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => new byte[]{data};
        }

        /// <summary>
        /// Shifts the bits in the vector leftwards
        /// </summary>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public BitVector4 Sll(uint offset)
        {
            data <<= (int)offset;
            return this;
        }

        /// <summary>
        /// Shifts the bits in the vector rightwards
        /// </summary>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public BitVector4 Srl(uint offset)
        {
            data >>= (int)offset;
            return this;
        }

        /// <summary>
        /// Counts the number of enabled bits in the vector
        /// </summary>
        [MethodImpl(Inline)]
        public BitSize Pop()
            => Bits.pop(data);

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public BitSize Nlz()
            => Bits.nlz((byte)(data << 4));

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public BitSize Ntz()
            => Bits.ntz(data);

        /// <summary>
        /// Counts the number of bits set up to and including the specified position
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit for which rank will be calculated</param>
        [MethodImpl(Inline)]
        public uint Rank(BitPos pos)
            => Bits.rank(data,pos);

        [MethodImpl(Inline)]
        public bool Equals(in BitVector4 rhs)
            => data == rhs.data;

        [MethodImpl(Inline)]
        public bool AllOnes()
            => (0xF & data) == 0xF;
 
        /// <summary>
        /// Rearranges the vector in-place as specified by a permutation
        /// </summary>
        /// <param name="spec">The permutation</param>
        [MethodImpl(Inline)]
        public void Permute(Perm spec)
        {
            var src = Replicate();
            for(var i=0; i<Length; i++)
                this[i] = src[spec[i]];

        }

        /// <summary>
        /// Reverses the vector's bits
        /// </summary>
        [MethodImpl(Inline)]
        public void Reverse()
            => data = Bits.rev(data);

        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline)]
        public BitVector4 Between(BitPos first, BitPos last)
            => Bits.between(data, first, last);

        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline)]
        public BitVector4 Lsb(int n)                
            => Between(0, n - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public BitVector4 Msb(int n)                
            => Between(LastPos - n, LastPos);                

        /// <summary>
        /// Extracts the scalar represented by the vector
        /// </summary>
        public byte Scalar
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// Returns a copy of the vector
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector4 Replicate()
            => new BitVector4(data);

        /// <summary>
        /// Applies a permutation to a replicated vector
        /// </summary>
        /// <param name="p">The permutation</param>
        [MethodImpl(Inline)]
        public BitVector4 Replicate(Perm p)
        {
            var dst = Replicate();
            dst.Permute(p);
            return dst;
        }

        /// <summary>
        /// Populates a target vector with mask-identified source bits
        /// </summary>
        /// <param name="mask">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        [MethodImpl(Inline)]
        public BitVector4 Gather(BitVector4 mask)
            => Bits.gather(data, mask);

        /// <summary>
        /// Converts the vector to a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public BitString ToBitString()
            => data.ToBitString();

        [MethodImpl(Inline)]
        public string Format(bool tlz = false, bool specifier = false, int? blockWidth = null)
            => ToBitString().Format(tlz, specifier, blockWidth);

        [MethodImpl(Inline)]
        public bool Equals(BitVector4 other)
            => data == other.data;

        public override bool Equals(object obj)
            => obj is BitVector4 x ? Equals(x) : false;
        
        public override int GetHashCode()
            => data.GetHashCode();
        
        public override string ToString()
            => Format();

        public BitVector4 Ror(uint offset)
        {
            throw new NotImplementedException();
            
        }

        public BitVector4 Rol(uint offset)
        {
            throw new NotImplementedException();
        }

        public ref byte Byte(int index)
        {
            throw new NotImplementedException();
        }

    }
}