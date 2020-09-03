//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    readonly struct BitConversionOps
    {
        public static Option<object> FromTarget(object incoming, Type dst)
            => Option.Try(() => rebox((uint)(bit)incoming, dst.NumericKind()));

        public static Option<object> ToTarget(object incoming)
            => Option.Try(() => (bit)(byte)rebox(incoming, NumericKind.U8));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static bit to<T>(T src)
            => to_a(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T from<T>(bit src)
            => from_a<T>(src);

        [MethodImpl(Inline)]
        static bit to_a<T>(T src)
        {
            if(typeof(T) == typeof(bool))
                return (bit)bool8(src);
            else if(typeof(T) == typeof(char))
                return  (bit)char16(src);
            else
                return to_u(src);
        }

        [MethodImpl(Inline)]
        static bit to_u<T>(T src)
        {
            if(typeof(T) == typeof(byte))
                return (bit)uint8(src);
            else if(typeof(T) == typeof(ushort))
                return (bit)uint16(src);
            else if(typeof(T) == typeof(uint))
                return (bit)uint32(src);
            else if(typeof(T) == typeof(ulong))
                return (bit)uint64(src);
            else
                return to_i(src);
        }

        [MethodImpl(Inline)]
        static bit to_i<T>(T src)
        {
            if(typeof(T) == typeof(sbyte))
                return (bit)int8(src);
            else if(typeof(T) == typeof(short))
                return (bit)int16(src);
            else if(typeof(T) == typeof(int))
                return (bit)int32(src);
            else if(typeof(T) == typeof(long))
                return (bit)(byte)int64(src);
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static T from_a<T>(bit src)
        {
            if(typeof(T) == typeof(bool))
                return generic<T>((bool)src);
            else if(typeof(T) == typeof(char))
                return generic<T>(src ? bit.One : bit.Zero);
            else if(typeof(T) == typeof(float))
                return generic<T>((float)((uint)src));
            else if(typeof(T) == typeof(double))
                return generic<T>((double)((double)src));
            else
                return from_u<T>(src);
        }

        [MethodImpl(Inline)]
        static T from_u<T>(bit src)
        {
            if(typeof(T) == typeof(byte))
                return generic<T>((byte)src);
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)src);
            else if(typeof(T) == typeof(uint))
                return generic<T>((uint)src);
            else if(typeof(T) == typeof(ulong))
                return generic<T>((ulong)src);
            else
                return from_i<T>(src);
        }

        [MethodImpl(Inline)]
        static T from_i<T>(bit src)
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)src);
            else if(typeof(T) == typeof(short))
                return generic<T>((short)src);
            else if(typeof(T) == typeof(int))
                return generic<T>((int)src);
            else if(typeof(T) == typeof(long))
                return generic<T>((long)src);
            else
                throw no<T>();
        }
    }
}