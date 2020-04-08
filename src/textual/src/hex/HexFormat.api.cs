//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static As;

    [ApiHost("hex.format")]
    public static class HexFormat
    {
        [MethodImpl(Inline)]
        public static HexFormatter<T> formatter<T>()
            where T : unmanaged
                => new HexFormatter<T>(SystemHexFormatters.Create<T>());                   

        /// <summary>
        /// Formats a numeric array as hex data
        /// </summary>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The numeric type</typeparam>
        public static string data<T>(T[] src)
            where T : unmanaged
                => HexFormat.formatter<T>().Format(src, HexFormatConfig.HexData);

        /// <summary>
        /// Formats a numeric array as hex data
        /// </summary>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The numeric type</typeparam>
        public static string data<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => HexFormat.formatter<T>().Format(src, HexFormatConfig.HexData);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static string scalar<T>(T src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            where T : unmanaged
                => format_u(src,zpad, specifier,uppercase,prespec);

        /// <summary>
        /// Formats a sequence of hex characters encoded in a string according to the characteristics of the parametric
        /// type over which the operation is closed
        /// </summary>
        /// <typeparam name="T">The type the source text presumes to render</typeparam>
        public static string digits<T>(string src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            where T : unmanaged
        {
            var spec = specifier ? HexSpecs.PreSpec : string.Empty;
            return zpad ?  (spec + src.PadLeft(Unsafe.SizeOf<T>() * 2, '0')) : (spec + src);
        }

        [MethodImpl(Inline)]
        static string format_u<T>(T src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return uint8(src).FormatHex(zpad,specifier,uppercase,prespec);
            else if(typeof(T) == typeof(ushort))
                return uint16(src).FormatHex(zpad,specifier,uppercase,prespec);
            else if(typeof(T) == typeof(uint))
                return uint32(src).FormatHex(zpad,specifier,uppercase,prespec);
            else if(typeof(T) == typeof(ulong))
                return uint64(src).FormatHex(zpad,specifier,uppercase,prespec);
            else
                return format_i(src,zpad,specifier,uppercase,prespec);
        } 

        [MethodImpl(Inline)]
        static string format_i<T>(T src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return int8(src).FormatHex(zpad,specifier,uppercase,prespec);
            else if(typeof(T) == typeof(short))
                return int16(src).FormatHex(zpad,specifier,uppercase,prespec);
            else if(typeof(T) == typeof(int))
                return int32(src).FormatHex(zpad,specifier,uppercase,prespec);
            else if(typeof(T) == typeof(long))
                return int64(src).FormatHex(zpad,specifier,uppercase,prespec);
            else
                return format_f(src,zpad,specifier,uppercase,prespec);
        } 

        [MethodImpl(Inline)]
        static string format_f<T>(T src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return float32(src).FormatHex(zpad,specifier,uppercase,prespec);
            else if(typeof(T) == typeof(double))
                return float64(src).FormatHex(zpad,specifier,uppercase,prespec);
            else
                throw Unsupported.define<T>();
        } 
    }
}