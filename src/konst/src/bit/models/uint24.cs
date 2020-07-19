//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Konst;
    using static Bit;

    using S = uint24;
    using W = W24;
    using K = BitSeq24;
    using T = System.UInt32;
    using N = N24;

    public enum BitSeq24 : uint
    {
        
    }

    /// <summary>
    /// Represents the value of an unsigned integer of bit-width 24
    /// </summary>
    [ApiDataType]
    public readonly struct uint24 : IBitSequence<S,W,K,T>
    {
        readonly byte byte0;

        readonly byte byte1;

        readonly byte byte2;

        readonly byte byte3;


        public const Limits24u MinVal = Limits24u.Min;

        public const Limits24u MaxVal = Limits24u.Max;

        public const byte Width = 24; 

        public const uint Count = (T)MaxVal + 1u;       

        public static W W => default;

        /// <summary>
        /// Specifies the minimum <see cref='S'/> value
        /// </summary>
        public static S Min 
        {
            [MethodImpl(Inline)]
            get => new S((T)MinVal);
        }

        /// <summary>
        /// Specifies the maximum <see cref='S'/> value
        /// </summary>
        public static S Max 
        {
            [MethodImpl(Inline)]
            get => new S((T)MaxVal);
        }

        public static S Zero 
        {
            [MethodImpl(Inline)]
            get => 0;
        }

        public static S One 
        {
            [MethodImpl(Inline)]
            get => 1;
        }

        public static N N => default;        
                
        [MethodImpl(Inline)]
        public static implicit operator S(K src)
            => new S(src);

        [MethodImpl(Inline)]
        public static implicit operator K(S src)
            => (K)src.data;

        [MethodImpl(Inline)]    
        public static S @bool(bool x)
            => x ? One : Zero;

        [MethodImpl(Inline)]    
        public static bool operator true(S x)
            => x.data != 0;

        [MethodImpl(Inline)]    
        public static bool operator false(S x)
            => x.data == 0;

        [MethodImpl(Inline)]
        public static implicit operator S(byte src)
            => new S(src);

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
        public static implicit operator float(S src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator double(S src)
            => src.data;

        [MethodImpl(Inline)]
        public static S operator == (S lhs, S rhs) 
            => @bool(lhs.data == rhs.data);

        [MethodImpl(Inline)]
        public static S operator != (S lhs, S rhs) 
            => @bool(lhs.data != rhs.data);

        [MethodImpl(Inline)]
        public static S operator + (S lhs, S rhs) 
            => wrap(lhs.data + rhs.data);

        [MethodImpl(Inline)]
        public static S operator - (S lhs, S rhs) 
            => wrap(lhs.data - rhs.data);

        [MethodImpl(Inline)]
        public static S operator * (S lhs, S rhs) 
            => wrap(lhs.data * rhs.data);

        [MethodImpl(Inline)]
        public static S operator / (S lhs, S rhs) 
            => wrap(lhs.data / rhs.data);

        [MethodImpl(Inline)]
        public static S operator % (S lhs, S rhs)
            => wrap(lhs.data % rhs.data);

        [MethodImpl(Inline)]
        public static S operator < (S lhs, S rhs) 
            => @bool(lhs.data < rhs.data);

        [MethodImpl(Inline)]
        public static S operator <= (S lhs, S rhs) 
            => @bool(lhs.data <= rhs.data);

        [MethodImpl(Inline)]
        public static S operator > (S lhs, S rhs) 
            => @bool(lhs.data > rhs.data);

        [MethodImpl(Inline)]
        public static S operator >= (S lhs, S rhs) 
            => @bool(lhs.data >= rhs.data);

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

        [MethodImpl(Inline)]
        public static S operator - (S src) 
            => wrap(~src.data + 1u);

        [MethodImpl(Inline)]
        public static S operator -- (S src) 
            => dec(src);

        [MethodImpl(Inline)]
        public static S operator ++ (S src) 
            => inc(src);

        /// <summary>
        /// Queries the state of an index-identified bit
        /// </summary>
        public BitState this[byte pos]
        {
            [MethodImpl(Inline)]
            get => Bit.test(this, pos);                    
        }

        public K Kind
        {
            [MethodImpl(Inline)]
            get => (K) data;
        }
        
        public T Value
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
        {
            byte0 = (byte)(z.uint32(src) >> 0);
            byte1 = (byte)(z.uint32(src) >> 8);
            byte2 = (byte)(z.uint32(src) >> 16);
            byte3 = 0;
        }

        [MethodImpl(Inline)]    
        public uint24(byte x)
            : this()
        {
            byte0 = x;
        }

        [MethodImpl(Inline)]    
        public uint24(K x)
            : this((T)x)
        {
            
        }

        [MethodImpl(Inline)]
        internal uint24(sbyte src)
            : this()
        {
            byte0 = (byte)src;
        }

        [MethodImpl(Inline)]
        internal uint24(short src)
            : this()
        {
            byte0 = (byte)(src);
            byte1 = (byte)((uint)src >> 8);
        }

        [MethodImpl(Inline)]
        internal uint24(ushort src)
            : this()
        {
            byte0 = (byte)(src);
            byte1 = (byte)((uint)src >> 8);
        }

        [MethodImpl(Inline)]    
        internal uint24(int src)
            : this()
        {
            byte0 = (byte)(src);
            byte1 = (byte)((uint)src >> 8);
            byte2 = (byte)((uint)src >> 16);
        }
        
        [MethodImpl(Inline)]
        internal uint24(long src)
            : this((uint)src & (uint)MaxVal)
        {
            
        }

        [MethodImpl(Inline)]
        internal uint24(ulong src)
            : this((uint)src & (uint)MaxVal)
        {
            
        }

        [MethodImpl(Inline)]
        static S wrap(T x)
            => new S(x);

        [MethodImpl(Inline)]
        public bool Equals(S rhs)
            => data == rhs.data;
        
        public uint Hash
        {
            [MethodImpl(Inline)]
            get => data;
        }

        internal uint data 
        {
            [MethodImpl(Inline)]
            get => z.@as<uint24,uint>(this);
        }

        public override int GetHashCode()
            => (int)Hash;

        public override bool Equals(object rhs)
            => data.Equals(rhs);
        public string Format()
            => data.FormatAsmHex();

        public override string ToString()
            => data.ToString();
    }
}