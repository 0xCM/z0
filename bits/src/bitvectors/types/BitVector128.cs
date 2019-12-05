//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    

    [StructLayout(LayoutKind.Sequential)]
    public struct BitVector128
    {
        internal ulong x0;

        internal ulong x1;

        public static N128 N => default;
         
        /// <summary>
        /// Allocates a vector with all bits disabled
        /// </summary>
        public static BitVector128 Zero => default;

        /// <summary>
        /// Allocates a vector that has the least bit enabled and all others disabled
        /// </summary>
        public static BitVector128 One => BitVector.from(N,1);

        /// <summary>
        /// Allocates a vector with all bits enabled
        /// </summary>
        public static BitVector128 Ones => BitVector.from(N,UInt64.MaxValue, UInt64.MaxValue);

        /// <summary>
        /// Implicitly converts a scalar value to a 128-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector128(byte src)
            => BitVector.from(N,src);

        /// <summary>
        /// Implicitly converts a scalar value to a 128-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector128(ushort src)
            => BitVector.from(N,src);

        /// <summary>
        /// Implicitly converts a scalar value to a 128-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector128(uint src)
            => BitVector.from(N,src);

        /// <summary>
        /// Implicitly converts a scalar value to a 128-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector128(ulong src)
            => BitVector.from(N,src);

        /// <summary>
        /// Implicitly converts a scalar value to a 128-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector128(BitVector8 src)
            => BitVector.from(N,src);

        /// <summary>
        /// Implicitly converts a scalar value to a 128-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector128(BitVector16 src)
            => BitVector.from(N,src);

        /// <summary>
        /// Implicitly converts a scalar value to a 128-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector128(BitVector32 src)
            => BitVector.from(N,src);

        /// <summary>
        /// Implicitly converts a scalar value to a 128-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector128(BitVector64 src)
            => BitVector.from(N,src);

        /// <summary>
        /// Explicitly truncates the source to 8 bits
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static explicit operator BitVector8(in BitVector128 src)
            => BitVector.from(n8, src.x0);

        /// <summary>
        /// Explicitly truncates the source to 16 bits
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static explicit operator BitVector16(in BitVector128 src)
            => BitVector.from(n16, src.x0);

        /// <summary>
        /// Explicitly truncates the source to 32 bits
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static explicit operator BitVector32(in BitVector128 src)
            => BitVector.from(n32, src.x0);

        /// <summary>
        /// Explicitly truncates the source to 64 bits
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static explicit operator BitVector64(in BitVector128 src)
            => BitVector.from(n64, src.x0);

        [MethodImpl(Inline)]    
        public static implicit operator BitVector128((ulong x0, ulong x1) src)
            => new BitVector128(src.x0, src.x1);

        [MethodImpl(Inline)]    
        public static implicit operator (ulong x0, ulong x1)(in BitVector128 src)
            => (src.x0, src.x1);

        /// <summary>
        /// Computes the bitwise AND of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector128 operator &(in BitVector128 x, in BitVector128 y)
            => BitVector.and(x,y);

        /// <summary>
        /// Computes the bitwise OR of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector128 operator |(in BitVector128 x, in BitVector128 y)
            => BitVector.or(x,y);

        /// <summary>
        /// Computes the bitwise XOR of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector128 operator ^(in BitVector128 x, in BitVector128 y)
            => BitVector.xor(x,y);

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static bit operator %(in BitVector128 x, in BitVector128 y)
            => BitVector.dot(x,y);

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector128 operator ~(in BitVector128 x)
            => BitVector.not(x);

        /// <summary>
        /// Computes the two's complement of the operand
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector128 operator -(in BitVector128 x)
            => BitVector.negate(x);

        /// <summary>
        /// Computes the arithmetic difference between the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector128 operator - (in BitVector128 x, in BitVector128 y)
            => BitVector.sub(x,y);

        /// <summary>
        /// Computes the arithmetic sum of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector128 operator + (in BitVector128 x, in BitVector128 y)
            => BitVector.add(x,y);

        /// <summary>
        /// Arithmetically increments the operand
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector128 operator ++(in BitVector128 x)
            => BitVector.inc(x);

        /// <summary>
        /// Arithmetically decrements the operand
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector128 operator --(in BitVector128 x)
            => BitVector.dec(x);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(in BitVector128 src)
            => src.Nonempty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(in BitVector128 src)
            => !src.Nonempty;

        [MethodImpl(Inline)]
        public static Bit operator !(in BitVector128 src)
            => src.Empty;

        [MethodImpl(Inline)]
        public static bit operator ==(in BitVector128 x, in BitVector128 y)
           => x.x0 == y.x0 && x.x1 == y.x1;

        [MethodImpl(Inline)]
        public static bit operator !=(in BitVector128 x, in BitVector128 y)
           => (x.x0 != y.x0) || (x.x1 != y.x1);

        [MethodImpl(Inline)]    
        public BitVector128(ulong x0, ulong x1)
        {
            this.x0 = x0;
            this.x1 = x1;
        }

        [MethodImpl(Inline)]    
        public BitVector128(uint x00, uint x01, uint x10, uint x11)
        {
            this.x0 = Bits.concat(x00,x01);
            this.x1 = Bits.concat(x10, x11);
        }

        /// <summary>
        /// The vector's 64 least significant bits
        /// </summary>
        public BitVector64 Lo
        {
            [MethodImpl(Inline)]
            get => x0;
        }

        /// <summary>
        /// The vector's 64 most significant bits
        /// </summary>
        public BitVector64 Hi
        {
            [MethodImpl(Inline)]
            get => x1;
        }
        
        /// <summary>
        /// The number of bits represented by the vector
        /// </summary>
        public readonly int Width
        {
            [MethodImpl(Inline)]
            get => 128;
        }

        /// <summary>
        /// Returns true if no bits are enabled, false otherwise
        /// </summary>
        public bool Empty
        {
            [MethodImpl(Inline)]
            get => x0 == 0 && x1 == 0;
        }

        /// <summary>
        /// Returns true if the vector has at least one enabled bit; false otherwise
        /// </summary>
        public bool Nonempty
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
        /// Sets a bit to a specified value
        /// </summary>
        /// <param name="pos">The position of the bit to set</param>
        /// <param name="value">The bit value</param>
        [MethodImpl(Inline)]
        public void Set(int pos, bit value)
        {
            if(pos < 64) 
                x0 = BitMask.set(x0, (byte)pos, value);
            else
                x1 = BitMask.set(x1, (byte)pos, value);
        }

        [MethodImpl(Inline)]
        public bool Equals(BitVector128 rhs)
            => x0 == rhs.x0 && x1 == rhs.x1;

        public override bool Equals(object obj)
            => obj is BitVector128 x && Equals(x);

        
        public override int GetHashCode()
            => HashCode.Combine(x0,x1);

        public override string ToString()
            => this.Format(); 
    }
}