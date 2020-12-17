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
            => Option.Try(() => rebox((uint)(Bit32)incoming, dst.NumericKind()));

        public static Option<object> ToTarget(object incoming)
            => Option.Try(() => (Bit32)(byte)rebox(incoming, NumericKind.U8));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Bit32 to<T>(T src)
            => to_a(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T from<T>(Bit32 src)
            => from_a<T>(src);

        [MethodImpl(Inline)]
        static Bit32 to_a<T>(T src)
        {
            if(typeof(T) == typeof(bool))
                return (Bit32)@bool(src);
            else if(typeof(T) == typeof(char))
                return  (Bit32)char16(src);
            else
                return to_u(src);
        }

        [MethodImpl(Inline)]
        static Bit32 to_u<T>(T src)
        {
            if(typeof(T) == typeof(byte))
                return (Bit32)uint8(src);
            else if(typeof(T) == typeof(ushort))
                return (Bit32)uint16(src);
            else if(typeof(T) == typeof(uint))
                return (Bit32)uint32(src);
            else if(typeof(T) == typeof(ulong))
                return (Bit32)uint64(src);
            else
                return to_i(src);
        }

        [MethodImpl(Inline)]
        static Bit32 to_i<T>(T src)
        {
            if(typeof(T) == typeof(sbyte))
                return (Bit32)int8(src);
            else if(typeof(T) == typeof(short))
                return (Bit32)int16(src);
            else if(typeof(T) == typeof(int))
                return (Bit32)int32(src);
            else if(typeof(T) == typeof(long))
                return (Bit32)(byte)int64(src);
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static T from_a<T>(Bit32 src)
        {
            if(typeof(T) == typeof(bool))
                return generic<T>((bool)src);
            else if(typeof(T) == typeof(char))
                return generic<T>(src ? Bit32.One : Bit32.Zero);
            else if(typeof(T) == typeof(float))
                return generic<T>((float)((uint)src));
            else if(typeof(T) == typeof(double))
                return generic<T>((double)((double)src));
            else
                return from_u<T>(src);
        }

        [MethodImpl(Inline)]
        static T from_u<T>(Bit32 src)
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
        static T from_i<T>(Bit32 src)
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

    /// <summary>
    /// Conversion provider for the bit data type
    /// </summary>
    readonly struct Bit32Converter : IConversionProvider<Bit32Converter,Bit32>, IBiconverter<Bit32>
    {
        public Bit32Converter Converter => default;

        [MethodImpl(Inline)]
        public T Convert<T>(Bit32 src)
            => BitConversionOps.from<T>(src);

        [MethodImpl(Inline)]
        public Bit32 Convert<T>(T src)
            => BitConversionOps.to<T>(src);

        [MethodImpl(Inline)]
        public Option<object> ConvertFromTarget(object incoming, Type dst)
            => BitConversionOps.FromTarget(incoming,dst);

        [MethodImpl(Inline)]
        public Option<object> ConvertToTarget(object incoming)
            => BitConversionOps.ToTarget(incoming);
    }
}