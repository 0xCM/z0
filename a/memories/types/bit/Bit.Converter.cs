//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;
    using static As;
    using static Cast;

    /// <summary>
    /// Conversion provider for the bit data type
    /// </summary>
    public readonly struct BitDataTypeConverter : IConversionProvider<BitDataTypeConverter, bit>, IBiconverter<bit>
    {
        public BitDataTypeConverter Converter => default;

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
            => Option.Try(() => to((uint)(bit)incoming, dst.NumericKind()));

        static Option<object> ToTarget(object incoming)
            => Option.Try(() => (bit)(byte)to(incoming, NumericKind.U8));

        [MethodImpl(Inline)]
        public Option<object> ConvertFromTarget(object incoming, Type dst)
            => FromTarget(incoming,dst);

        [MethodImpl(Inline)]
        public Option<object> ConvertToTarget(object incoming)
            => ToTarget(incoming);

        public readonly struct From<T> : IConverter<bit,T>
        {            
            public static From<T> Service => default(From<T>);

            [MethodImpl(Inline)]
            public T Convert(bit src) => convert_a(src);

            [MethodImpl(Inline)]
            static T convert_a(bit src)
            {
                if(typeof(T) == typeof(bool))
                    return generic<T>((bool)src);
                else if(typeof(T) == typeof(char))
                    return generic<T>(src ? bit.One : bit.Zero);
                else 
                    return convert_b(src);
            }

            [MethodImpl(Inline)]
            static T convert_b(bit src)
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
                    throw Unsupported.define<T>();
            }
        }

        public readonly struct To<T> : IConverter<T, bit>
        {
            public static To<T> Service => default(To<T>);

            [MethodImpl(Inline)]
            public bit Convert(T src) => convert_a(src);

            [MethodImpl(Inline)]
            static bit convert_a(T src)
            {
                if(typeof(T) == typeof(bool))
                    return (bit)boolean(src);
                else if(typeof(T) == typeof(char))
                    return  (bit)character(src);
                else 
                    return convert_b(src);
            }

            [MethodImpl(Inline)]
            static bit convert_b(T src)
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
                    throw Unsupported.define<T>();
            }
        }
    }
}