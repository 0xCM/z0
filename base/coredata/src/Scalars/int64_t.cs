//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using static zfunc;

    using prim = System.Int64;
    using analog = int64_t;

    public struct int64_t : IEquatable<analog>
    {

        prim data;

        public static analog zero => 0;

        public static analog one => 1;

        public const int bitsize = 64;
        

        [MethodImpl(Inline)]    
        public int64_t(prim x)
            => data =x;

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
        public static implicit operator analog(prim src)
            => new analog(src);

        [MethodImpl(Inline)]
        public static implicit operator prim(analog src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator byte(analog src)
            => (byte)src.data;

        [MethodImpl(Inline)]
        public static explicit operator sbyte(analog src)
            => (sbyte)src.data;

        [MethodImpl(Inline)]
        public static explicit operator short(analog src)
            => (short)src.data;

        [MethodImpl(Inline)]
        public static explicit operator ushort(analog src)
            => (ushort)src.data;

        [MethodImpl(Inline)]
        public static explicit operator int(analog src)
            => (int)src.data;

        [MethodImpl(Inline)]
        public static explicit operator uint(analog src)
            => (uint)src.data;

        [MethodImpl(Inline)]
        public static explicit operator ulong(analog src)
            => (ulong)src.data;

        [MethodImpl(Inline)]
        public static explicit operator float(analog src)
            => (float)src.data;

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
            => lhs.data + rhs.data;

        [MethodImpl(Inline)]
        public static analog operator - (analog lhs, analog rhs) 
            => lhs.data - rhs.data;

        [MethodImpl(Inline)]
        public static analog operator * (analog lhs, analog rhs) 
            => lhs.data * rhs.data;

        [MethodImpl(Inline)]
        public static analog operator / (analog lhs, analog rhs) 
            => lhs.data / rhs.data;

        [MethodImpl(Inline)]
        public static analog operator % (analog lhs, analog rhs)
            => lhs.data % rhs.data;

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
            => lhs.data & rhs.data;

        [MethodImpl(Inline)]
        public static analog operator | (analog lhs, analog rhs) 
            => lhs.data | rhs.data;

        [MethodImpl(Inline)]
        public static analog operator ^ (analog lhs, analog rhs) 
            => lhs.data ^ rhs.data;

        [MethodImpl(Inline)]
        public static analog operator >> (analog lhs, int rhs) 
            => lhs.data >> rhs;
        
        [MethodImpl(Inline)]
        public static analog operator << (analog lhs, int rhs) 
            => lhs.data << rhs;

        [MethodImpl(Inline)]
        public static analog operator ~ (analog src) 
            => ~ src.data;

        [MethodImpl(Inline)]
        public static analog operator - (analog src) 
            => -src.data;

        [MethodImpl(Inline)]
        public static analog operator -- (analog src) 
            =>  --src.data;

        [MethodImpl(Inline)]
        public static analog operator ++ (analog src) 
            =>  ++src.data;

        [MethodImpl(Inline)]
        public bool Equals(analog rhs)
            => data == rhs.data;

        public override int GetHashCode()
            => data.GetHashCode();

        public override bool Equals(object rhs)        
            => rhs is analog a && Equals(a);
        
        public override string ToString()
            => data.ToString();
        
    }
}
