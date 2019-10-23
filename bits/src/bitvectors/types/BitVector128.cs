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
    using System.Runtime.Intrinsics;

    using static zfunc;    

    [StructLayout(LayoutKind.Sequential)]
    public struct BitVector128
    {

        ulong x0;

        ulong x1;

        /// <summary>
        /// Defines a reference vector consisting of only zeros
        /// </summary>
        public static readonly BitVector128 Zero = default;

        /// <summary>
        /// Defines a reference vector that has the numeric value 1
        /// </summary>
        public static readonly BitVector128 One = (1,0);

        /// <summary>
        /// Defines a reference vector consisting of only ones
        /// </summary>
        public static readonly BitVector128 Ones = (UInt64.MaxValue, UInt64.MaxValue);

        public const int BitSize = 128;

        public const int LastPos = BitSize - 1;

        /// <summary>
        /// Allocates a new empty vector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector128 Alloc()
            => default;

        /// <summary>
        /// Creates a vector from a primal source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 FromScalar(byte src)
            => FromScalar((ulong)src);

        /// <summary>
        /// Creates a vector from a primal source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 FromScalar(ushort src)
            => FromScalar((ulong)src);

        /// <summary>
        /// Creates a vector from a primal source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 FromScalar(uint src)
            => FromScalar((ulong)src);

        /// <summary>
        /// Creates a vector from a primal source value
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector128 FromScalar(ulong src)
            => new BitVector128(src,0);

        /// <summary>
        /// Creates a vector from two unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector128 FromScalars(uint x00, uint x01, uint x10, uint x11)
            => new BitVector128(x00,x01,x10,x11);

        /// <summary>
        /// Creates a vector from two unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector128 FromScalars(ulong lo, ulong hi)
            => new BitVector128(lo,hi);

        /// <summary>
        /// Creates a vector from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector128 FromBitString(in BitString src)
        {
            var x0 = src.TakeUInt64(0);            
            var x1 = src.Length > 64 ? src.TakeUInt64(64) : 0ul;
            return FromScalars(x0, x1);
        }

        [MethodImpl(Inline)]    
        public static implicit operator BitVector128((ulong x0, ulong x1) src)
            => new BitVector128(src.x0, src.x1);

        [MethodImpl(Inline)]    
        public static implicit operator (ulong x0, ulong x1)(BitVector128 src)
            => (src.x0, src.x1);


        /// <summary>
        /// Implicitly converts an unsigned 128-bit integer to a bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector128(UInt128 src)
            => new BitVector128(src);

        /// <summary>
        /// Implicitly converts a scalar value to a 128-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector128(byte src)
            => FromScalar(src);

        /// <summary>
        /// Implicitly converts a scalar value to a 128-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector128(ushort src)
            => FromScalar(src);

        /// <summary>
        /// Implicitly converts a scalar value to a 128-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector128(uint src)
            => FromScalar(src);

        /// <summary>
        /// Implicitly converts a scalar value to a 128-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector128(ulong src)
            => FromScalar(src);

        /// <summary>
        /// Implicitly converts a scalar value to a 128-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector128(BitVector8 src)
            => FromScalar(src);

        /// <summary>
        /// Implicitly converts a scalar value to a 128-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector128(BitVector16 src)
            => FromScalar(src);

        /// <summary>
        /// Implicitly converts a scalar value to a 128-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector128(BitVector32 src)
            => FromScalar(src);

        /// <summary>
        /// Implicitly converts a scalar value to a 128-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector128(BitVector64 src)
            => FromScalar(src);

        /// <summary>
        /// Implicitly converts a bitvector to a cpu vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator Vec128<ulong>(BitVector128 src)
            => src.ToCpuVec();

        /// <summary>
        /// Explicitly truncates the source to 8 bits
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static explicit operator BitVector8(BitVector128 src)
            => src.ToBitVector8();

        /// <summary>
        /// Explicitly truncates the source to 16 bits
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static explicit operator BitVector16(BitVector128 src)
            => src.ToBitVector16();

        /// <summary>
        /// Explicitly truncates the source to 32 bits
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static explicit operator BitVector32(BitVector128 src)
            => src.ToBitVector32();

        /// <summary>
        /// Explicitly truncates the source to 64 bits
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static explicit operator BitVector64(BitVector128 src)
            => src.ToBitVector64();


        /// <summary>
        /// Computes the bitwise XOR of the source operands
        /// Note that the XOR operator is equivalent to the (+) operator
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector128 operator ^(BitVector128 lhs, BitVector128 rhs)
            => lhs.XOr(rhs);

        /// <summary>
        /// Computes the bitwise AND of the source operands
        /// Note that the AND operator is equivalent to the (*) operator
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector128 operator &(BitVector128 lhs, BitVector128 rhs)
            => lhs.And(rhs);

        /// <summary>
        /// Computes the bitwise OR of the source operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector128 operator |(BitVector128 lhs, BitVector128 rhs)
            => lhs.Or(rhs);

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector128 operator ~(BitVector128 src)
            => src.Not();

        /// <summary>
        /// Negates the operand via two'2 complement
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector128 operator -(BitVector128 src)
            => src.Negate();

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static bit operator %(BitVector128 lhs,BitVector128 rhs)
            => odd((lhs & rhs).Pop());              

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(BitVector128 src)
            => src.Nonempty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(BitVector128 src)
            => !src.Nonempty;

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector128 lhs, in BitVector128 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector128 lhs, in BitVector128 rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]    
        public BitVector128(ulong x0, ulong x1)
            : this()
        {
            this.x0 = x0; 
            this.x1 = x1;
        }

        [MethodImpl(Inline)]    
        public BitVector128(uint x00, uint x01,uint x10, uint x11)
            : this()
        {
            this.x0 = Bits.pack(x00,x01);
            this.x1 = Bits.pack(x10, x11);
        }


        [MethodImpl(Inline)]    
        public BitVector128(UInt128 src)
            : this()
        {
            this.x0 = src.lo;
            this.x0 = src.hi;
        }

        /// <summary>
        /// Assigns the bitvector a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public void assign(ulong x0, ulong x1)
        {
            this.x0 = x0;
            this.x1 = x1;
        }

        /// <summary>
        /// The vector's 64 least significant bits
        /// </summary>
        public readonly BitVector64 Lo
        {
            [MethodImpl(Inline)]
            get => x0;
        }

        /// <summary>
        /// The vector's 64 most significant bits
        /// </summary>
        public readonly BitVector64 Hi
        {
            [MethodImpl(Inline)]
            get => x1;
        }
        
        /// <summary>
        /// The actual number of bits represented by the vector
        /// </summary>
        public readonly BitSize Length
        {
            [MethodImpl(Inline)]
            get => BitSize;
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
        /// Returns true if no bits are enabled, false otherwise
        /// </summary>
        public readonly bool Empty
        {
            [MethodImpl(Inline)]
            get => x0 == 0 && x1 == 0;
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
        /// Reads/Manipulates a source bit at a specified position
        /// </summary>
        public bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => bit.Off;
            
            [MethodImpl(Inline)]
            set => Set(pos,value);
       }

        /// <summary>
        /// Computes the bitwise and of the vector and the operand
        /// </summary>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public BitVector128 And(BitVector128 rhs)
        {
            dinx.vloadu(in x0, out Vector128<ulong> x);
            dinx.vloadu(in rhs.x0, out Vector128<ulong> y);
            vstore(dinx.vand(x,y), ref x0);
            return this;
        }

        /// <summary>
        /// Computs the bitwise or of the vector and the operand
        /// </summary>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public BitVector128 Or(BitVector128 rhs)
        {
            dinx.vloadu(in x0, out Vector128<ulong> x);
            dinx.vloadu(in rhs.x0, out Vector128<ulong> y);
            vstore(dinx.vor(x,y), ref x0);
            return this;
        }

        /// <summary>
        /// Computs the bitwise xor of the vector and the operand
        /// </summary>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public BitVector128 XOr(BitVector128 rhs)
        {
            dinx.vloadu(in x0, out Vector128<ulong> x);
            dinx.vloadu(in rhs.x0, out Vector128<ulong> y);
            vstore(dinx.vxor(x,y), ref x0);
            return this;
        }

        /// <summary>
        /// Negates the vector via two's complement
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector128 Negate()
        {
            dinx.vloadu(in x0, out Vector128<ulong> x);
            vstore(dinx.vnegate(x), ref x0);
            return this;
        }

        /// <summary>
        /// Applies the bitwise complement
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector128 Not()
        {
            dinx.vloadu(in x0, out Vector128<ulong> x);
            vstore(dinx.vnot(x), ref x0);
            return this;
        }


        /// <summary>
        /// <summary>
        /// Counts the number of enabled bits in the source
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitSize Pop()
            => Bits.pop(x0) + Bits.pop(x1);

        /// <summary>
        /// Counts the number of leading zeros
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitSize Nlz()
        {
            if(x1 == 0)
                return 64 + Bits.nlz(x0);
            else
                return Bits.nlz(x1);
        }

        /// <summary>
        /// Counts the number of trailing zeros
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitSize Ntz()
        {
            if(x0 == 0)
                return Bits.ntz(x1) + 64;
            else
                return Bits.ntz(x0);
        }

        /// <summary>
        /// Sets a bit to a specified value
        /// </summary>
        /// <param name="pos">The position of the bit to set</param>
        /// <param name="value">The bit value</param>
        [MethodImpl(Inline)]
        public void Set(int pos, bit value)
        {
            if(pos < 64) 
                x0 = BitMask.set(ref x0, (byte)pos, value);
            else
                x1 = BitMask.set(ref x1, (byte)pos, value);
        }

        [MethodImpl(Inline)]
        public readonly Vec128<ulong> ToCpuVec()
            => Vec128.FromParts(x0,x1);

        /// <summary>
        /// Returns a copy of the vector
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitVector128 Replicate()
            => new BitVector128(x0,x1);

        /// <summary>
        /// Applies a truncating reduction Bv64 -> Bv8
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector8 ToBitVector8()
            => BitVector8.FromScalar(x0);

        /// <summary>
        /// Applies a truncating reduction Bv64 -> Bv16
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector16 ToBitVector16()
            => BitVector16.FromScalar(x0);

        /// <summary>
        /// Applies a truncating reduction Bv64 -> Bv32
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector32 ToBitVector32()
            => BitVector32.FromScalar(x0);

        /// <summary>
        /// Applies the identity conversion Bv64 -> Bv64
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector64 ToBitVector64()
            => BitVector64.FromScalar(x0);

        /// <summary>
        /// Converts the vector to a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitString ToBitString()
            => BitString.FromScalar(x1) + BitString.FromScalar(x0);

        [MethodImpl(Inline)]
        public readonly string FormatBits(bool tlz = false, bool specifier = false, int? blockWidth = null)
            => ToBitString().Format(tlz, specifier, blockWidth);

        [MethodImpl(Inline)]
        public readonly bool Equals(BitVector128 rhs)
            => dinx.eq(ToCpuVec(),rhs.ToCpuVec());

        public override bool Equals(object obj)
            => obj is BitVector128 x && Equals(x);
        
        public override int GetHashCode()
            => HashCode.Combine(x0,x1);

        public override string ToString()
            => FormatBits();
 
    }
}