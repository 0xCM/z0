//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Konst;

    using U = uint24;
    using W = W24;
    using K = BitSeq24;
    using T = System.UInt32;
    using N = N24;
    using L = Limits24u;
    using api = Unsigned;

    public enum BitSeq24 : uint
    {
        
    }

    /// <summary>
    /// Represents the value of an unsigned integer of bit-width 24
    /// </summary>
    [ApiDataType]
    public struct uint24 : IUnsigned<U,W,K,T>
    {
        internal uint data;
 
        public const L MinVal = L.Min;

        public const L MaxVal = L.Max;

        public const uint Mask = (T)MaxVal;

        public const byte Width = 24; 

        public const uint Count = (T)MaxVal + 1u;       

        public static W W => default;

        public static N N => default;        

        /// <summary>
        /// Specifies the minimum <see cref='U'/> value
        /// </summary>
        public static U Min 
        {
            [MethodImpl(Inline)]
            get => z.@as<L,U>(MinVal);
        }

        /// <summary>
        /// Specifies the maximum <see cref='U'/> value
        /// </summary>
        public static U Max 
        {
            [MethodImpl(Inline)]
            get => z.@as<L,U>(MaxVal);
        }

        /// <summary>
        /// Specifies  <see cref='U'/> type's zero-value
        /// </summary>
        public static U Zero 
        {
            [MethodImpl(Inline)]
            get => z.@as<T,U>(0);
        }

        /// <summary>
        /// Specifies <see cref='U'/> type's one-value
        /// </summary>
        public static U One 
        {
            [MethodImpl(Inline)]
            get => z.@as<T,U>(1);
        }
                
        [MethodImpl(Inline)]
        public static implicit operator U(K src)
            => z.@as<K,U>(src);

        [MethodImpl(Inline)]
        public static implicit operator K(U src)
            => z.@as<U,K>(src);

        [MethodImpl(Inline)]    
        public static U @bool(bool x)
            => z.@as<uint,U>(z.@uint(x));

        [MethodImpl(Inline)]    
        public static bool operator true(U x)
            => x.data != 0;

        [MethodImpl(Inline)]    
        public static bool operator false(U x)
            => x.data == 0;

        [MethodImpl(Inline)]
        public static implicit operator U(byte src)
            => z.@as<T,U>(Mask & (T)src);

        [MethodImpl(Inline)]
        public static implicit operator T(U src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator sbyte(U src)
            => (sbyte)src.data;

        [MethodImpl(Inline)]
        public static explicit operator short(U src)
            => (short)src.data;

        [MethodImpl(Inline)]
        public static explicit operator ushort(U src)
            => (ushort)src.data;

        [MethodImpl(Inline)]
        public static explicit operator uint16_t(U src)
            => (ushort)src.data;

        [MethodImpl(Inline)]
        public static implicit operator uint32_t(U src)
            => (uint)src.data;

        [MethodImpl(Inline)]
        public static implicit operator uint64_t(U src)
            => (ulong)src.data;

        [MethodImpl(Inline)]
        public static implicit operator int(U src)
            => (int)src.data;

        [MethodImpl(Inline)]
        public static implicit operator long(U src)
            => (long)src.data;

        [MethodImpl(Inline)]
        public static implicit operator ulong(U src)
            => src.data;

        [MethodImpl(Inline)]
        public static U operator == (U lhs, U rhs) 
            => new U(lhs.data == rhs.data);

        [MethodImpl(Inline)]
        public static U operator != (U lhs, U rhs) 
            => new U(lhs.data != rhs.data);

        [MethodImpl(Inline)]
        public static U operator < (U lhs, U rhs) 
            => new U(lhs.data < rhs.data);

        [MethodImpl(Inline)]
        public static U operator <= (U lhs, U rhs) 
            => new U(lhs.data <= rhs.data);

        [MethodImpl(Inline)]
        public static U operator > (U lhs, U rhs) 
            => new U(lhs.data > rhs.data);

        [MethodImpl(Inline)]
        public static U operator >= (U lhs, U rhs) 
            => new U(lhs.data >= rhs.data);

        [MethodImpl(Inline)]
        public static U operator - (U src) 
            => new U(~src.data + 1u);

        [MethodImpl(Inline)]
        public static U operator -- (U src) 
            => api.dec(src);

        [MethodImpl(Inline)]
        public static U operator ++ (in U src) 
            => api.inc(src);

        [MethodImpl(Inline)]
        public static U operator + (U lhs, U rhs) 
            => reduce(lhs.data + rhs.data);

        [MethodImpl(Inline)]
        public static U operator - (U lhs, U rhs) 
            => reduce(lhs.data - rhs.data);

        [MethodImpl(Inline)]
        public static U operator * (U lhs, U rhs) 
            => reduce(lhs.data * rhs.data);

        [MethodImpl(Inline)]
        public static U operator / (U lhs, U rhs) 
            => wrap(lhs.data / rhs.data);

        [MethodImpl(Inline)]
        public static U operator % (U lhs, U rhs)
            => wrap(lhs.data % rhs.data);

        [MethodImpl(Inline)]
        public static U operator & (U lhs, U rhs) 
            => (U)(lhs.data & rhs.data);

        [MethodImpl(Inline)]
        public static U operator | (U lhs, U rhs) 
            => wrap(lhs.data | rhs.data);

        [MethodImpl(Inline)]
        public static U operator ^ (U lhs, U rhs) 
            => wrap(lhs.data ^ rhs.data);

        [MethodImpl(Inline)]
        public static U operator >> (U lhs, int rhs) 
            => wrap(lhs.data >> rhs);
    
        [MethodImpl(Inline)]
        public static U operator << (U lhs, int rhs) 
            => wrap(lhs.data << rhs);

        [MethodImpl(Inline)]
        public static U operator ~ (U src) 
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
            => data = src & (T)MaxVal;

        [MethodImpl(Inline)]    
        public uint24(bool src)
            => data = z.@uint(src);

        [MethodImpl(Inline)]    
        public uint24(byte src)
            => data = src;

        [MethodImpl(Inline)]    
        public uint24(K src)
            => data = (T)src;

        [MethodImpl(Inline)]
        internal uint24(sbyte src)
            => data = (T)src;

        [MethodImpl(Inline)]
        internal uint24(short src)
            => data = (T)src;

        [MethodImpl(Inline)]
        internal uint24(ushort src)
            => data = src;

        [MethodImpl(Inline)]    
        internal uint24(int src)
            => data = (T)src & (T)MaxVal;
        
        [MethodImpl(Inline)]
        internal uint24(long src)
            => data = (T)src & (T)MaxVal;

        [MethodImpl(Inline)]
        internal uint24(ulong src)
            => data = (T)src & (T)MaxVal;

        [MethodImpl(Inline)]
        internal uint24(T src, bool @unchecked)
            => data = src;

        [MethodImpl(Inline)]
        static U wrap(T x)
            => new U(x, true);

        [MethodImpl(Inline)]
        static U reduce(uint x) 
            => new U(x % Count);

        [MethodImpl(Inline)]
        static U dec(U x) 
        {
            var y = (long)x.data - 1;
            return y < 0 ? Max : new U((T)y, true);
        }

 
        [MethodImpl(Inline)]
        public bool Equals(U rhs)
            => data == rhs.data;
         
        [MethodImpl(Inline)]
        public string Format()
            => data.FormatAsmHex();

        [Ignore]
        bool IEquatable<U>.Equals(U rhs)
            => data == rhs.data;        

        bool IUnsigned.IsNonZero
        {
            [Ignore]
            get => IsNonZero;
        }

        K IUnsigned<U,W,K,uint>.Kind 
        {
            [Ignore]
            get => Kind;
        }

        uint IUnsigned<U,uint>.Value 
        {
            [Ignore]
            get => Value;
        }

        bool IUnsigned.IsZero 
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