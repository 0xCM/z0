//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    using S = uint24;
    using W = W24;
    using K = BitSeq24;
    using T = System.UInt32;
    using N = N24;
    using L = Limits24u;

    using api = Sized;

    public enum BitSeq24 : uint
    {

    }

    /// <summary>
    /// Represents the value of an unsigned integer of bit-width 24
    /// </summary>
    [ApiDataType, StructLayout(LayoutKind.Sequential, Size = Size)]
    public struct uint24 : ISizedInt<S,W,K,T>
    {
        internal ushort Lo;

        internal byte Hi;

        internal uint data
        {
            [MethodImpl(Inline)]
            get => (uint)Lo | ((uint)Hi << 16);

            [MethodImpl(Inline)]
            set => api.update(value, ref this);
        }

        public const L MinVal = L.Min;

        public const L MaxVal = L.Max;

        public const uint Mask = (T)MaxVal;

        /// <summary>
        /// Specifies the bit-width represented by <see cref='S'/>
        /// </summary>
        public const byte Width = 24;

        public const byte Size = 3;

        public const uint Count = (T)MaxVal + 1u;

        public static W W => default;

        public static N N => default;

        /// <summary>
        /// Specifies the minimum <see cref='S'/> value
        /// </summary>
        public static S Min
        {
            [MethodImpl(Inline)]
            get => z.@as<L,S>(MinVal);
        }

        /// <summary>
        /// Specifies the maximum <see cref='S'/> value
        /// </summary>
        public static S Max
        {
            [MethodImpl(Inline)]
            get => z.@as<L,S>(MaxVal);
        }

        /// <summary>
        /// Specifies  <see cref='S'/> type's zero-value
        /// </summary>
        public static S Zero
        {
            [MethodImpl(Inline)]
            get => z.@as<T,S>(0);
        }

        /// <summary>
        /// Specifies <see cref='S'/> type's one-value
        /// </summary>
        public static S One
        {
            [MethodImpl(Inline)]
            get => z.@as<T,S>(1);
        }

        [MethodImpl(Inline)]
        public static implicit operator S(K src)
            => z.@as<K,S>(src);

        [MethodImpl(Inline)]
        public static implicit operator K(S src)
            => z.@as<S,K>(src);

        [MethodImpl(Inline)]
        public static S @bool(bool x)
            => z.@as<uint,S>(z.@uint(x));

        [MethodImpl(Inline)]
        public static bool operator true(S x)
            => x.data != 0;

        [MethodImpl(Inline)]
        public static bool operator false(S x)
            => x.data == 0;

        [MethodImpl(Inline)]
        public static implicit operator S(byte src)
            => z.@as<T,S>(Mask & (T)src);

        [MethodImpl(Inline)]
        public static implicit operator T(S src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator sbyte(S src)
            => (sbyte)src.data;

        [MethodImpl(Inline)]
        public static explicit operator short(S src)
            => (short)src.data;

        [MethodImpl(Inline)]
        public static explicit operator ushort(S src)
            => (ushort)src.data;

        [MethodImpl(Inline)]
        public static explicit operator uint16_t(S src)
            => (ushort)src.data;

        [MethodImpl(Inline)]
        public static implicit operator uint32_t(S src)
            => (uint)src.data;

        [MethodImpl(Inline)]
        public static implicit operator uint64_t(S src)
            => (ulong)src.data;

        [MethodImpl(Inline)]
        public static implicit operator int(S src)
            => (int)src.data;

        [MethodImpl(Inline)]
        public static implicit operator long(S src)
            => (long)src.data;

        [MethodImpl(Inline)]
        public static implicit operator ulong(S src)
            => src.data;

        [MethodImpl(Inline)]
        public static S operator == (S lhs, S rhs)
            => new S(lhs.data == rhs.data);

        [MethodImpl(Inline)]
        public static S operator != (S lhs, S rhs)
            => new S(lhs.data != rhs.data);

        [MethodImpl(Inline)]
        public static S operator < (S lhs, S rhs)
            => new S(lhs.data < rhs.data);

        [MethodImpl(Inline)]
        public static S operator <= (S lhs, S rhs)
            => new S(lhs.data <= rhs.data);

        [MethodImpl(Inline)]
        public static S operator > (S lhs, S rhs)
            => new S(lhs.data > rhs.data);

        [MethodImpl(Inline)]
        public static S operator >= (S lhs, S rhs)
            => new S(lhs.data >= rhs.data);

        [MethodImpl(Inline)]
        public static S operator - (S src)
            => new S(~src.data + 1u);

        [MethodImpl(Inline)]
        public static S operator -- (S src)
            => api.dec(src);

        [MethodImpl(Inline)]
        public static S operator ++ (in S src)
            => api.inc(src);

        [MethodImpl(Inline)]
        public static S operator + (S lhs, S rhs)
            => reduce(lhs.data + rhs.data);

        [MethodImpl(Inline)]
        public static S operator - (S lhs, S rhs)
            => reduce(lhs.data - rhs.data);

        [MethodImpl(Inline)]
        public static S operator * (S lhs, S rhs)
            => reduce(lhs.data * rhs.data);

        [MethodImpl(Inline)]
        public static S operator / (S lhs, S rhs)
            => wrap(lhs.data / rhs.data);

        [MethodImpl(Inline)]
        public static S operator % (S lhs, S rhs)
            => wrap(lhs.data % rhs.data);

        [MethodImpl(Inline)]
        public static S operator & (S lhs, S rhs)
            => (S)(lhs.data & rhs.data);

        [MethodImpl(Inline)]
        public static S operator | (S lhs, S rhs)
            => wrap(lhs.data | rhs.data);

        [MethodImpl(Inline)]
        public static S operator ^ (S lhs, S rhs)
            => wrap(lhs.data ^ rhs.data);

        [MethodImpl(Inline)]
        public static S operator >> (S lhs, int rhs)
            => wrap(lhs.data >> rhs);

        [MethodImpl(Inline)]
        public static S operator << (S lhs, int rhs)
            => wrap(lhs.data << rhs);

        [MethodImpl(Inline)]
        public static S operator ~ (S src)
            => wrap(~src.data);

        /// <summary>
        /// Queries the state of an index-identified bit
        /// </summary>
        public BitState this[byte pos]
        {
            [MethodImpl(Inline)]
            get => z.test(data, pos);
        }

        public K Kind
        {
            [MethodImpl(Inline)]
            get => (K) data;
        }

        T Value
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public bool IsZero
        {
            [MethodImpl(Inline)]
            get => data == 0;
        }

        public bool IsNonZero
        {
            [MethodImpl(Inline)]
            get => data != 0;
        }

        /// <summary>
        /// Specifies whether the current value is the maximum value
        /// </summary>
        public bool IsMax
        {
            [MethodImpl(Inline)]
            get => data == (T)MaxVal;
        }

        /// <summary>
        /// Specifies whether the current value is the minimum value
        /// </summary>
        public bool IsMin
        {
            [MethodImpl(Inline)]
            get => data == (T)MinVal;
        }

        [MethodImpl(Inline)]
        internal uint24(T src)
            : this() => data = src & (T)MaxVal;

        [MethodImpl(Inline)]
        public uint24(bool src)
            : this() => Lo = @byte(src);

        [MethodImpl(Inline)]
        public uint24(byte src)
            : this() => Lo = src;

        [MethodImpl(Inline)]
        public uint24(K src)
            : this() => api.update((T)src, ref this);

        [MethodImpl(Inline)]
        internal uint24(sbyte src)
            : this() => Lo = (byte)src;

        [MethodImpl(Inline)]
        internal uint24(short src)
            : this() => Lo = (ushort)src;

        [MethodImpl(Inline)]
        internal uint24(ushort src)
            : this() => Lo = src;

        [MethodImpl(Inline)]
        internal uint24(int src)
            : this() => data = (T)src & (T)MaxVal;

        [MethodImpl(Inline)]
        internal uint24(long src)
            : this() => data = (T)src & (T)MaxVal;

        [MethodImpl(Inline)]
        internal uint24(ulong src)
            : this() => data = (T)src & (T)MaxVal;

        [MethodImpl(Inline)]
        internal uint24(T src, bool @unchecked)
            : this() => data = src;

        [MethodImpl(Inline)]
        static S wrap(T x)
            => new S(x, true);

        [MethodImpl(Inline)]
        static S reduce(uint x)
            => new S(x % Count);

        [MethodImpl(Inline)]
        static S dec(S x)
        {
            var y = (long)x.data - 1;
            return y < 0 ? Max : new S((T)y, true);
        }

        [MethodImpl(Inline)]
        public bool Equals(S rhs)
            => data == rhs.data;

        [MethodImpl(Inline)]
        public string Format()
            => data.FormatAsmHex();

        [Ignore]
        bool IEquatable<S>.Equals(S rhs)
            => data == rhs.data;

        bool ISizedInt.IsNonZero
        {
            [Ignore]
            get => IsNonZero;
        }

        K ISizedInt<S,W,K,uint>.Kind
        {
            [Ignore]
            get => Kind;
        }

        uint ISizedInt<S,uint>.Value
        {
            [Ignore]
            get => Value;
        }

        bool ISizedInt.IsZero
        {
            [Ignore]
            get => IsZero;
        }

        uint IHashed.Hash
        {
            [Ignore]
            get => data;
        }

        [Ignore]
        public override int GetHashCode()
            => (int)data;

        [Ignore]
        public override bool Equals(object rhs)
            => data.Equals(rhs);

        [Ignore]
        string ITextual.Format()
            => Format();

        [Ignore]
        public override string ToString()
            => Format();
    }
}