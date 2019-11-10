//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public struct UInt8
    {

        const uint Mask = 0xFF;
        
        uint data;

        public static UInt8 Zero 
        {
            [MethodImpl(Inline)]        
            get => Wrap(byte.MinValue);
        }

        public static UInt8 One 
        {
            [MethodImpl(Inline)]        
            get => Wrap((byte)1);
        }

        [MethodImpl(Inline)]
        public static UInt8 From(byte src)
            => Wrap(src);

        [MethodImpl(Inline)]
        public static UInt8 From(ushort src)
            => SafeWrap(src);

        [MethodImpl(Inline)]
        public static UInt8 From(uint src)
            => SafeWrap(src);

        [MethodImpl(Inline)]
        public static implicit operator UInt8(uint src)
            => SafeWrap(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(UInt8 src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator UInt8(byte src)
            => Wrap(src);

        [MethodImpl(Inline)]
        public static explicit operator byte(UInt8 src)
            => (byte)src.data;

        [MethodImpl(Inline)]
        public static UInt8 operator +(UInt8 a, UInt8 b)
            => SafeWrap(a.data + b.data);

        [MethodImpl(Inline)]
        public static UInt8 operator -(UInt8 a, UInt8 b)
            => SafeWrap(a.data - b.data);

        [MethodImpl(Inline)]
        public static UInt8 operator *(UInt8 a, UInt8 b)
            => SafeWrap(a.data * b.data);

        [MethodImpl(Inline)]
        public static UInt8 operator /(UInt8 a, UInt8 b)
            => Wrap(a.data / b.data);

        [MethodImpl(Inline)]
        public static UInt8 operator %(UInt8 a, UInt8 b)
            => Wrap(a.data % b.data);

        [MethodImpl(Inline)]
        public static UInt8 operator -(UInt8 a)
            => SafeWrap(~a.data + 1);

        [MethodImpl(Inline)]
        public static UInt8 operator &(UInt8 a, UInt8 b)
            => Wrap(a.data & b.data);

        [MethodImpl(Inline)]
        public static UInt8 operator |(UInt8 a, UInt8 b)
            => Wrap(a.data | b.data);

        [MethodImpl(Inline)]
        public static UInt8 operator ^(UInt8 a, UInt8 b)
            => Wrap(a.data ^ b.data);

        [MethodImpl(Inline)]
        public static UInt8 operator ~(UInt8 a)
            => SafeWrap(~a.data);
         
        [MethodImpl(Inline)]
        public static UInt8 operator ++(UInt8 a)
            => SafeWrap(++a.data);

        [MethodImpl(Inline)]
        public static UInt8 operator --(UInt8 a)
            => SafeWrap(--a.data);

        [MethodImpl(Inline)]
        public static UInt8 operator <<(UInt8 a, int offset)
            => SafeWrap(a.data << offset);

        [MethodImpl(Inline)]
        public static UInt8 operator >>(UInt8 a, int offset)
            => Wrap((a.data >> offset));

        [MethodImpl(Inline)]
        public static UInt8 rotl(UInt8 a, int offset)        
            => (a << offset) | (a >> (8 - offset));            

        [MethodImpl(Inline)]
        public static UInt8 rotr(UInt8 a, int offset)
        {        
            var x = a.data >> offset;
            var y = (a.data << (8 - offset)) & Mask;
            return Wrap(x | y);
        }
        
        [MethodImpl(Inline)]
        UInt8(uint src)
            => this.data = src;

        [MethodImpl(Inline)]
        static UInt8 Wrap(uint src)
            => new UInt8(src);

        [MethodImpl(Inline)]
        static UInt8 SafeWrap(uint src)
            => new UInt8(src & Mask);



    }

}