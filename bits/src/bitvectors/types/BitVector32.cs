//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;    

    /// <summary>
    /// Defines a 32-bit bitvector
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public struct BitVector32 : IPrimalBitVector<BitVector32,uint>
    {
        internal uint data;

        public static readonly BitVector32 Zero = default;

        public static readonly BitVector32 One = 1;

        public static readonly BitVector32 Ones = uint.MaxValue;

        public static readonly BitSize Width = 32;

        public static readonly BitPos FirstPos = 0;

        public static readonly BitPos LastPos = Width - 1;

        /// <summary>
        /// Allocates a zero-filled vector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector32 Alloc()
            => new BitVector32(0);


        /// <summary>
        /// Creates a vector from an usigned 32-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 FromScalar(uint src)
            => new BitVector32(src);    

        /// <summary>
        /// Creates a vector from a signed 32-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 FromScalar(int src)
            => new BitVector32((uint)src);    

        /// <summary>
        /// Creates a vector from the least 32 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 FromScalar(ulong src)
            => new BitVector32((uint)src);    

        /// <summary>
        /// Creates a vector from four unsigned 8-bit integers
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 FromScalars(byte x0, byte x1, byte x2, byte x3)
            => BitConverter.ToUInt32(new byte[]{x0, x1, x2, x3},0);

        /// <summary>
        /// Creates a vector from two unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector32 FromScalars(ushort lo, ushort hi)
            => FromScalar((uint)hi << 16 | (uint)lo);

        /// <summary>
        /// Creates a vector from a bit parameter array
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector32 FromBits(params Bit[] src)
            => new BitVector32(src);

        /// <summary>
        /// Creates a vector from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector32 FromBitString(in BitString src)        
            => src.TakeUInt32();

        public static BitVector32 Parse(string src)
        {
            var bs = BitString.Parse(src);
            var len = math.min(bs.Length, Width);
            Bits.packseq(bs.BitSeq, out uint dst);
            return dst;
        }
    
        /// <summary>
        /// Enumerates all 32-bit bitvectors whose width is less than or equal to a specified maximum
        /// </summary>
        public static IEnumerable<BitVector32> All(int maxwidth)
        {
            var maxval = Pow2.pow(maxwidth);
            var bv = BitVector32.Zero;
            while(bv < maxval)
                yield return bv++;            
        }

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N32,uint>(BitVector32 src)
            => BitVector<N32,uint>.FromCells(src.data);


        [MethodImpl(Inline)]
        public static implicit operator BitVector64(BitVector32 src)
            => src.Expand();

        [MethodImpl(Inline)]
        public static explicit operator BitVector4(BitVector32 src)
            => BitVector4.FromScalar((byte)src.data);

        [MethodImpl(Inline)]
        public static explicit operator BitVector8(BitVector32 src)
            => BitVector8.FromScalar((byte)src.data);

        [MethodImpl(Inline)]
        public static explicit operator BitVector16(BitVector32 src)
            => BitVector16.FromScalar((ushort)src.data);

        [MethodImpl(Inline)]
        public static implicit operator uint(BitVector32 src)
            => src.data;        

        /// <summary>
        /// Implicitly converts a scalar value to a 32-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector32(byte src)
            => FromScalar(src);

        /// <summary>
        /// Implicitly converts a scalar value to a 32-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector32(ushort src)
            => FromScalar(src);

        /// <summary>
        /// Implicitly converts a scalar value to a 32-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator BitVector32(uint src)
            => new BitVector32(src);

        /// <summary>
        /// Computes the bitwise XOR of the source operands
        /// Note that the XOR operator is equivalent to the (+) operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator ^(in BitVector32 x, in BitVector32 y)
            => bitvector.xor(x,y);

        /// <summary>
        /// Computes the bitwise AND of the source operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator &(in BitVector32 x, in BitVector32 y)
            => bitvector.and(x,y);

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit operator %(in BitVector32 x, in BitVector32 y)
            => bitvector.dot(x,y);

        /// <summary>
        /// Computes the bitwise OR of the source operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator |(in BitVector32 x, in BitVector32 y)
            => bitvector.or(x,y);

        /// <summary>
        /// Computes the bitwise complement of the operand. 
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator ~(BitVector32 src)
            => bitvector.flip(src);

        /// <summary>
        /// Computes the arithmetic sum of the source operands. 
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator +(BitVector32 x, BitVector32 y)
            => bitvector.add(x,y);

        /// <summary>
        /// Arithmetically increments the source vector 
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator ++(BitVector32 src)
            => bitvector.inc(src);

        /// <summary>
        /// Arithmetically decrements the source vector 
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator --(BitVector32 src)
            => bitvector.dec(src);

        /// <summary>
        /// Subtracts the second operand from the first. 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator - (BitVector32 x, BitVector32 y)
            => bitvector.sub(x,y);

        /// <summary>
        /// Negates the operand. Note that this operator is equivalent to the 
        /// complement operator (~)
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator -(BitVector32 src)
            => bitvector.negate(src);

        /// <summary>
        /// Left-shifts the bits in the source
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator <<(BitVector32 x, int offset)
            => bitvector.sll(x,offset);

        /// <summary>
        /// Right-shifts the bits in the source
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator >>(BitVector32 x, int offset)
            => bitvector.srl(x,offset);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(BitVector32 src)
            => src.Nonempty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(BitVector32 src)
            => !src.Nonempty;

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector32 x, in BitVector32 y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector32 x, in BitVector32 y)
            => !x.Equals(y);

        /// <summary>
        /// Initializes the vector with the source value it represents
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public BitVector32(uint src)
            : this() => this.data = src;

        /// <summary>
        /// Initializes a vector with a sequence of bit values that is clamped to 32 bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public BitVector32(in Bit[] src)
            : this()
        {
            this.data = 0;
            for(var i = 0; i< Math.Min(32, src.Length); i++)
                if(src[i])
                    BitMask.enable(ref data, i);
        }

        /// <summary>
        /// Presents vector content as a span of bytes
        /// </summary>
        [MethodImpl(Inline)]
        public Span<byte> AsBytes()
            => bytespan(ref data);

        /// <summary>
        /// Presents vector content as a parametric primal scalar
        /// </summary>
        /// <typeparam name="S">The primal scalar type</typeparam>
        [MethodImpl(Inline)]
        public S AsScalar<S>()
            where S : unmanaged
                => As.generic<S>(data);

        /// <summary>
        /// Assigns the bitvector a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public void assign(uint src)
            => this.data = src;

        /// <summary>
        /// Queries/Manipulates index-identified bits
        /// </summary>
        public Bit this[BitPos pos]
        {
            [MethodImpl(Inline)]
            get => Get(pos);
            
            [MethodImpl(Inline)]
            set => Set(pos, value);
       }

        public BitVector32 this[Range range]
        {
            [MethodImpl(Inline)]
            get => Between(range.Start.Value, range.End.Value);
        }

        /// <summary>
        /// Selects a contiguous range of bits
        /// </summary>
        /// <param name="first">The position of the first bit</param>
        /// <param name="last">The position of the last bit</param>
        public BitVector32 this[BitPos first, BitPos last]
        {
            [MethodImpl(Inline)]
            get => Between(first, last);
        }

        public BitVector16 Lo
        {
            [MethodImpl(Inline)]
            get => Bits.split(data).x0;            
        }

        public BitVector16 Hi
        {
            [MethodImpl(Inline)]
            get => Bits.split(data).x1;

        }
        
        /// <summary>
        /// Zero-extends the vector to a vector that accomondates
        /// the next power of 2
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector64 Expand()
            => BitVector64.FromScalar(data);

        /// <summary>
        /// Presents bitvector content as a bytespan
        /// </summary>
        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(data);
        }

        /// <summary>
        /// Selects an index-identified byte where index = 0 | 1 | 2 | 3
        /// </summary>
        /// <param name="index">The 0-based byte-relative position</param>
        [MethodImpl(Inline)]
        public ref byte Byte(int index)        
            => ref Bytes[index];

        /// <summary>
        /// The number of bits represented by the vector
        /// </summary>
        public readonly BitSize Length
        {
            [MethodImpl(Inline)]
            get => Width;
        }

        /// <summary>
        /// The maximum number of bits that can be represented
        /// </summary>
        public readonly BitSize Capacity
        {
            [MethodImpl(Inline)]
            get => Length;
        }

        /// <summary>
        /// Computes the least number of bits required to represent vector content
        /// </summary>
        public int MinWidth
        {
            [MethodImpl(Inline)]
            get => Bits.width(in data);
        }

        /// <summary>
        /// Computes in-place the bitwise AND of the source vector and another,
        /// returning the result to the caller
        /// </summary>
        /// <param name="y">The other vector</param>
        [MethodImpl(Inline)]
        public BitVector32 And(BitVector32 y)
        {
            data &= y.data;
            return this;
        }

        [MethodImpl(Inline)]
        public BitVector32 Nand(BitVector32 y)
        {
            data = math.nand(data,y.data);
            return this;
        }

        /// <summary>
        /// Computes in-place the bitwise OR of the source vector and another,
        /// returning the result to the caller
        /// </summary>
        /// <param name="y">The other vector</param>
        [MethodImpl(Inline)]
        public BitVector32 Or(BitVector32 y)
        {
            data |= y.data;
            return this;
        }

        [MethodImpl(Inline)]
        public BitVector32 Nor(BitVector32 y)
        {
            data = math.nor(data,y.data);
            return this;
        }

        /// <summary>
        /// Computes in-place the bitwise XOR of the source vector and another,
        /// returning the result to the caller
        /// </summary>
        /// <param name="y">The other vector</param>
        [MethodImpl(Inline)]
        public BitVector32 XOr(BitVector32 y)
        {
            data ^= y.data;
            return this;
        }

        [MethodImpl(Inline)]
        public BitVector32 XNor(BitVector32 y)
        {
            data = math.xnor(data,y.data);
            return this;
        }

        [MethodImpl(Inline)]
        public BitVector32 Select(BitVector32 y, BitVector32 z)
        {
            data = math.select(data,y.data,z.data);
            return this;
        }

        /// <summary>
        /// Computes in-place the bitwise complement of the source vector,
        /// returning the result to the caller
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector32 Not()
        {
            data = ~data;
            return this;
        }

        [MethodImpl(Inline)]
        public BitVector32 Negate()
        {
            data = math.negate(data);
            return this;
        }

        /// <summary>
        /// Increments the vector arithmetically
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public BitVector32 Inc()
        {
            data++;
            return this;
        }

        /// <summary>
        /// Decrements the vector arithmetically
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public BitVector32 Dec()
        {
            data--;
            return this;
        }

        /// <summary>
        /// Computes the in-place arithmetic difference between the source vector and another
        /// </summary>
        /// <param name="y">The vector to subtract from the source</param>
        [MethodImpl(Inline)]
        public BitVector32 Sub(BitVector32 y)
        {
            data -= y.data;
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
            => BitMask.test(in data, pos);

        /// <summary>
        /// Reads a bit value
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public readonly Bit Get(BitPos pos)
            => Test(pos);

        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline)]
        public readonly BitVector32 Between(BitPos first, BitPos last)
            => Bits.between(in data, first,last);

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
        public BitVector32 Permute(Perm spec)
            => bitvector.perm(ref this, spec);
            
        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline)]
        public BitVector32 Lsb(int n)                
            => Between(0, n - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public BitVector32 Msb(int n)                
            => Between(LastPos - n, LastPos);                

        /// <summary>
        /// Shifts the bits in the vector leftwards
        /// </summary>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public BitVector32 Sll(int offset)
        {
            data <<= offset;
            return this;
        }

        /// <summary>
        /// Shifts the bits in the vector rightwards
        /// </summary>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public BitVector32 Srl(int offset)
        {
            data >>= offset;
            return this;
        }

        /// <summary>
        /// Rotates bits in the source rightwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector32 Rotr(int offset)
        {
            data = Bits.rotr(data,offset);
            return this;
        }

        /// <summary>
        /// Rotates bits in the source leftwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector32 Rotl(int offset)
        {
            data = Bits.rotl(data,offset);
            return this;
        }

        /// <summary>
        /// Counts the number of enabled bits in the source
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitSize Pop()
            => Bits.pop(data);
        
        /// <summary>
        /// Counts the number of leading zeros
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitSize Nlz()
            => Bits.nlz(data);

        /// <summary>
        /// Counts the number of trailing zeros
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
        public readonly uint Rank(BitPos pos)
            => Bits.rank(data,pos);

        /// <summary>
        /// Computes the bitwise and of the vector the complement of the right operand
        /// </summary>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public BitVector32 AndNot(BitVector32 y)
        {
            data = Bits.andnot(data, y.data);            
            return this;
        }        

        [MethodImpl(Inline)]
        public readonly bool AllOnes()
            => (UInt32.MaxValue & data) == UInt32.MaxValue;

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
        /// Extracts mask-identified source bits
        /// </summary>
        /// <param name="spec">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        [MethodImpl(Inline)]
        public readonly BitVector32 Gather(BitVector32 spec)
            => Bits.gather(data, spec);

        /// <summary>
        /// Extracts mask-identified source bits
        /// </summary>
        /// <param name="spec">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        [MethodImpl(Inline)]
        public readonly BitVector16 Gather(BitVector16 spec)        
            => (ushort)Bits.gather(data, (ushort)spec);
        
        /// <summary>
        /// Extracts mask-identified source bits
        /// </summary>
        /// <param name="spec">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        [MethodImpl(Inline)]
        public readonly BitVector8 Gather(BitVector8 spec)
            => (byte)Bits.gather(data, (byte)spec);

        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public readonly Bit Dot(BitVector32 y)
            => bitvector.dot(this,y);


        [MethodImpl(Inline)]
        public readonly BitString ToBitString()
            => data.ToBitString();

        /// <summary>
        /// Extracts the scalar represented by the vector
        /// </summary>
        public readonly uint Scalar
        {
            [MethodImpl(Inline)]
            get => data;
        }

        [MethodImpl(Inline)]
        public T ToScalar<T>()
            where T : unmanaged
                => Unsafe.As<uint,T>(ref data);


        /// <summary>
        /// Applies a truncating reduction Bv32 -> Bv8
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector8 ToBitVector8()
            => BitVector8.FromScalar(data);

        /// <summary>
        /// Applies a truncating reduction Bv32 -> Bv16
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector16 ToBitVector16()
            => BitVector16.FromScalar(data);

        /// <summary>
        /// Applies the identity conversion Bv32 -> Bv32
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector32 ToBitVector32()
            => BitVector32.FromScalar(data);

        /// <summary>
        /// Applies a widening conversion Bv16 -> Bv64
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector64 ToBitVector64()
            => BitVector64.FromScalar(data);

        /// <summary>
        /// Returns a copy of the vector
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitVector32 Replicate()
            => new BitVector32(data);

        /// <summary>
        /// Applies a permutation to a replicated vector
        /// </summary>
        /// <param name="p">The permutation</param>
        [MethodImpl(Inline)]
        public readonly BitVector32 Replicate(Perm p)
        {
            var dst = Replicate();
            dst.Permute(p);
            return dst;
        }

        [MethodImpl(Inline)]
        public BitVector64 Concat(BitVector32 tail)
            => BitVector64.FromScalars(tail.data, data);

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
        public bool Equals(BitVector32 y)
            => data == y.data;

        public override bool Equals(object obj)
            => obj is BitVector32 x ? Equals(x) : false;
        
        public override int GetHashCode()
            => data.GetHashCode();
 
        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        static BitVector32 FromParts(in byte x0, in byte x1, in byte x2, in byte x3)
            => BitConverter.ToUInt32(array(x0, x1, x2, x3), 0);

        [MethodImpl(Inline)]
        Bit DotRef(BitVector32 y)
        {
            var result = Bit.Off;
            for(var i=0; i<Length; i++)
                result ^= this[i] & y[i];
            return result;
        }

    }
}