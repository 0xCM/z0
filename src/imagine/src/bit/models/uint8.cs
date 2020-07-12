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

    using S = octet;
    using W = W8;
    using K = BitSeq8;
    using T = System.Byte;
    using N = N8;

    /// <summary>
    /// Represents the value of a type-level octet and thus is an integer in the range [0,255]
    /// </summary>
    public readonly struct octet : ISmallInt<S,W,K,T>
    {
        internal readonly byte data;

        public const byte MinVal = 0;

        public const byte MaxVal = byte.MaxValue;

        public const byte Width = 8; 

        public const uint Count = 256;       

        public static W W => default;

        /// <summary>
        /// Specifies the minimum <see cref='S'/> value
        /// </summary>
        public static S Min 
        {
            [MethodImpl(Inline)]
            get => new S(MinVal);
        }

        /// <summary>
        /// Specifies the maximum <see cref='S'/> value
        /// </summary>
        public static S Max 
        {
            [MethodImpl(Inline)]
            get => new S(MaxVal);
        }

        public static S Zero => 0;

        public static S One => 1;

        public static N N => default;
        
        public static Symbols<K,S,N> Symbols 
            => Symbolic.bits<S>(N);
                
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
        public static implicit operator byte(S src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator sbyte(S src)
            => (sbyte)src.data;

        [MethodImpl(Inline)]
        public static explicit operator short(S src)
            => (short)src.data;

        [MethodImpl(Inline)]
        public static implicit operator ushort(S src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator uint16_t(S src)
            => (ushort)src.data;

        [MethodImpl(Inline)]
        public static implicit operator uint32_t(S src)
            => (uint)src.data;

        [MethodImpl(Inline)]
        public static implicit operator uint64_t(S src)
            => (ulong)src.data;

        [MethodImpl(Inline)]
        public static explicit operator int(S src)
            => (int)src.data;

        [MethodImpl(Inline)]
        public static implicit operator uint(S src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator long(S src)
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
            => wrap(~ src.data);

        [MethodImpl(Inline)]
        public static S operator - (S src) 
            => wrap(~src.data + 1);

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
            get => data == MaxVal;
        }

        /// <summary>
        /// Specifies whether the current value is the minimum value
        /// </summary>
        public bool IsMin
        {
            [MethodImpl(Inline)]
            get => data == MinVal;
        }

        [MethodImpl(Inline)]    
        public octet(byte x)
            => data = x;

        [MethodImpl(Inline)]    
        public octet(K x)
            => data =(byte)x;

        [MethodImpl(Inline)]
        internal octet(BitState src)
            => data = (byte)src;

        [MethodImpl(Inline)]
        static S wrap(int x)
            => new S((byte)x);

        [MethodImpl(Inline)]
        public bool Equals(S rhs)
            => data == rhs.data;
        
        public uint Hash
        {
            [MethodImpl(Inline)]
            get => data;
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