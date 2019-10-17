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
    /// Defines a 16-bit bitvector
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size = 2)]
    public struct BitVector16 : IPrimalBitVector<BitVector16, ushort>
    {
        internal ushort data;

        public static readonly BitVector16 Zero = 0;

        public static readonly BitVector16 One = 1;

        public static readonly BitVector16 Ones = ushort.MaxValue;

        public static readonly BitSize Width = 16;

        public static readonly BitPos FirstPos = 0;

        public static readonly BitPos LastPos = Width - 1;

        /// <summary>
        /// Allocates a zero-filled vector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector16 Alloc()
            => new BitVector16(0);    

        /// <summary>
        /// Loads a vector from the primal source value it represents
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 FromScalar(ushort src)
            => new BitVector16(src);    

        /// <summary>
        /// Loads a vector from a primal source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 FromScalar(uint src)
            => new BitVector16((ushort)src);    

        /// <summary>
        /// Loads a vector from a primal source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 FromScalar(int src)
            => new BitVector16((ushort)src);    

        /// <summary>
        /// Creates a vector from the least 16 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 FromScalar(ulong src)
            => new BitVector16((ushort)src);    

        /// <summary>
        /// Creates a vector from two bytes
        /// </summary>
        /// <param name="lo">The byte that will constitute the lo vector bits</param>
        /// <param name="hi">The byte that will constitute the hi vector bits</param>
        [MethodImpl(Inline)]
        public static BitVector16 FromScalars(byte lo, byte hi)
            => FromScalar((ushort)hi << 8 | (ushort)lo);

        /// <summary>
        /// Creates a vector from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector16 FromBitString(in BitString src)
            => src.TakeUInt16();    

        public static BitVector16 Parse(string src)
        {
            var bs = BitString.Parse(src);
            var len = math.min(bs.Length, Width);
            Bits.packseq(bs.BitSeq, out ushort dst);
            return dst;
        }

        /// <summary>
        /// Enumerates all 16-bit bitvectors whose width is less than or equal to a specified maximum width
        /// </summary>
        public static IEnumerable<BitVector16> All(int maxwidth)
        {
            var maxval = Pow2.pow(maxwidth);
            var bv = BitVector16.Zero;
            while(bv < maxval)
                yield return bv++;            
        }

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N16,ushort>(BitVector16 src)
            => BitVector<N16,ushort>.FromCells(src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitVector16(ushort src)
            => new BitVector16(src);

        /// <summary>
        /// Converts the source vector to the underlying primal value
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator ushort(BitVector16 src)
            => src.data;        

        [MethodImpl(Inline)]
        public static implicit operator BitVector32(BitVector16 src)
            => src.ToBitVector32();

        [MethodImpl(Inline)]
        public static implicit operator BitVector64(BitVector16 src)
            => src.ToBitVector64();

        /// <summary>
        /// Truncates the source vector by half
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static explicit operator BitVector8(BitVector16 src)
            => src.ToBitVector8();

        /// <summary>
        /// Computes the bitwise XOR of the source operands
        /// Note that the XOR operator is equivalent to the (+) operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator ^(BitVector16 x, BitVector16 y)
            => bitvector.xor(x,y);

        /// <summary>
        /// Computes the bitwise AND of the source operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator &(BitVector16 x, BitVector16 y)
            => bitvector.and(x,y);

        /// <summary>
        /// Computes the bitwise OR of the source operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator |(BitVector16 x, BitVector16 y)
            => bitvector.or(x,y);

        /// <summary>
        /// Computes the bitwise complement of the operand. 
        /// Note that this operator is closely related to the negation operator (-)
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator ~(BitVector16 src)
            => bitvector.not(src);

        /// <summary>
        /// Computes the arithmetic sum of the source operands. 
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator +(BitVector16 x, BitVector16 y)
            => bitvector.add(x,y);

        /// <summary>
        /// Computes the two's complement of the operand
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator -(in BitVector16 src)
            => bitvector.negate(src);

        /// <summary>
        /// Subtracts the second operand from the first. Note that this operator is equivalent to
        /// the composite operation of applying the XOR operator to the left operand and the
        /// complement of the second
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator - (BitVector16 x, BitVector16 y)
            => bitvector.sub(x,y);

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit operator %( BitVector16 x, BitVector16 y)
            => bitvector.dot(x,y);

        /// <summary>
        /// Left-shifts the bits in the source
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator <<(BitVector16 x, int offset)
            => bitvector.sll(x,offset);

        /// <summary>
        /// Right-shifts the bits in the source
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator >>(BitVector16 x, int offset)
            => bitvector.srl(x,offset);

        /// <summary>
        /// Arithmetically increments the source vector 
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator ++(BitVector16 src)
            => bitvector.inc(src);

        /// <summary>
        /// Arithmetically decrements the source vector 
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator --(BitVector16 src)
            => bitvector.dec(src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(BitVector16 src)
            => src.Nonempty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(BitVector16 src)
            => !src.Nonempty;

        /// <summary>
        /// Computes the operand's logical negation: if x = 0 then 1 else 0
        /// </summary>
        /// <param name="src">The ource operand</param>
        [MethodImpl(Inline)]
        public static Bit operator !(BitVector16 src)
            => src.Empty;

        /// <summary>
        /// Determines whether the operands represent identical values
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static bool operator ==(BitVector16 x, BitVector16 y)
            => x.Equals(y);

        /// <summary>
        /// Determines whether the operands represent identical values
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static bool operator !=(BitVector16 x, BitVector16 y)
            => !x.Equals(y);

        /// <summary>
        /// Initializes the vector with the source value it represents
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public BitVector16(in ushort src)
            : this()
            => this.data = src;

        /// <summary>
        /// Assigns the bitvector a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public void assign(ushort src)
            => this.data = src;

        /// <summary>
        /// Gets/Sets an identified bit
        /// </summary>
        public Bit this[BitPos pos]
        {
            [MethodImpl(Inline)]
            get => Get(pos);
            
            [MethodImpl(Inline)]
            set => Set(pos,value);
        }
        
        /// <summary>
        /// Selects a contiguous range of bits
        /// </summary>
        public BitVector16 this[Range range]
        {
            [MethodImpl(Inline)]
            get => Between(range.Start.Value, range.End.Value);
        }

        /// <summary>
        /// Selects a contiguous range of bits
        /// </summary>
        /// <param name="first">The position of the first bit</param>
        /// <param name="last">The position of the last bit</param>
        public BitVector16 this[BitPos first, BitPos last]
        {
            [MethodImpl(Inline)]
            get => Between(first, last);
        }

        /// <summary>
        /// The number of bits represented by the vector
        /// </summary>
        public readonly BitSize Length
        {
            [MethodImpl(Inline)]
            get => 16;
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
        /// The vector's 8 least significant bits
        /// </summary>
        public BitVector8 Lo
        {
            [MethodImpl(Inline)]
            get => (byte)data;

        }

        /// <summary>
        /// The vector's 8 most significant bits
        /// </summary>
        public BitVector8 Hi
        {
            [MethodImpl(Inline)]
            get => (byte)(data >> 8);

        }
        
        /// <summary>
        /// Zero-extends the vector to a vector that accomondates
        /// the next power of 2
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector32 Expand()
            => BitVector32.FromScalar(data);

        /// <summary>
        /// Presents bitvector content as a bytespan
        /// </summary>
        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(data);
        }

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
        /// Selects an index-identified byte where index = 0 | 1
        /// </summary>
        /// <param name="index">The 0-based byte-relative position</param>
        [MethodImpl(Inline)]
        public ref byte Byte(int index)        
            => ref Bytes[index];

        /// <summary>
        /// Computes in-place the bitwise AND of the source vector and another,
        /// returning the result to the caller
        /// </summary>
        /// <param name="y">The other vector</param>
        [MethodImpl(Inline)]
        public BitVector16 And(BitVector16 y)
        {
            data &= y.data;
            return this;
        }

        [MethodImpl(Inline)]
        public BitVector16 Nand(BitVector16 y)
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
        public BitVector16 Or(BitVector16 y)
        {
            data |= y.data;
            return this;
        }

        [MethodImpl(Inline)]
        public BitVector16 Nor(BitVector16 y)
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
        public BitVector16 XOr(BitVector16 y)
        {
            data ^= y.data;
            return this;
        }

        [MethodImpl(Inline)]
        public BitVector16 XNor(BitVector16 y)
        {
            data = math.xnor(data,y.data);
            return this;
        }

        [MethodImpl(Inline)]
        public BitVector16 Select(BitVector16 y, BitVector16 z)
        {
            data = math.select(data,y.data,z.data);
            return this;
        }

        /// <summary>
        /// Computes in-place the bitwise complement of the source vector,
        /// returning the result to the caller
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector16 Not()
        {
            data = math.flip(data);
            return this;
        }

        [MethodImpl(Inline)]
        public BitVector16 Negate()
        {
            data = math.negate(data);
            return this;
        }

        /// <summary>
        /// Computes the in-place arithmetic difference between the source vector and another
        /// </summary>
        /// <param name="y">The vector to subtract from the source</param>
        [MethodImpl(Inline)]
        public BitVector16 Sub(BitVector16 y)
        {
            data -= y.data;
            return this;
        }

        /// <summary>
        /// Increments the vector arithmetically
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public BitVector16 Inc()
        {
            data++;
            return this;
        }

        /// <summary>
        /// Decrements the vector arithmetically
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public BitVector16 Dec()
        {
            data--;
            return this;
        }

        /// <summary>
        /// Shifts the bits in the vector leftwards
        /// </summary>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public BitVector16 Sll(int offset)
        {
            data <<= offset;
            return this;
        }

        /// <summary>
        /// Shifts the bits in the vector rightwards
        /// </summary>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public BitVector16 Srl(int offset)
        {
            data >>= offset;
            return this;
        }

        /// <summary>
        /// Rotates vector bits rightwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector16 Rotr(int offset)
        {
            data = Bits.rotr(data, offset);
            return this;
        }

        /// <summary>
        /// Rotates vector bits leftwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector16 Rotl(int offset)
        {
            data = Bits.rotl(data, offset);
            return this;
        }

        [MethodImpl(Inline)]
        public BitVector16 AndNot(BitVector16 y)
        {
            data = Bits.andnot(data, y.data);            
            return this;
        }        

        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public Bit Dot(BitVector16 y)
            => bitvector.dot(this,y);

        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline)]
        public BitVector16 Between(BitPos first, BitPos last)
            => Bits.between(in data, first, last);
        
        /// <summary>
        /// Populates a target vector with specified source bits
        /// </summary>
        /// <param name="spec">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        [MethodImpl(Inline)]
        public BitVector16 Gather(BitVector16 spec)
            => Bits.gather(data, spec);

        /// <summary>
        /// Populates a target vector with specified source bits
        /// </summary>
        /// <param name="spec">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        [MethodImpl(Inline)]
        public BitVector8 Gather(BitVector8 spec)
            => (byte)Bits.gather(data, (byte)spec);

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
        /// Disables the high bits that follow the specified index
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
        /// Counts vector's enabled bits
        /// </summary>
        [MethodImpl(Inline)]
        public BitSize Pop()
            => Bits.pop(data);

        /// <summary>
        /// Counts the vector's leading zero bits
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public BitSize Nlz()
            => Bits.nlz(data);

        /// <summary>
        /// Counts the vector's trailing zero bits
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public BitSize Ntz()
            => Bits.ntz(data);

        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline)]
        public BitVector16 Lsb(int n)                
            => Between(0, n - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public BitVector16 Msb(int n)                
            => Between(LastPos - n, LastPos);                

        /// <summary>
        /// Counts the number of bits set up to and including the specified position
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit for which rank will be calculated</param>
        [MethodImpl(Inline)]
        public uint Rank(BitPos pos)
            => Bits.rank(data,pos);

        /// <summary>
        /// Reverses the vector's bits
        /// </summary>
        [MethodImpl(Inline)]
        public void Reverse()
        {
            data = Bits.rev(data);
        }


        /// <summary>
        /// Rearranges the vector in-place as specified by a permutation
        /// </summary>
        /// <param name="spec">The permutation</param>
        [MethodImpl(Inline)]
        public BitVector16 Permute(Perm spec)
            => bitvector.perm(ref this, spec);

        [MethodImpl(Inline)]
        public bool AllOnes()
            => (UInt16.MaxValue & data) == UInt16.MaxValue;

        /// <summary>
        /// Returns true if no bits are enabled, false otherwise
        /// </summary>
        public bool Empty
        {
            [MethodImpl(Inline)]
            get => data == 0;
        }

        /// <summary>
        /// Returns true if the vector has at least one enabled bit; false otherwise
        /// </summary>
        public bool Nonempty
        {
            [MethodImpl(Inline)]
            get => data != 0;
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
        /// Returns a copy of the vector
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector16 Replicate()
            => new BitVector16(data);

        /// <summary>
        /// Applies a permutation to a replicated vector
        /// </summary>
        /// <param name="p">The permutation</param>
        [MethodImpl(Inline)]
        public BitVector16 Replicate(Perm p)
        {
            var dst = Replicate();
            dst.Permute(p);
            return dst;
        }

        [MethodImpl(Inline)]
        public BitVector32 Concat(BitVector16 tail)
            => BitVector32.FromScalars(tail.data, data);

        /// <summary>
        /// Returns the vector's bitstring representation
        /// </summary>
        [MethodImpl(Inline)]
        public BitString ToBitString()
            => data.ToBitString();

        /// <summary>
        /// Extracts the scalar represented by the vector
        /// </summary>
        public ushort Scalar
        {
            [MethodImpl(Inline)]
            get => data;
        }

        [MethodImpl(Inline)]
        public T ToScalar<T>()
            where T : unmanaged
                => Unsafe.As<ushort,T>(ref data);


        /// <summary>
        /// Applies a truncating reduction Bv16 -> Bv8
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector8 ToBitVector8()
            => BitVector8.FromScalar(data);

        /// <summary>
        /// The identity conversion Bv16 -> Bv16
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector16 ToBitVector16()
            => BitVector16.FromScalar(data);

        /// <summary>
        /// A widening conversion Bv16 -> Bv32
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector32 ToBitVector32()
            => BitVector32.FromScalar(data);

        /// <summary>
        /// A widening conversion Bv16 -> Bv64
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector64 ToBitVector64()
            => BitVector64.FromScalar(data);

        [MethodImpl(Inline)]
        public bool Equals(BitVector16 y)
            => data == y.data;

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="tlz">True if leadzing zeros should be trimmed, false otherwise</param>
        /// <param name="specifier">True if the prefix specifier '0b' should be prepended</param>
        /// <param name="blockWidth">The width of the blocks, if any</param>
        [MethodImpl(Inline)]
        public string Format(bool tlz = false, bool specifier = false, int? blockWidth = null)
            => ToBitString().Format(tlz, specifier, blockWidth);

         public override bool Equals(object obj)
            => obj is BitVector16 x ? Equals(x) : false;
        
        public override int GetHashCode()
            => data.GetHashCode();
        
        public override string ToString()
            => Format();
   }

}