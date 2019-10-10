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
    using System.Numerics;

    using static zfunc;    
    using static Bits;

    [StructLayout(LayoutKind.Sequential, Size = 1)]
    public struct BitVector8 : IFixedScalarBits<BitVector8, byte>
    {
        internal byte data;

        public static readonly BitVector8 Zero = 0;

        public static readonly BitVector8 One = 1;

        public static readonly BitVector8 Ones = byte.MaxValue;
        
        public static readonly BitSize Width = 8;

        public static readonly BitPos FirstPos = 0;

        public static readonly BitPos LastPos = Width - 1;
        
        /// <summary>
        /// Allocates a zero-filled vector
        /// </summary>
        public static BitVector8 Alloc()
            => new BitVector8();


        [MethodImpl(Inline)]
        public static BitVector8 Parse(string src)
            =>  FromBitString(BitString.Parse(src));

        /// <summary>
        /// Creates a vector from the primal source value it represents
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 FromScalar(byte src)
            => new BitVector8(src);

        /// <summary>
        /// Creates a vector from the least 8 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 FromScalar(int src)
            => new BitVector8((byte)src);

        /// <summary>
        /// Creates a vector from the least 8 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 FromScalar(uint src)
            => new BitVector8((byte)src);

        /// <summary>
        /// Creates a vector from the least 8 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 FromScalar(ulong src)
            => new BitVector8((byte)src);

        /// <summary>
        /// Creates a vector from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector8 FromBitString(in BitString src)
            => src.TakeUInt8();    

        /// <summary>
        /// Enumerates each and every 8-bit bitvector exactly once
        /// </summary>
        public static IEnumerable<BitVector8> All
        {
           get
           {
                var bv = BitVector8.Zero;
                do            
                    yield return bv;            
                while(++bv);
           }
        }

        public static IEnumerable<BitVector8> Gray
        {
            get
            {
                foreach(var x in All)
                    yield return x ^ (x >> 1);
            }
        }

        /// <summary>
        /// Enumerates each and every nonmpty 8-bit bitvector exactly once
        /// </summary>
        public static IEnumerable<BitVector8> AllNonempty
        {
           get
           {
                var bv = BitVector8.One;
                do            
                    yield return bv;            
                while(++bv);
           }
        }

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N8,byte>(in BitVector8 src)
            => BitVector<N8,byte>.FromCells(src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitVector8(byte src)
            => new BitVector8(src);

        /// <summary>
        /// Converts the source vector to the underlying value it represents
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator byte(BitVector8 src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator BitVector16(BitVector8 src)
            => src.ToBitVector16();

        [MethodImpl(Inline)]
        public static implicit operator BitVector32(BitVector8 src)
            => src.ToBitVector32();

        [MethodImpl(Inline)]
        public static implicit operator BitVector64(BitVector8 src)
            => src.ToBitVector64();

        /// <summary>
        /// <summary>
        /// Computes the component-wise AND of the operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator &(BitVector8 x, BitVector8 y)
            => bitvector.and(x,y);

        /// <summary>
        /// Computes the bitwise OR of the source operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator |(BitVector8 x, BitVector8 y)
            => bitvector.or(x,y);

        /// Computes the XOR of the source operands. 
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator ^(BitVector8 x, BitVector8 y)
            => bitvector.xor(x,y);

        /// <summary>
        /// Left-shifts the bits in the source
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator <<(BitVector8 x, int offset)
            => bitvector.sll(x,offset);

        /// <summary>
        /// Right-shifts the bits in the source
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator >>(BitVector8 x, int offset)
            => bitvector.srl(x,offset);

        /// <summary>
        /// Computes the one's complement of the operand. 
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator ~(BitVector8 src)
            => bitvector.flip(src);

        /// <summary>
        /// Computes the two's complement of the operand
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator -(in BitVector8 src)
            => bitvector.negate(src);


        /// <summary>
        /// Computes the arithmetic sum of the source operands. 
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator +(BitVector8 x, BitVector8 y)
            => bitvector.add(x,y);

        /// <summary>
        /// Computes the product of the operands. 
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator *(BitVector8 x, BitVector8 y)
            => bitvector.mul(x,y);

        /// <summary>
        /// Subtracts the second operand from the first. 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator - (BitVector8 x, BitVector8 y)
            => bitvector.sub(x,y);

        /// <summary>
        /// Raises a vector b to a power n where n >= 0
        /// </summary>
        /// <param name="b">The base vector</param>
        /// <param name="n">The power</param>
        [MethodImpl(Inline)]        
        public static BitVector8 operator ^(BitVector8 b, int n)
            => bitvector.pow(b,n);

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit operator %(BitVector8 x, BitVector8 y)
            => bitvector.dot(x,y);

        [MethodImpl(Inline)]
        public static BitVector8 operator ++(BitVector8 src)
            => bitvector.inc(src);

        [MethodImpl(Inline)]
        public static BitVector8 operator --(BitVector8 src)
            => bitvector.dec(src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(BitVector8 src)
            => src.Nonempty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(BitVector8 src)
            => !src.Nonempty;

        /// <summary>
        /// Computes the operand's logical negation: if x = 0 then 1 else 0
        /// </summary>
        /// <param name="src">The ource operand</param>
        [MethodImpl(Inline)]
        public static Bit operator !(BitVector8 src)
            => src.Empty;

        [MethodImpl(Inline)]
        public static bool operator ==(BitVector8 x, BitVector8 y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(BitVector8 x, BitVector8 y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public static Bit operator <(BitVector8 x, BitVector8 y)
            => x.data < y.data ? Bit.On : Bit.Off;

        [MethodImpl(Inline)]
        public static Bit operator >(BitVector8 x, BitVector8 y)
            => x.data > y.data ? Bit.On : Bit.Off;

        [MethodImpl(Inline)]
        public static Bit operator <=(BitVector8 x, BitVector8 y)
            => x.data <= y.data ? Bit.On : Bit.Off;

        [MethodImpl(Inline)]
        public static Bit operator >=(BitVector8 x, BitVector8 y)
            => x.data >= y.data ? Bit.On : Bit.Off;

        [MethodImpl(Inline)]
        public BitVector8(byte src)
            : this()
                => this.data = src;        

        /// <summary>
        /// Assigns the bitvector a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public void assign(byte src)
            => this.data = src;
        
        public Bit this[BitPos pos]
        {
            [MethodImpl(Inline)]
            get => Get(pos);
            
            [MethodImpl(Inline)]
            set => Set(pos,value);
        }


        /// <summary>
        /// The vector's 4 most significant bits
        /// </summary>
        public readonly BitVector4 Hi
        {
            [MethodImpl(Inline)]
            get => hi(data);        

        }        

        /// <summary>
        /// Presents bitvector content as a bytespan
        /// </summary>
        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(data);
        }

        [MethodImpl(Inline)]
        public ref byte Byte(int index)
            => ref Bytes[0];

        [MethodImpl(Inline)]
        public static ref byte AsBytes(ref BitVector8 src)
            => ref src.data;

        public BitVector8 this[Range range]
        {
            [MethodImpl(Inline)]
            get => Between(range.Start.Value, range.End.Value);
        }

        /// <summary>
        /// Selects a contiguous range of bits
        /// </summary>
        /// <param name="first">The position of the first bit</param>
        /// <param name="last">The position of the last bit</param>
        public BitVector8 this[BitPos first, BitPos last]
        {
            [MethodImpl(Inline)]
            get => Between(first, last);
        }


        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline)]
        public BitVector8 Between(BitPos first, BitPos last)
            => Bits.between(data, first, last);

        /// <summary>
        /// Populates a target vector with mask-identified source bits
        /// </summary>
        /// <param name="spec">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        [MethodImpl(Inline)]
        public BitVector8 Gather(BitVector8 spec)
            => Bits.gather(data, spec);

        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public readonly Bit Dot(BitVector8 y)
            => bitvector.dot(this,y);

        /// <summary>
        /// The number of bits represented by the vector
        /// </summary>
        public readonly BitSize Length
        {
            [MethodImpl(Inline)]
            get => 8;
        }        

        /// <summary>
        /// The maximum number of bits that can be represented
        /// </summary>
        public readonly BitSize Capacity
        {
            [MethodImpl]
            get => Length;
        }

        /// <summary>
        /// Computes the least number of bits required to represent vector content
        /// </summary>
        public int MinWidth
        {
            [MethodImpl(Inline)]
            get => Bits.width(data);
        }

        /// <summary>
        /// Computes in-place the bitwise AND of the source vector and another,
        /// returning the result to the caller
        /// </summary>
        /// <param name="y">The other vector</param>
        [MethodImpl(Inline)]
        public BitVector8 And(BitVector8 y)
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
        public BitVector8 Or(BitVector8 y)
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
        public BitVector8 XOr(BitVector8 y)
        {
            data ^= y.data;
            return this;
        }

        /// <summary>
        /// Computes in-place the bitwise complement of the source vector,
        /// returning the result to the caller
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector8 Flip()
        {
            data = math.flip(data);
            return this;
        }

        /// <summary>
        /// Computes the in-place arithmetic difference between the source vector and another
        /// </summary>
        /// <param name="y">The vector to subtract from the source</param>
        [MethodImpl(Inline)]
        public BitVector8 Sub(BitVector8 y)
        {
            bitvector.sub(ref this, y);
            return this;
        }


        /// <summary>
        /// Enables a bit if it is disabled
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void Enable(BitPos pos)
            => BitMask.enable(ref data, pos);

        /// <summary>
        /// Disables a bit if it is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public void Disable(BitPos pos)
            => BitMask.disable(ref data, pos);

        /// <summary>
        /// Disables the high bits that follow a specified bit
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public void DisableAfter(BitPos pos)
            => Bits.bzhi(ref data, ++pos);

        /// <summary>
        /// Sets a bit value
        /// </summary>
        /// <param name="pos">The position of the bit to set</param>
        /// <param name="value">The bit value</param>
        [MethodImpl(Inline)]
        public void Set(BitPos pos, Bit value)
            => BitMask.set(ref data, pos, value);

        /// <summary>
        /// Determines whether a bit is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public readonly bool Test(BitPos pos)
            => BitMask.test(data, pos);

        /// <summary>
        /// Reads a bit value
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public readonly Bit Get(BitPos pos)
            => Test(pos);

        /// <summary>
        /// Shifts the bits in the vector leftwards
        /// </summary>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public BitVector8 Sll(int offset)
        {
            data <<= offset;
            return this;
        }

        /// <summary>
        /// Shifts the bits in the vector rightwards
        /// </summary>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public BitVector8 Srl(int offset)
        {
            data >>= offset;
            return this;
        }

        /// <summary>
        /// Increments the vector arithmetically
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public BitVector8 Inc()
        {
            bitvector.inc(ref this);
            return this;
        }

        /// <summary>
        /// Decrements the vector arithmetically
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public BitVector8 Dec()
        {
            bitvector.dec(ref this);
            return this;
        }

        /// <summary>
        /// Rotates bits in the source rightwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector8 Ror(uint offset)
            => Bits.rotr(ref data, (byte)offset);

        /// <summary>
        /// Rotates bits in the source leftwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector8 Rol(uint offset)
            => Bits.rotl(ref data, (byte)offset);

        /// <summary>
        /// Counts the number of enabled bits in the vector
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitSize Pop()
            => Bits.pop(data);

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitSize Nlz()
            => Bits.nlz(data);

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitSize Ntz()
            => Bits.ntz(data);

        /// <summary>
        /// Counts the number of bits set up to and including the specified position
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit for which rank will be calculated</param>
        [MethodImpl(Inline)]
        public uint Rank(BitPos pos)
            => Bits.rank(data,pos);

        /// <summary>
        /// Raises the vector to a power
        /// </summary>
        /// <param name="n">The power</param>
        public BitVector8 Pow(int n)
        {
            data = bitvector.pow(this,n);
            return this;
        }

        /// <summary>
        /// Computes the smallest integer n > 1 such that v^n = identity
        /// </summary>
        [MethodImpl(Inline)]
        public int Order()
            => bitvector.ord(this);

        [MethodImpl(Inline)]
        public BitVector8 Mul(BitVector8 y)
        {
            bitvector.mul(ref this, y);
            return this;
        }

        [MethodImpl(Inline)]
        public BitVector8 AndNot(in BitVector8 y)
            => Bits.andn((byte)this, (byte)y);

        [MethodImpl(Inline)]
        public readonly bool AllOnes()
            => (0xFF & data) == 0xFF;


        [MethodImpl(Inline)]
        public readonly BitString ToBitString(int? maxlen = null)
            => maxlen == null ? data.ToBitString() : data.ToBitString().Truncate(maxlen.Value);

        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline)]
        public BitVector8 Lsb(int n)                
            => Between(0, n - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public BitVector8 Msb(int n)                
            => Between(LastPos - n, LastPos);                

        /// <summary>
        /// Reverses the vector's bits
        /// </summary>
        [MethodImpl(Inline)]
        public void Reverse()        
            => data = Bits.rev(data);

        /// <summary>
        /// Rearranges the vector in-place as specified by a permutation
        /// </summary>
        /// <param name="spec">The permutation</param>
        [MethodImpl(Inline)]
        public BitVector8 Permute(Perm spec)
        {
            var src = Replicate();
            for(var i=0; i<Length; i++)
                this[i] = src[spec[i]];
            return this;
        }

        /// <summary>
        /// Returns true if no bits are enabled, false otherwise
        /// </summary>
        public readonly bool Empty
        {
            [MethodImpl(Inline)]
            get => data == 0;
        }

        /// <summary>
        /// Returns true if the vector has at least one enabled bit; false otherwise
        /// </summary>
        public readonly bool Nonempty
        {
            [MethodImpl(Inline)]
            get => !Empty;
        }

        /// <summary>
        /// Returns a copy of the vector
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector8 Replicate()
            => new BitVector8(data);

        /// <summary>
        /// Applies a permutation to a replicated vector
        /// </summary>
        /// <param name="p">The permutation</param>
        [MethodImpl(Inline)]
        public BitVector8 Replicate(Perm p)
        {
            var dst = Replicate();
            dst.Permute(p);
            return dst;
        }

        /// <summary>
        /// Creates a new vector via concatenation
        /// </summary>
        /// <param name="tail">The lower bits of the new vector</param>
        [MethodImpl(Inline)]
        public BitVector16 Concat(BitVector8 tail)
            => BitVector16.FromScalars(tail.data, data);

        /// <summary>
        /// Extracts the scalar represented by the vector
        /// </summary>
        public byte Scalar
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// Returns the vector's bitstring representation
        /// </summary>
        [MethodImpl(Inline)]
        public BitString ToBitString()
            => data.ToBitString();

        /// <summary>
        /// Converts the source to a 32-bit vector
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector16 ToBitVector16()
            => BitVector16.FromScalar(data);

        /// <summary>
        /// Converts the source to a 32-bit vector
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector32 ToBitVector32()
            => BitVector32.FromScalar(data);

        /// <summary>
        /// Converts the source to a 64-bit vector
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector64 ToBitVector64()
            => BitVector64.FromScalar(data);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="tlz">True if leadzing zeros should be trimmed, false otherwise</param>
        /// <param name="specifier">True if the prefix specifier '0b' should be prepended</param>
        /// <param name="blockWidth">The width of the blocks, if any</param>
        [MethodImpl(Inline)]
        public string Format(bool tlz = false, bool specifier = false, int? blockWidth = null)
            => ToBitString().Format(tlz, specifier, blockWidth);

        [MethodImpl(Inline)]
        public readonly bool Equals(BitVector8 y)
            => data == y.data;

        public override bool Equals(object obj)
            => obj is BitVector8 x ? Equals(x) : false;
        
        public override int GetHashCode()
            => data.GetHashCode();
        
        public override string ToString()
            => Format();

    }
}