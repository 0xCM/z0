//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Konst;

    using analog = octet;
    using BK = Octet;
    using N = N8;

    /// <summary>
    /// Represents the value of a type-level octet and thus is an integer in the range [0,255]
    /// </summary>
    public struct octet : IEquatable<analog>
    {
        byte data;

        public const byte Min8u = 0;

        public const byte Max8u = byte.MaxValue;

        public const int Width = 8;        

        public static analog Min => Min8u;

        public static analog Max => Max8u;

        public static analog Zero => 0;

        public static analog One => 1;

        public static N N => default;

        public static Symbols<BK,analog,N> Symbols 
            => Symbolic.bits<analog>(N);
        
        [MethodImpl(Inline)]
        public static implicit operator analog(BK src)
            => new analog(src);

        [MethodImpl(Inline)]
        public static implicit operator BK(analog src)
            => (BK)src.data;

        [MethodImpl(Inline)]    
        public octet(byte x)
            => data =x;

        [MethodImpl(Inline)]    
        public octet(BK x)
            => data =(byte)x;

        [MethodImpl(Inline)]    
        public static analog @bool(bool x)
            => x ? One : Zero;

        [MethodImpl(Inline)]    
        public static bool operator true(analog x)
            => x.data != 0;

        [MethodImpl(Inline)]    
        public static bool operator false(analog x)
            => x.data == 0;

        [MethodImpl(Inline)]
        public static implicit operator analog(byte src)
            => new analog(src);

        [MethodImpl(Inline)]
        public static implicit operator byte(analog src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator sbyte(analog src)
            => (sbyte)src.data;

        [MethodImpl(Inline)]
        public static explicit operator short(analog src)
            => (short)src.data;

        [MethodImpl(Inline)]
        public static implicit operator ushort(analog src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator uint16_t(analog src)
            => (ushort)src.data;

        [MethodImpl(Inline)]
        public static implicit operator uint32_t(analog src)
            => (uint)src.data;

        [MethodImpl(Inline)]
        public static implicit operator uint64_t(analog src)
            => (ulong)src.data;

        [MethodImpl(Inline)]
        public static explicit operator int(analog src)
            => (int)src.data;

        [MethodImpl(Inline)]
        public static implicit operator uint(analog src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator long(analog src)
            => (long)src.data;

        [MethodImpl(Inline)]
        public static implicit operator ulong(analog src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator float(analog src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator double(analog src)
            => src.data;

        [MethodImpl(Inline)]
        public static analog operator == (analog lhs, analog rhs) 
            => @bool(lhs.data == rhs.data);

        [MethodImpl(Inline)]
        public static analog operator != (analog lhs, analog rhs) 
            => @bool(lhs.data != rhs.data);

        [MethodImpl(Inline)]
        public static analog operator + (analog lhs, analog rhs) 
            => wrap(lhs.data + rhs.data);

        [MethodImpl(Inline)]
        public static analog operator - (analog lhs, analog rhs) 
            => wrap(lhs.data - rhs.data);

        [MethodImpl(Inline)]
        public static analog operator * (analog lhs, analog rhs) 
            => wrap(lhs.data * rhs.data);

        [MethodImpl(Inline)]
        public static analog operator / (analog lhs, analog rhs) 
            => wrap(lhs.data / rhs.data);

        [MethodImpl(Inline)]
        public static analog operator % (analog lhs, analog rhs)
            => wrap(lhs.data % rhs.data);

        [MethodImpl(Inline)]
        public static analog operator < (analog lhs, analog rhs) 
            => @bool(lhs.data < rhs.data);

        [MethodImpl(Inline)]
        public static analog operator <= (analog lhs, analog rhs) 
            => @bool(lhs.data <= rhs.data);

        [MethodImpl(Inline)]
        public static analog operator > (analog lhs, analog rhs) 
            => @bool(lhs.data > rhs.data);

        [MethodImpl(Inline)]
        public static analog operator >= (analog lhs, analog rhs) 
            => @bool(lhs.data >= rhs.data);

        [MethodImpl(Inline)]
        public static analog operator & (analog lhs, analog rhs) 
            => (analog)(lhs.data & rhs.data);

        [MethodImpl(Inline)]
        public static analog operator | (analog lhs, analog rhs) 
            => wrap(lhs.data | rhs.data);

        [MethodImpl(Inline)]
        public static analog operator ^ (analog lhs, analog rhs) 
            => wrap(lhs.data ^ rhs.data);

        [MethodImpl(Inline)]
        public static analog operator >> (analog lhs, int rhs) 
            => wrap(lhs.data >> rhs);
    
        [MethodImpl(Inline)]
        public static analog operator << (analog lhs, int rhs) 
            => wrap(lhs.data << rhs);

        [MethodImpl(Inline)]
        public static analog operator ~ (analog src) 
            => wrap(~ src.data);

        [MethodImpl(Inline)]
        public static analog operator - (analog src) 
            => wrap(~src.data + 1);

        [MethodImpl(Inline)]
        public static analog operator -- (analog src) 
            =>  --src.data;

        [MethodImpl(Inline)]
        public static analog operator ++ (analog src) 
            =>  ++src.data;

        [MethodImpl(Inline)]
        static analog wrap(int x)
            => new analog((byte)x);

        [MethodImpl(Inline)]
        public bool Equals(analog rhs)
            => data == rhs.data;

        public override int GetHashCode()
            => data.GetHashCode();

        public override bool Equals(object rhs)
            => data.Equals(rhs);
        
        public override string ToString()
            => data.ToString();
    }
}