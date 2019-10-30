//---------------------------------------------------------------------------
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
    public struct BitVector4
    {
        internal byte data;

        public static BitVector4 Zero => default;

        public static BitVector4 One => 1;

        public static BitVector4 Ones => 0xFF;

        public const int Width = 4;

        public const int FirstPos = 0;

        public const int LastPos = Width - 1;

        /// <summary>
        /// Allocates a zero-filled vector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector4 Alloc()
            => new BitVector4();
        
        /// <summary>
        /// Creates a bitvector where the first bit is determined by a supplied bit and the hi 3 bits are disabled
        /// </summary>
        /// <param name="x0">The least bit</param>
        /// <param name="x1">The second bit</param>
        [MethodImpl(Inline)]
        public static BitVector4 FromBit(bit x0)
            => x0 ? (byte)1 : (byte)0;        

        /// <summary>
        /// Creates a bitvector where the first two bits a specified by the caller and the last two bits are disabled
        /// </summary>
        /// <param name="x0">The least bit</param>
        /// <param name="x1">The second bit</param>
        [MethodImpl(Inline)]
        public static BitVector4 FromBits(bit x0, bit x1)
        {
            var data = 0u;
            if(x0) 
                data |= (1 << 0);
            if(x1) 
                data |= (1 << 1);

            return (byte)data;
        }
        /// <summary>
        /// Creates a bitvector where the first three bits a specified by the caller
        /// and the hi bit is disabled
        /// </summary>
        /// <param name="x0">The least bit</param>
        /// <param name="x1">The second bit</param>
        /// <param name="x2">The third bit</param>
        [MethodImpl(Inline)]
        public static BitVector4 FromBits(bit x0, bit x1, bit x2)
        {
            var data = FromBits(x0,x1);
            if(x2) 
                data |= (1 << 2);
            return (byte)data;
        }

        [MethodImpl(Inline)]
        public static BitVector4 FromBits(bit x0, bit x1, bit x2, bit x3)
        {
            var data = FromBits(x0,x1,x2);
            if(x3) 
                data |= (1 << 3);
            return data;
        }

        /// <summary>
        /// Constructs a bitvector from the 4 least significant bits of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector4 FromLo(byte src)        
            => new BitVector4(src);

        /// <summary>
        /// Constructs a bitvector from the 4 most significant bits of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector4 FromHi(byte src)        
            => new BitVector4((byte)((src >> 4)));

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
            => BitVector<N4,byte>.FromArray(src.data);

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
            => BitVector.or(lhs,rhs);

        /// <summary>
        /// Computes the bitwise complement
        /// </summary>
        /// <param name="x">The left bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 operator ~(BitVector4 src)
            => BitVector.not(src);

        /// <summary>
        /// Computes the arithmetic sum of the source operands. 
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector4 operator +(BitVector4 x, BitVector4 y)
            => BitVector.add(x,y);

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
            => BitVector.dot(lhs,rhs);

        [MethodImpl(Inline)]
        public static BitVector4 operator -(in BitVector4 src)
            => BitVector.negate(src);

        /// <summary>
        /// Subtracts the second operand from the first. 
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector4 operator - (BitVector4 lhs, BitVector4 rhs)
            => BitVector.sub(lhs,rhs);

        [MethodImpl(Inline)]
        public static BitVector4 operator >>(BitVector4 lhs, int offset)
            => BitVector.srl(lhs,offset);

        [MethodImpl(Inline)]
        public static BitVector4 operator <<(BitVector4 lhs, int offset)
            => BitVector.sll(lhs,offset);

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector4 lhs, in BitVector4 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector4 lhs, in BitVector4 rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public BitVector4(byte data)
        {
            this.data = (byte)(data & 0xF);
        }

        public bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => GetBit(pos);
            
            [MethodImpl(Inline)]
            set => SetBit(pos,value);
        }

        public BitVector4 this[Range range]
        {
            [MethodImpl(Inline)]
            get => Between(range.Start.Value, range.End.Value);
        }

        public BitVector4 this[int first, int last]
        {
            [MethodImpl(Inline)]
            get => Between(first, last);
        }

        /// <summary>
        /// The number of bits represented by the vector
        /// </summary>
        public readonly int Length
        {
            [MethodImpl(Inline)]
            get => 4;
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
        public readonly bit Dot(BitVector4 rhs)
            => BitVector.dot(this,rhs);

        [MethodImpl(Inline)]
        static byte TakeHi(byte src)        
            => (byte)((src >> 4) & 0xF);

        [MethodImpl(Inline)]
        static byte TakeLo(byte src)        
            => (byte)(src & 0xF);

        /// <summary>
        /// Enables a bit if it is disabled
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void Enable(int pos)
            => data |= (byte)(1 << pos);

        /// <summary>
        /// Disables a bit if it is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public void Disable(int pos)
            => data &= (byte)~((byte)(1 << pos));

        /// <summary>
        /// Determines whether a bit is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public readonly bool Test(int pos)
            => (data & (1 << pos)) != 0;

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
        public BitVector4 Sll(int offset)
        {
            data <<= offset;
            return this;
        }

        /// <summary>
        /// Shifts the bits in the vector rightwards
        /// </summary>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public BitVector4 Srl(int offset)
        {
            data >>= offset;
            return this;
        }

        /// <summary>
        /// Counts the number of enabled bits in the vector
        /// </summary>
        [MethodImpl(Inline)]
        public uint Pop()
            => Bits.pop(data);

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public uint Nlz()
            => Bits.nlz((byte)(data << 4));

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public uint Ntz()
            => Bits.ntz(data);


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
        public BitVector4 Permute(Perm spec)
        {
            var src = Replicate();
            for(var i=0; i<Length; i++)
                this[i] = src[spec[i]];
            return this;
        }


        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline)]
        public BitVector4 Between(int first, int last)
            => BitVector.between(this,first,last);


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

        [MethodImpl(Inline)]
        public BitVector4 Negate()
        {
            data = TakeLo(math.negate(data));
            return this;
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
            => data.ToBitString().Truncate(4);

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

        public BitVector4 Inc()
        {
            if(data < 0xF)
                data++;
            else
                data = 0;
            return this;
        }

        public BitVector4 Dec()
        {
            if(data > 0)
                data--;
            else
                data = 0xF;
            return this;
        }

        [MethodImpl(Inline)]
        public BitVector4 XNor(BitVector4 y)
            => math.xnor(data, y.data);

        [MethodImpl(Inline)]
        public BitVector4 Nand(BitVector4 y)
            => math.nand(data, y.data);

        [MethodImpl(Inline)]
        public BitVector4 Nor(BitVector4 y)
            => math.nor(data, y.data);

        [MethodImpl(Inline)]
        public BitVector4 AndNot(BitVector4 y)
            => math.and(data, math.and(math.not(y) , (byte)0xF));

        [MethodImpl(Inline)]
        public bit GetBit(int pos)
            => Test(pos);

        [MethodImpl(Inline)]
        public void SetBit(int pos, bit value)
            => data = BitMask.set(ref data, (byte)pos, value);

        /// <summary>
        /// Gets the state of the first bit
        /// </summary>
        public bit b0001
        {
            [MethodImpl(Inline)]
            get => Test(0);
        }

        /// <summary>
        /// Gets the state of the second bit
        /// </summary>
        public bit b0010
        {
            [MethodImpl(Inline)]
            get => Test(1);
        }

        /// <summary>
        /// Gets the state of the third bit
        /// </summary>
        public bit b0100
        {
            [MethodImpl(Inline)]
            get => Test(2);
        }

        /// <summary>
        /// Gets the state of the fourth bit
        /// </summary>
        public bit b1000
        {
            [MethodImpl(Inline)]
            get => Test(3);
        }
    }
}