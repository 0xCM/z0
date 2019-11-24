//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    /// <summary>
    /// Defines a 64-bit bitvector
    /// </summary>
    public struct BitVector64 
    {    
        internal ulong data;

        public static BitVector64 Zero => default;

        public static BitVector64 One => 1;                

        /// <summary>
        /// Allocates a new empty vector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector64 Alloc()
            => new BitVector64(0);

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
            => BitVector<N64,ulong>.FromArray(src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitVector<ulong>(BitVector64 src)
            => src.data;

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
            => BitVector.from(n32, (uint)src.data);        

        /// <summary>
        /// Implicitly converts a scalar value to a 64-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector64(byte src)
            => BitVector.from(n64,src);

        /// <summary>
        /// Implicitly converts a scalar value to a 64-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector64(ushort src)
            => BitVector.from(n64,src);

        /// <summary>
        /// Implicitly converts a scalar value to a 64-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector64(uint src)
            => BitVector.from(n64,src);

        /// <summary>
        /// Computes the bitwise XOR of the source operands
        /// Note that the XOR operator is equivalent to the (+) operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator ^(BitVector64 x, BitVector64 y)
            => BitVector.xor(x,y);
        /// <summary>
        /// Computes the bitwise AND of the source operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator &(BitVector64 x, BitVector64 y)
            => BitVector.and(x,y);

        /// <summary>
        /// Computes the bitwise OR of the source operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator |(BitVector64 x, BitVector64 y)
            => BitVector.or(x,y);

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static bit operator %(in BitVector64 x, in BitVector64 y)
            => BitVector.dot(x,y);

        /// <summary>
        /// Computes the arithmetic sum of the source operands. 
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator +(BitVector64 x, BitVector64 y)
            => BitVector.add(x,y);

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator ~(BitVector64 src)
            => BitVector.not(src);

        /// <summary>
        /// Negates the operand via two's complement
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator -(BitVector64 src)
            => BitVector.negate(src);

        /// <summary>
        /// Arithmetically subtracts the second operand from the first. 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator - (BitVector64 x, BitVector64 y)
            => BitVector.sub(x,y);

        /// <summary>
        /// Shifts the source bits leftwards
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator <<(BitVector64 x, int offset)
            => BitVector.sll(x,offset);

        /// <summary>
        /// Shifts the source bits rightwards
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator >>(BitVector64 x, int offset)
            => BitVector.srl(x,offset);

        /// <summary>
        /// Increments the vector arithmetically
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator ++(BitVector64 src)
            => BitVector.inc(src);

        /// <summary>
        /// Decrements the vector arithmetically
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator --(BitVector64 src)
            => BitVector.dec(src);

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
        /// Presents vector content as a span of bytes
        /// </summary>
        [MethodImpl(Inline)]
        public Span<byte> AsBytes()
            => bytespan(ref data);

        /// <summary>
        /// Reads/Manipulates a source bit at a specified position
        /// </summary>
        public bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => GetBit(pos);
            
            [MethodImpl(Inline)]
            set => SetBit(pos,value);
       }

        /// <summary>
        /// Selects an inclusive range of bits
        /// </summary>
        public BitVector64 this[Range range]
        {
            [MethodImpl(Inline)]
            get => BitVector.between(this,range.Start.Value, range.End.Value);
        }

        /// <summary>
        /// Selects a contiguous range of bits
        /// </summary>
        /// <param name="first">The position of the first bit</param>
        /// <param name="last">The position of the last bit</param>
        public BitVector64 this[int first, int last]
        {
            [MethodImpl(Inline)]
            get => BitVector.between(this,first, last);
        }

        /// <summary>
        /// The vector's 32 least significant bits
        /// </summary>
        public readonly BitVector32 Lo
        {
            [MethodImpl(Inline)]
            get => BitVector.from(n32, (uint)data);
        }

        /// <summary>
        /// The vector's 32 most significant bits
        /// </summary>
        public readonly BitVector32 Hi
        {
            [MethodImpl(Inline)]
            get => BitVector.from(n32,(uint)(data >> 32));
        }        

        /// <summary>
        /// The actual number of bits represented by the vector
        /// </summary>
        public readonly int Width
        {
            [MethodImpl(Inline)]
            get => 64;
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
        public bit GetBit(int pos)
            => BitMask.test(data, pos);

        /// <summary>
        /// Sets the state of an index-identified bit
        /// </summary>
        /// <param name="pos">The bit index</param>
        /// <param name="value">The bit value</param>
        [MethodImpl(Inline)]
        public void SetBit(int pos, bit value)
            => data = BitMask.set(data, (byte)pos, value);

        /// <summary>
        /// Enables a bit in-place
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void Enable(int pos)
            => data = BitMask.enable(ref data, pos);

        /// <summary>
        /// Disables a bit in-place
        /// </summary>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public void Disable(int pos)
            => data = BitMask.disable(ref data, pos);

        /// <summary>
        /// Disables the bits after a specified poistion
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public void DisableAfter(int pos)
            => data = Bits.zerohi(data, (byte)++pos);
            
        /// <summary>
        /// Rearranges the vector in-place as specified by a permutation
        /// </summary>
        /// <param name="spec">The permutation</param>
        [MethodImpl(Inline)]
        public BitVector64 Permute(Perm spec)
            => BitVector.perm(ref this, spec);

        /// <summary>
        /// Determines whether a bit is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public readonly bit Test(int pos)
            => BitMask.test(data, pos);
        
        /// <summary>
        /// Counts the number of enabled bits in the source
        /// </summary>
        [MethodImpl(Inline)]
        public readonly uint Pop()
            => Bits.pop(data);
        
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
        public readonly string Format(bool tlz = false, bool specifier = false, int? blockWidth = null, int? rowWidth = null)
            => ToBitString().Format(tlz, specifier, blockWidth, null, rowWidth);

        [MethodImpl(Inline)]
        public readonly bool Equals(BitVector64 y)
            => data == y.data;

        public override bool Equals(object obj)
            => obj is BitVector64 x && Equals(x); 
        
        public override int GetHashCode()
            => data.GetHashCode();
 
        public override string ToString()
            => Format();
 

    }
}