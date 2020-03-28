//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static root;

    using analog = uint4_t;

    public struct uint4_t : IEquatable<analog>
    {
        byte data;

        public static analog zero => 0;

        public static analog one => 1;

        [MethodImpl(Inline)]    
        public static uint4_t From(byte src)
            => new analog(src);

        [MethodImpl(Inline)]    
        public static uint4_t From(int src)
            => new analog(src);

        [MethodImpl(Inline)]    
        public static uint4_t From(uint src)
            => new analog(src);

        [MethodImpl(Inline)]    
        uint4_t(byte x)
            => data = (byte)((uint)x & 0xFu);

        [MethodImpl(Inline)]    
        uint4_t(uint x)
            => data = (byte)(x & 0xFu);

        [MethodImpl(Inline)]    
        uint4_t(int x)
            => data = (byte)((uint)x & 0xFu);

        [MethodImpl(Inline)]    
        public static analog @bool(bool x)
            => x ? one : zero;

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
        public static explicit operator byte(analog src)
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
        public static implicit operator uint8_t(analog src)
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
        public static analog operator == (analog lhs, analog rhs) 
            => @bool(lhs.data == rhs.data);

        [MethodImpl(Inline)]
        public static analog operator != (analog lhs, analog rhs) 
            => @bool(lhs.data != rhs.data);

        [MethodImpl(Inline)]
        public static analog operator + (analog lhs, analog rhs) 
            => From(lhs.data + rhs.data);

        [MethodImpl(Inline)]
        public static analog operator - (analog lhs, analog rhs) 
            => From(lhs.data - rhs.data);

        [MethodImpl(Inline)]
        public static analog operator * (analog lhs, analog rhs) 
            => From(lhs.data * rhs.data);

        [MethodImpl(Inline)]
        public static analog operator / (analog lhs, analog rhs) 
            => From(lhs.data / rhs.data);

        [MethodImpl(Inline)]
        public static analog operator % (analog lhs, analog rhs)
            => From(lhs.data % rhs.data);

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
            => From(lhs.data & rhs.data);

        [MethodImpl(Inline)]
        public static analog operator | (analog lhs, analog rhs) 
            => From(lhs.data | rhs.data);

        [MethodImpl(Inline)]
        public static analog operator ^ (analog lhs, analog rhs) 
            => From(lhs.data ^ rhs.data);

        [MethodImpl(Inline)]
        public static analog operator >> (analog lhs, int rhs) 
            => From(lhs.data >> rhs);
    
        [MethodImpl(Inline)]
        public static analog operator << (analog lhs, int rhs) 
            => From(lhs.data << rhs);

        [MethodImpl(Inline)]
        public static analog operator ~ (analog src) 
            => From(~src.data);

        [MethodImpl(Inline)]
        public static analog operator - (analog src) 
            => From(~src.data + 1);

        [MethodImpl(Inline)]
        public static analog operator -- (analog src) 
            => From(--src.data);

        [MethodImpl(Inline)]
        public static analog operator ++ (analog src) 
            =>  From(++src.data);

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
