//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Specifies data size in bits
    /// </summary>
    [ApiType, DataType]
    public readonly struct BitSize : IDataType<BitSize,ulong>
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Specifies a bit count
        /// </summary>
        public ulong Storage {get;}

        /// <summary>
        /// Computes the bit-size of a parametric type
        /// </summary>
        /// <typeparam name="T">The type to measure</typeparam>
        [MethodImpl(Inline), Closures(Closure)]
        public static int measure<T>()
            => Unsafe.SizeOf<T>()*8;

        /// <summary>
        /// Computes the quotient q :=  a / bitsize[T] of an operand a and parametric type T
        /// </summary>
        /// <param name="a">The operand</param>
        /// <typeparam name="T">The parametric type from which a bit-width will be determined</typeparam>
        [MethodImpl(Inline), Closures(Closure)]
        public static int div<T>(int a, T t = default)
            where T : unmanaged
                => a / (Unsafe.SizeOf<T>()*8);

        /// <summary>
        /// Computes the remainder r :=  a % bitsize[T] of an operand a and parametric type T
        /// </summary>
        /// <param name="a">The operand</param>
        /// <typeparam name="T">The parametric type from which a bit-width will be determined</typeparam>
        [MethodImpl(Inline), Closures(Closure)]
        public static int mod<T>(int a, T t = default)
            where T : unmanaged
                => a % (Unsafe.SizeOf<T>()*8);

        [MethodImpl(Inline)]
        public BitSize(sbyte bits)
            => Storage = (ulong)bits;

        [MethodImpl(Inline)]
        public BitSize(byte bits)
            => Storage = bits;

        [MethodImpl(Inline)]
        public BitSize(ushort bits)
            => Storage = bits;

        [MethodImpl(Inline)]
        public BitSize(int bits)
            => Storage = (ulong)bits;

        [MethodImpl(Inline)]
        public BitSize(uint bits)
            => Storage = bits;

        [MethodImpl(Inline)]
        public BitSize(long bits)
            => Storage = (ulong)bits;

        [MethodImpl(Inline)]
        public BitSize(ulong bits)
            => Storage = bits;

        public ByteSize Bytes
        {
            [MethodImpl(Inline)]
            get => Storage/8;
        }

        [MethodImpl(Inline)]
        public bool Equals(BitSize rhs)
            => Storage == rhs.Storage;

        public override string ToString()
            => Storage.ToString();

        public override int GetHashCode()
            => (int)Storage;

        public override bool Equals(object obj)
            => obj is BitSize x && Equals(x);

        [MethodImpl(Inline)]
        public static implicit operator long(BitSize src)
            => (long)src.Storage;

        [MethodImpl(Inline)]
        public static implicit operator ulong(BitSize src)
            => src.Storage;

        [MethodImpl(Inline)]
        public static implicit operator BitSize(long src)
            => new BitSize(src);

        [MethodImpl(Inline)]
        public static implicit operator BitSize(ulong src)
            => new BitSize(src);

        [MethodImpl(Inline)]
        public static explicit operator ByteSize(BitSize src)
            => src.Bytes;

        [MethodImpl(Inline)]
        public static implicit operator BitSize(DataWidth src)
            => new BitSize((uint)src);

        [MethodImpl(Inline)]
        public static implicit operator DataWidth(BitSize src)
            => (DataWidth)src.Storage;

        [MethodImpl(Inline)]
        public static implicit operator BitSize(TypeWidth src)
            => new BitSize((uint)src);

        [MethodImpl(Inline)]
        public static implicit operator TypeWidth(BitSize src)
            => (TypeWidth)src.Storage;

        [MethodImpl(Inline)]
        public static implicit operator BitSize(VectorWidth src)
            => new BitSize((uint)src);

        [MethodImpl(Inline)]
        public static implicit operator BitSize(NumericWidth src)
            => new BitSize((uint)src);

        [MethodImpl(Inline)]
        public static implicit operator NumericWidth(BitSize src)
            => (NumericWidth)src.Storage;

        [MethodImpl(Inline)]
        public static explicit operator BitSize(byte src)
            => new BitSize(src);

        [MethodImpl(Inline)]
        public static explicit operator BitSize(ushort src)
            => new BitSize(src);

        [MethodImpl(Inline)]
        public static implicit operator BitSize(uint src)
            => new BitSize(src);

        [MethodImpl(Inline)]
        public static implicit operator byte(BitSize src)
            => (byte)src.Storage;

        [MethodImpl(Inline)]
        public static explicit operator int(BitSize src)
            => (int)src.Storage;

        [MethodImpl(Inline)]
        public static explicit operator uint(BitSize src)
            => (uint)src.Storage;

        [MethodImpl(Inline)]
        public static explicit operator double(BitSize src)
            => src.Storage;

        [MethodImpl(Inline)]
        public static implicit operator BitSize(ByteSize src)
            => new BitSize(src.Storage * 8);

        [MethodImpl(Inline)]
        public static bool operator ==(BitSize lhs, BitSize rhs)
            => lhs.Storage == rhs.Storage;

        [MethodImpl(Inline)]
        public static bool operator !=(BitSize lhs, BitSize rhs)
            => lhs.Storage != rhs.Storage;

        [MethodImpl(Inline)]
        public static BitSize operator +(BitSize lhs, BitSize rhs)
            => lhs.Storage + rhs.Storage;

        [MethodImpl(Inline)]
        public static BitSize operator -(BitSize lhs, BitSize rhs)
            => lhs.Storage - rhs.Storage;

        [MethodImpl(Inline)]
        public static BitSize operator *(BitSize lhs, BitSize rhs)
            => lhs.Storage * rhs.Storage;

        [MethodImpl(Inline)]
        public static BitSize operator /(BitSize lhs, BitSize rhs)
            => lhs.Storage / rhs.Storage;

        [MethodImpl(Inline)]
        public static BitSize operator %(BitSize lhs, BitSize rhs)
            => lhs.Storage % rhs.Storage;

        /// <summary>
        /// The bit with no size
        /// </summary>
        public static BitSize Empty
            => default;

        /// <summary>
        /// The bit with no size
        /// </summary>
        public static BitSize Zero
            => default;
    }
}