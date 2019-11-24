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
    /// Defines a 16-bit bitvector
    /// </summary>
    public struct BitVector16
    {
        internal ushort data;            

        public static BitVector16 Zero => 0;

        public static BitVector16 One => 1;

        public static BitVector16 Ones => ushort.MaxValue;

        public static N16 N => default;

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

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N16,ushort>(BitVector16 src)
            => BitVector<N16,ushort>.FromArray(src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitVector<ushort>(BitVector16 src)
            => src.data;

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
            => BitVector.xor(x,y);

        /// <summary>
        /// Computes the bitwise AND of the source operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator &(BitVector16 x, BitVector16 y)
            => BitVector.and(x,y);

        /// <summary>
        /// Computes the bitwise OR of the source operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator |(BitVector16 x, BitVector16 y)
            => BitVector.or(x,y);

        /// <summary>
        /// Computes the bitwise complement of the operand. 
        /// Note that this operator is closely related to the negation operator (-)
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator ~(BitVector16 src)
            => BitVector.not(src);

        /// <summary>
        /// Computes the arithmetic sum of the source operands. 
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator +(BitVector16 x, BitVector16 y)
            => BitVector.add(x,y);

        /// <summary>
        /// Computes the two's complement of the operand
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator -(in BitVector16 src)
            => BitVector.negate(src);

        /// <summary>
        /// Subtracts the second operand from the first. Note that this operator is equivalent to
        /// the composite operation of applying the XOR operator to the left operand and the
        /// complement of the second
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator - (BitVector16 x, BitVector16 y)
            => BitVector.sub(x,y);

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static bit operator %( BitVector16 x, BitVector16 y)
            => BitVector.dot(x,y);

        /// <summary>
        /// Left-shifts the bits in the source
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator <<(BitVector16 x, int offset)
            => BitVector.sll(x,offset);

        /// <summary>
        /// Right-shifts the bits in the source
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator >>(BitVector16 x, int offset)
            => BitVector.srl(x,offset);

        /// <summary>
        /// Arithmetically increments the source vector 
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator ++(BitVector16 src)
            => BitVector.inc(src);

        /// <summary>
        /// Arithmetically decrements the source vector 
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator --(BitVector16 src)
            => BitVector.dec(src);

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
        /// Gets/Sets an identified bit
        /// </summary>
        public bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => BitMask.test(data, pos);
            
            [MethodImpl(Inline)]
            set => data = BitMask.set(data, (byte)pos, value);
        }
        
        /// <summary>
        /// Selects a contiguous range of bits
        /// </summary>
        public BitVector16 this[Range range]
        {
            [MethodImpl(Inline)]
            get => BitVector.between(this, range.Start.Value, range.End.Value);
        }

        /// <summary>
        /// Selects a contiguous range of bits
        /// </summary>
        /// <param name="first">The position of the first bit</param>
        /// <param name="last">The position of the last bit</param>
        public BitVector16 this[int first, int last]
        {
            [MethodImpl(Inline)]
            get => BitVector.between(this, first, last);
        }

        /// <summary>
        /// The number of bits represented by the vector
        /// </summary>
        public readonly int Width
        {
            [MethodImpl(Inline)]
            get => 16;
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
            => BitVector.from(n32,data);

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
        /// Selects an index-identified byte where index = 0 | 1
        /// </summary>
        /// <param name="index">The 0-based byte-relative position</param>
        [MethodImpl(Inline)]
        public ref byte Byte(int index)        
            => ref Bytes[index];


        /// <summary>
        /// Enables a bit if it is disabled
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void Enable(int pos)
            => BitMask.enable(ref data, pos);

        /// <summary>
        /// Disables a bit if it is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public void Disable(int pos)
            => BitMask.disable(ref data, pos);

        /// <summary>
        /// Disables the bits after a specified poistion
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public void DisableAfter(int pos)
            => data = Bits.zerohi(data, (byte)++pos);
            
        /// <summary>
        /// Determines whether a bit is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public readonly bit Test(int pos)
            => BitMask.test(data, pos);

        /// <summary>
        /// Counts vector's enabled bits
        /// </summary>
        [MethodImpl(Inline)]
        public uint Pop()
            => Bits.pop(data);

        /// <summary>
        /// Rearranges the vector in-place as specified by a permutation
        /// </summary>
        /// <param name="spec">The permutation</param>
        [MethodImpl(Inline)]
        public BitVector16 Permute(Perm spec)
            => BitVector.perm(ref this, spec);

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

        [MethodImpl(Inline)]
        public BitVector32 Concat(BitVector16 tail)
            => BitVector.from(n32,tail.data, data);

        /// <summary>
        /// Returns a copy of the vector
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector16 Replicate()
            => new BitVector16(data);

        [MethodImpl(Inline)]
        public BitVector32 Replicate(N2 n)
            => Concat(this);

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

        /// <summary>
        /// Applies a truncating reduction Bv16 -> Bv8
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector8 ToBitVector8()
            => BitVector.from(n8, data);

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
            => BitVector.from(n32,data);

        /// <summary>
        /// A widening conversion Bv16 -> Bv64
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector64 ToBitVector64()
            => BitVector.from(n64,data);

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
        public string Format(bool tlz = false, bool specifier = false, int? blockWidth = null, char? blocksep = null)
            => ToBitString().Format(tlz, specifier, blockWidth, blocksep);

         public override bool Equals(object obj)
            => obj is BitVector16 x ? Equals(x) : false;
        
        public override int GetHashCode()
            => data.GetHashCode();
        
        public override string ToString()
            => Format();
   }

}