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
    using System.Numerics;

    using static zfunc;    

    /// <summary>
    /// Defines a 64-bit bitvector
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size = 8)]
    public struct BitVector64 : IPrimalBitVector<BitVector64,ulong>
    {    
        internal ulong data;

        public static readonly BitVector64 Zero = default;

        public static readonly BitVector64 One = 1;

        public static readonly BitVector64 Ones = ulong.MaxValue;

        public static readonly BitSize Width = 64;

        public static readonly BitPos LastPos = Width - 1;

        /// <summary>
        /// Allocates a new empty vector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector64 Alloc()
            => new BitVector64(0);


        /// <summary>
        /// Creates a vector from a primal source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 FromScalar(byte src)
            => new BitVector64(src);    

        /// <summary>
        /// Creates a vector from a primal source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 FromScalar(ushort src)
            => new BitVector64(src);    

        /// <summary>
        /// Creates a vector from a primal source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 FromScalar(uint src)
            => new BitVector64(src);    

        /// <summary>
        /// Creates a vector from a primal source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 FromScalar(ulong src)
            => new BitVector64(src);    

        /// <summary>
        /// Creates a vector from two unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector64 FromScalars(uint lo, uint hi)
            => FromScalar((ulong)hi << 32 | (ulong)lo);

        /// <summary>
        /// Creates a vector from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector64 FromBitString(BitString src)
            => src.TakeUInt64();

        /// <summary>
        /// Parses a bitvector from a 0-1 string
        /// </summary>
        /// <param name="src">The source text</param>
        public static BitVector64 Parse(string src)
        {
            var bs = BitString.Parse(src);
            var len = math.min(bs.Length, Width);
            Bits.packseq(bs.BitSeq, out ulong dst);
            return dst;
        }

        /// <summary>
        /// Enumerates all 32-bit bitvectors whose width is less than or equal to a specified maximum
        /// </summary>
        public static IEnumerable<BitVector64> All(int maxwidth)
        {
            var maxval = Pow2.pow(maxwidth);
            var bv = BitVector64.Zero;
            while(bv < maxval)
                yield return bv++;            
        }

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N64,ulong>(in BitVector64 src)
            => BitVector<N64,ulong>.FromCells(src.data);

        /// <summary>
        /// Implicitly converts an unsigned 64-bit integer to a 64-bit bitvector
        /// </summary>
        /// <param name="src">The source integer</param>
        [MethodImpl(Inline)]
        public static implicit operator BitVector64(ulong src)
            => new BitVector64(src);

        /// <summary>
        /// Implicitly converts a bitvector to a 64-bit unsigned integer
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator ulong(BitVector64 src)
            => src.data;        

        /// <summary>
        /// Explicitly converts a a 64-bit bitvector to an 8-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static explicit operator BitVector4(BitVector64 src)
            => BitVector4.FromScalar((byte)src.data);        

        /// <summary>
        /// Explicitly converts a a 64-bit bitvector to an 8-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static explicit operator BitVector8(BitVector64 src)
            => BitVector8.FromScalar((byte)src.data);        

        /// <summary>
        /// Explicitly converts a a 64-bit bitvector to a 16-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static explicit operator BitVector16(BitVector64 src)
            => BitVector16.FromScalar((ushort)src.data);        

        /// <summary>
        /// Explicitly converts a a 64-bit bitvector to a 32-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static explicit operator BitVector32(BitVector64 src)
            => BitVector32.FromScalar((uint)src.data);        

        /// <summary>
        /// Implicitly converts a scalar value to a 64-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector64(byte src)
            => FromScalar(src);

        /// <summary>
        /// Implicitly converts a scalar value to a 64-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector64(ushort src)
            => FromScalar(src);

        /// <summary>
        /// Implicitly converts a scalar value to a 64-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector64(uint src)
            => FromScalar(src);

        /// <summary>
        /// Computes the bitwise XOR of the source operands
        /// Note that the XOR operator is equivalent to the (+) operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator ^(BitVector64 x, BitVector64 y)
            => bitvector.xor(x,y);
        /// <summary>
        /// Computes the bitwise AND of the source operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator &(BitVector64 x, BitVector64 y)
            => bitvector.and(x,y);

        /// <summary>
        /// Computes the bitwise OR of the source operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator |(BitVector64 x, BitVector64 y)
            => bitvector.or(x,y);

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit operator %(in BitVector64 x, in BitVector64 y)
            => bitvector.dot(x,y);

        /// <summary>
        /// Computes the arithmetic sum of the source operands. 
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator +(BitVector64 x, BitVector64 y)
            => bitvector.add(x,y);

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator ~(BitVector64 src)
            => bitvector.not(src);

        /// <summary>
        /// Negates the operand via two's complement
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator -(BitVector64 src)
            => bitvector.negate(src);

        /// <summary>
        /// Arithmetically subtracts the second operand from the first. 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator - (BitVector64 x, BitVector64 y)
            => bitvector.sub(x,y);

        /// <summary>
        /// Shifts the source bits leftwards
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator <<(BitVector64 x, int offset)
            => bitvector.sll(x,offset);

        /// <summary>
        /// Shifts the source bits rightwards
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator >>(BitVector64 x, int offset)
            => bitvector.srl(x,offset);

        /// <summary>
        /// Increments the vector arithmetically
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator ++(BitVector64 src)
            => bitvector.inc(src);

        /// <summary>
        /// Decrements the vector arithmetically
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator --(BitVector64 src)
            => bitvector.dec(src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(BitVector64 src)
            => src.Nonempty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(BitVector64 src)
            => !src.Nonempty;

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector64 x, in BitVector64 y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector64 x, in BitVector64 y)
            => !x.Equals(y);

        /// <summary>
        /// Initializes a vector with the primal source value it represents
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public BitVector64(in ulong data)
            : this() => this.data = data;

        /// <summary>
        /// Assigns the bitvector a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public void assign(ulong src)
            => this.data = src;

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
        /// Reads/Manipulates a source bit at a specified position
        /// </summary>
        public Bit this[BitPos pos]
        {
            [MethodImpl(Inline)]
            get => Get(pos);
            
            [MethodImpl(Inline)]
            set => Set(pos,value);
       }

        /// <summary>
        /// Selects an inclusive range of bits
        /// </summary>
        public BitVector64 this[Range range]
        {
            [MethodImpl(Inline)]
            get => Between(range.Start.Value, range.End.Value);
        }

        /// <summary>
        /// Selects a contiguous range of bits
        /// </summary>
        /// <param name="first">The position of the first bit</param>
        /// <param name="last">The position of the last bit</param>
        public BitVector64 this[BitPos first, BitPos last]
        {
            [MethodImpl(Inline)]
            get => Between(first, last);
        }

        /// <summary>
        /// The vector's 32 least significant bits
        /// </summary>
        public readonly BitVector32 Lo
        {
            [MethodImpl(Inline)]
            get => BitVector32.FromScalar((uint)data);
        }

        /// <summary>
        /// The vector's 32 most significant bits
        /// </summary>
        public readonly BitVector32 Hi
        {
            [MethodImpl(Inline)]
            get => BitVector32.FromScalar((uint)(data >> 32));
        }        

        /// <summary>
        /// The actual number of bits represented by the vector
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
        /// Presents bitvector content as a bytespan
        /// </summary>
        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(data);
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
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline)]
        public readonly BitVector64 Between(BitPos first, BitPos last)
            => Bits.between(in data, first, last);

        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public readonly Bit Dot(BitVector64 y)
            => bitvector.dot(this,y);

        /// <summary>
        /// Selects an index-identified byte where index = 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7
        /// </summary>
        /// <param name="index">The 0-based byte-relative position</param>
        [MethodImpl(Inline)]
        public ref byte Byte(int index)        
            => ref Bytes[index];

        /// <summary>
        /// Gets the value of an index-identified bit
        /// </summary>
        /// <param name="pos">The bit index</param>
        [MethodImpl(Inline)]
        public bit GetBit(BitPos pos)
            => this[pos] == true;

        /// <summary>
        /// Sets the state of an index-identified bit
        /// </summary>
        /// <param name="pos">The bit index</param>
        /// <param name="value">The bit value</param>
        [MethodImpl(Inline)]
        public void SetBit(BitPos pos, bit value)
            => this[pos] = value == true;

        /// <summary>
        /// Computes in-place the bitwise AND of the source vector and another,
        /// returning the result to the caller
        /// </summary>
        /// <param name="y">The other vector</param>
        [MethodImpl(Inline)]
        public BitVector64 And(BitVector64 y)
        {
            data &= y.data;
            return this;
        }

        /// <summary>
        /// Computes in-place the bitwise NAND of the source vector and another and returns the result to the caller
        /// </summary>
        /// <param name="y">The other vector</param>
        [MethodImpl(Inline)]
        public BitVector64 Nand(BitVector64 y)
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
        public BitVector64 Or(BitVector64 y)
        {
            data |= y.data;
            return this;
        }

        /// <summary>
        /// Computes in-place the bitwise NOR of the source vector and another and returns the result to the caller
        /// </summary>
        /// <param name="y">The other vector</param>
        [MethodImpl(Inline)]
        public BitVector64 Nor(BitVector64 y)
        {
            data = math.nor(data,y.data);
            return this;
        }

        /// <summary>
        /// Computes in-place the bitwise XOR of the source vector and another and returns the result to the caller
        /// </summary>
        /// <param name="y">The other vector</param>
        [MethodImpl(Inline)]
        public BitVector64 XOr(BitVector64 y)
        {
            data ^= y.data;
            return this;
        }

        /// <summary>
        /// Computes in-place the bitwise XNOR of the source vector and another and returns the result to the caller
        /// </summary>
        /// <param name="y">The other vector</param>
        [MethodImpl(Inline)]
        public BitVector64 XNor(BitVector64 y)
        {
            data = math.xnor(data,y.data);
            return this;
        }

        [MethodImpl(Inline)]
        public BitVector64 Select(BitVector64 y, BitVector64 z)
        {
            data = math.select(data,y.data,z.data);
            return this;
        }


        /// <summary>
        /// Computes in-place the bitwise complement of the source vector,
        /// returning the result to the caller
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector64 Not()
        {
            data = ~data;
            return this;
        }

        [MethodImpl(Inline)]
        public BitVector64 Negate()
        {
            data = math.negate(data);
            return this;
        }

        /// <summary>
        /// Computes the in-place arithmetic difference betwien the source vector and another
        /// </summary>
        /// <param name="y">The vector to subtract from the source</param>
        [MethodImpl(Inline)]
        public BitVector64 Sub(BitVector64 y)
        {
            data -= y.data;
            return this;
        }

        /// <summary>
        /// Shifts the bits in the vector leftwards
        /// </summary>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public BitVector64 Sll(int offset)
        {
            data <<= offset;
            return this;
        }

        /// <summary>
        /// Shifts the bits in the vector rightwards
        /// </summary>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public BitVector64 Srl(int offset)
        {
            data >>= offset;
            return this;
        }

        /// <summary>
        /// Applies in-place rightward bit rotation by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector64 Rotr(int offset)
        {
            data = Bits.rotr(data, offset);
            return this;
        }

        /// <summary>
        /// Applies in-place leftward bit rotation by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector64 Rotl(int offset)
        {
            data = Bits.rotl(data, offset);
            return this;
        }

        /// <summary>
        /// Enables a bit in-place
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void Enable(BitPos pos)
            => BitMask.enable(ref data, pos);

        /// <summary>
        /// Disables a bit in-place
        /// </summary>
        /// <param name="pos">The position of the bit to disable</param>
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
        /// Sets a bit to a specified value
        /// </summary>
        /// <param name="pos">The position of the bit to set</param>
        /// <param name="value">The bit value</param>
        [MethodImpl(Inline)]
        public void Set(BitPos pos, Bit value)
            => BitMask.set(ref data, pos, value);

        /// <summary>
        /// Increments the vector arithmetically
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public BitVector64 Inc()
        {
            data++;
            return this;
        }

        /// <summary>
        /// Decrements the vector arithmetically
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public BitVector64 Dec()
        {
            data--;
            return this;
        }

        /// <summary>
        /// Reverses the vector's bits
        /// </summary>
        [MethodImpl(Inline)]
        public void Reverse()
            => data = Bits.rev(data);

        /// <summary>
        /// Computes the vector src = src & ~ y in-place
        /// </summary>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public BitVector64 AndNot(BitVector64 y)
        {
            data = Bits.andnot(data, y.data);            
            return this;
        }

        /// <summary>
        /// Rearranges the vector in-place as specified by a permutation
        /// </summary>
        /// <param name="spec">The permutation</param>
        [MethodImpl(Inline)]
        public BitVector64 Permute(Perm spec)
            => bitvector.perm(ref this, spec);

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
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline)]
        public readonly BitVector64 Lsb(int n)
            => Between(0, n - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public readonly BitVector64 Msb(int n)                
            => Between(LastPos - n, LastPos);                
        
        /// <summary>
        /// Counts the number of enabled bits in the source
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitSize Pop()
            => Bits.pop(data);
        
        /// <summary>
        /// Counts the number of 0 bits prior to the first most significant 1 bit
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitSize Nlz()
            => Bits.nlz(data);

        /// <summary>
        /// Counts the number of trailing zero bits in the source
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
        /// Populates a target vector with specified source bits
        /// </summary>
        /// <param name="spec">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        [MethodImpl(Inline)]
        public readonly BitVector64 Gather(BitVector64 spec)
            => Bits.gather(data, spec);

        /// <summary>
        /// Populates a target vector with specified source bits
        /// </summary>
        /// <param name="mask">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        [MethodImpl(Inline)]
        public readonly BitVector32 Gather(BitVector32 mask)
            => (uint)Bits.gather((uint)data, (uint)mask);

        /// <summary>
        /// Populates a target vector with specified source bits
        /// </summary>
        /// <param name="mask">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        [MethodImpl(Inline)]
        public readonly BitVector16 Gather(BitVector16 mask)        
            => (ushort)Bits.gather(data, (ulong)mask);
        
        /// <summary>
        /// Populates a target vector with specified source bits
        /// </summary>
        /// <param name="mask">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        [MethodImpl(Inline)]
        public readonly BitVector8 Gather(BitVector8 mask)
            => (byte)Bits.gather(data, (ulong)mask);

        /// <summary>
        /// Tests whether all bits are on
        /// </summary>
        [MethodImpl(Inline)]
        public readonly bool AllOnes()
            => (UInt64.MaxValue & data) == UInt64.MaxValue;
        
        /// <summary>
        /// Converts the vector to a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitString ToBitString()
            => data.ToBitString();

        /// <summary>
        /// Extracts the scalar represented by the vector
        /// </summary>
        public readonly ulong Scalar
        {
            [MethodImpl(Inline)]
            get => data;
        }
            
        [MethodImpl(Inline)]
        public T ToScalar<T>()
            where T : unmanaged
                => Unsafe.As<ulong,T>(ref data);

        /// <summary>
        /// Applies a truncating reduction Bv64 -> Bv8
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector8 ToBitVector8()
            => BitVector8.FromScalar(data);

        /// <summary>
        /// Applies a truncating reduction Bv64 -> Bv16
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector16 ToBitVector16()
            => BitVector16.FromScalar(data);

        /// <summary>
        /// Applies a truncating reduction Bv64 -> Bv32
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector32 ToBitVector32()
            => BitVector32.FromScalar(data);

        /// <summary>
        /// Applies the identity conversion Bv64 -> Bv64
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector64 ToBitVector64()
            => BitVector64.FromScalar(data);

        /// <summary>
        /// Applies a widening conversion Bv64 -> Bv128
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector128 ToBitVector128()
            => BitVector128.FromScalar(data);

        /// <summary>
        /// Returns a copy of the vector
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitVector64 Replicate()
            => new BitVector64(data);

        /// <summary>
        /// Applies a permutation to a replicated vector
        /// </summary>
        /// <param name="p">The permutation</param>
        [MethodImpl(Inline)]
        public readonly BitVector64 Replicate(Perm p)
        {
            var dst = Replicate();
            dst.Permute(p);
            return dst;
        }

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="tlz">True if leadzing zeros should be trimmed, false otherwise</param>
        /// <param name="specifier">True if the prefix specifier '0b' should be prepended</param>
        /// <param name="blockWidth">The width of the blocks, if any</param>
        [MethodImpl(Inline)]
        public readonly string Format(bool tlz = false, bool specifier = false, int? blockWidth = null)
            => ToBitString().Format(tlz, specifier, blockWidth);

        [MethodImpl(Inline)]
        public readonly bool Equals(BitVector64 y)
            => data == y.data;

        public override bool Equals(object obj)
            => obj is BitVector64 x && Equals(x); 
        
        public override int GetHashCode()
            => data.GetHashCode();
 
        public override string ToString()
            => Format();
 
        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        Bit DotRef(BitVector64 y)
        {
            var result = Bit.Off;
            for(var i=0; i<Length; i++)
                result ^= this[i] & y[i];
            return result;
        }

    }
}