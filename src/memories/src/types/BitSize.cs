//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    /// <summary>
    /// Specifies a memory size UOM in bits
    /// </summary>
    public readonly struct BitSize
    {
        /// <summary>
        /// Computes the bit-size of a parametric type
        /// </summary>
        /// <typeparam name="T">The type to measure</typeparam>
        [MethodImpl(Inline)]
        public static int measure<T>()
            => Unsafe.SizeOf<T>()*8;

        /// <summary>
        /// Specifies a bit count
        /// </summary>
        public readonly ulong Bits;

        /// <summary>
        /// Computes the quotient q :=  a / bitsize[T] of an operand a and parametric type T
        /// </summary>
        /// <param name="a">The operand</param>
        /// <typeparam name="T">The parametric type from which a bit-width will be determined</typeparam>
        [MethodImpl(Inline)]
        public static int div<T>(int a, T t = default)
            where T : unmanaged
                => a / bitsize<T>();

        /// <summary>
        /// Computes the remainder r :=  a % bitsize[T] of an operand a and parametric type T
        /// </summary>
        /// <param name="a">The operand</param>
        /// <typeparam name="T">The parametric type from which a bit-width will be determined</typeparam>
        [MethodImpl(Inline)]
        public static int mod<T>(int a, T t = default)
            where T : unmanaged
                => a % bitsize<T>();

        /// <summary>
        /// The canonical zero size
        /// </summary>
        public static BitSize Zero => default;
         
        /// <summary>
        /// Returns the minimum number of bytes required to apprehend 
        /// the size of the source bits.
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static explicit operator ByteSize(BitSize src)
            => src.MaxByteCount;

        [MethodImpl(Inline)]
        public static explicit operator byte(BitSize src)
            => (byte)src.Bits;

        [MethodImpl(Inline)]
        public static implicit operator int(BitSize src)
            => (int)src.Bits;

        [MethodImpl(Inline)]
        public static implicit operator uint(BitSize src)
            => (uint)src.Bits;

        [MethodImpl(Inline)]
        public static implicit operator long(BitSize src)
            => (long)src.Bits;

        [MethodImpl(Inline)]
        public static implicit operator ulong(BitSize src)
            => src.Bits;

        [MethodImpl(Inline)]
        public static explicit operator double(BitSize src)
            => src.Bits;

        [MethodImpl(Inline)]
        public static implicit operator BitSize(int src)
            => new BitSize((ulong)src);

        [MethodImpl(Inline)]
        public static implicit operator BitSize(long src)
            => new BitSize((ulong)src);

        [MethodImpl(Inline)]
        public static implicit operator BitSize(byte src)
            => new BitSize((ulong)src);

        [MethodImpl(Inline)]
        public static implicit operator BitSize(ushort src)
            => new BitSize((ulong)src);

        [MethodImpl(Inline)]
        public static implicit operator BitSize(uint src)
            => new BitSize((ulong)src);

        [MethodImpl(Inline)]
        public static implicit operator BitSize(ulong src)
            => new BitSize(src);

        [MethodImpl(Inline)]
        public static explicit operator BitSize(ByteSize src)
            => src.Bytes * 8;
        
        [MethodImpl(Inline)]
        public static bool operator ==(BitSize lhs, BitSize rhs)
            => lhs.Bits == rhs.Bits;

        [MethodImpl(Inline)]
        public static bool operator !=(BitSize lhs, BitSize rhs)
            => lhs.Bits != rhs.Bits;

        [MethodImpl(Inline)]
        public static BitSize operator +(BitSize lhs, BitSize rhs)
            => lhs.Bits + rhs.Bits;

        [MethodImpl(Inline)]
        public static BitSize operator -(BitSize lhs, BitSize rhs)
            => lhs.Bits - rhs.Bits;

        [MethodImpl(Inline)]
        public static BitSize operator *(BitSize lhs, BitSize rhs)
            => lhs.Bits * rhs.Bits;

        [MethodImpl(Inline)]
        public static BitSize operator /(BitSize lhs, BitSize rhs)
            => lhs.Bits / rhs.Bits;

        [MethodImpl(Inline)]
        public static BitSize operator %(BitSize lhs, BitSize rhs)
            => lhs.Bits % rhs.Bits;

        [MethodImpl(Inline)]
        public static BitSize Define(int bits)
            => new BitSize((ulong)bits);

        [MethodImpl(Inline)]
        public static BitSize Define(long bits)
            => new BitSize((ulong)bits);

        [MethodImpl(Inline)]
        public static BitSize Define(ulong bits)
            => new BitSize(bits);

        [MethodImpl(Inline)]
        public BitSize(ulong Bits)
            => this.Bits = Bits;

        public ByteSize MaxByteCount
        {
            [MethodImpl(Inline)]
            get
            {
                var q = Math.DivRem((long)Bits, 8L, out long r);
                return r == 0 ? (ulong)q : (ulong)(q + 1);
            }
        }

        [MethodImpl(Inline)]
        public bool Equals(BitSize rhs)
            => Bits == rhs.Bits;

        public override string ToString()
            => Bits.ToString();

        public override int GetHashCode()
            => Bits.GetHashCode();

        public override bool Equals(object obj)
            => obj is BitSize x && Equals(x);
    }
}