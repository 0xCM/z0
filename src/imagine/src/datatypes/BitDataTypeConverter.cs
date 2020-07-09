//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static Cast;
    using static As;

    /// <summary>
    /// Conversion provider for the bit data type
    /// </summary>
    readonly struct BitDataTypeConverter : IConversionProvider<BitDataTypeConverter, bit>, IBiconverter<bit>
    {
        public BitDataTypeConverter Converter => default;

        public static BitDataTypeConverter Service => default;

        [MethodImpl(Inline)]
        public static From<T> FromBit<T>()
            => From<T>.Service;

        [MethodImpl(Inline)]
        public static To<T> ToBit<T>()
            => To<T>.Service;

        [MethodImpl(Inline)]
        public T Convert<T>(bit src)
            => FromBit<T>().Convert(src);

        [MethodImpl(Inline)]
        public bit Convert<T>(T src) 
            => ToBit<T>().Convert(src);

        static Option<object> FromTarget(object incoming, Type dst)
            => Option.Try(() => rebox((uint)(bit)incoming, dst.NumericKind()));

        static Option<object> ToTarget(object incoming)
            => Option.Try(() => (bit)(byte)rebox(incoming, NumericKind.U8));

        [MethodImpl(Inline)]
        public Option<object> ConvertFromTarget(object incoming, Type dst)
            => FromTarget(incoming,dst);

        [MethodImpl(Inline)]
        public Option<object> ConvertToTarget(object incoming)
            => ToTarget(incoming);

        public readonly struct From<T> : IConverter<bit,T>
        {            
            public static From<T> Service => default;

            [MethodImpl(Inline)]
            public T Convert(bit src) 
                => convert_a(src);

            [MethodImpl(Inline)]
            static T convert_a(bit src)
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
                    return convert_u(src);
            }

            [MethodImpl(Inline)]
            static T convert_u(bit src)
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
                    return convert_i(src);
            }

            [MethodImpl(Inline)]
            static T convert_i(bit src)
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
                    throw Unsupported.define<T>();
            }

        }

        public readonly struct To<T> : IConverter<T, bit>
        {
            public static To<T> Service => default;

            [MethodImpl(Inline)]
            public bit Convert(T src) 
                => convert_a(src);

            [MethodImpl(Inline)]
            static bit convert_a(T src)
            {
                if(typeof(T) == typeof(bool))
                    return (bit)bool8(src);
                else if(typeof(T) == typeof(char))
                    return  (bit)char16(src);
                else 
                    return convert_u(src);
            }

            [MethodImpl(Inline)]
            static bit convert_u(T src)
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
                    return convert_i(src);
            }

            [MethodImpl(Inline)]
            static bit convert_i(T src)
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
                    throw Unsupported.define<T>();
            }

        }
    }
}