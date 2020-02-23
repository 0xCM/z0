//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;
    using static As;
    using static BitConversion;

    readonly struct BitConversionProvider : IUnmanagedConversionProvider<BiConverter, bit>
    {
        public BiConverter Converter 
        {
            [MethodImpl(Inline)]
            get => BitConversion.Converter;
        }
    }

    public readonly struct BitConversion 
    {
        public static BiConverter Converter
        {
            [MethodImpl(Inline)]
            get => BiConverter.Service;
        }

        [MethodImpl(Inline)]
        public static From<T> FromBit<T>()
            where T : unmanaged
                => From<T>.Service;

        [MethodImpl(Inline)]
        public static To<T> ToBit<T>()
            where T : unmanaged
                => To<T>.Service;
        
        public readonly struct BiConverter : IUnmanagedConverter<bit>
        {
            public static BiConverter Service => default(BiConverter);

            [MethodImpl(Inline)]
            public T Convert<T>(bit src)
                where T : unmanaged
                    => FromBit<T>().Convert(src);

            [MethodImpl(Inline)]
            public bit Convert<T>(T src) 
                where T : unmanaged
                    => ToBit<T>().Convert(src);
        }

        public readonly struct From<T> : IUnmanagedConveter<bit,T>
            where T : unmanaged
        {            
            public static From<T> Service => default(From<T>);

            [MethodImpl(Inline)]
            public T Convert(bit src) => convert_a(src);

            [MethodImpl(Inline)]
            static T convert_a(bit src)
            {
                if(typeof(T) == typeof(bool))
                    return  generic<T>((bool)src);
                else if(typeof(T) == typeof(char))
                    return  generic<T>(src ? bit.One : bit.Zero);
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
                    throw unsupported<T>();
            }
        }

        public readonly struct To<T> : IUnmanagedConveter<T, bit>
            where T : unmanaged
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
                    throw unsupported<T>();
            }
        }

    }
}