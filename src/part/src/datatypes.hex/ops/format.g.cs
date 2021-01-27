//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static HexFormatSpecs;
    using static memory;

    partial struct HexFormat
    {
        /// <summary>
        /// Formats a span pf presumed integral values as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to format the result as a vector</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        [Op, Closures(Closure)]
        public static string format<T>(ReadOnlySpan<T> src,  char sep = Chars.Space, bool specifier = false)
            where T : unmanaged
        {
            var builder = Strings.build();
            var count = src.Length;
            for(var i = 0; i<count; i++)
            {
                builder.Append(format(src[i], true, specifier));
                if(i != count - 1)
                    builder.Append(sep);
            }

            return builder.ToString();
        }

        /// <summary>
        /// Renders a primal numeric value as hex-formatted text
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="zpad">Specifies whether the output should be 0-padded to the data type width</param>
        /// <param name="specifier">Specifies whether the output should be prefixed/postfixed with a hex specifier</param>
        /// <param name="uppercase">Specifies whether the alphabetic hex digits should be uppercased</param>
        /// <param name="prespec">Specifies whether the hex specifier, if emitted, should be the canonical prefix or postfix specifier</param>
        /// <typeparam name="T">The primal numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static string format<T>(T src, bool zpad, bool specifier, bool uppercase = false, bool prespec = true)
            where T : unmanaged
                => format_u(src,zpad, specifier, uppercase, prespec);

        [MethodImpl(Inline)]
        static string format_u<T>(T src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return uint8(src).FormatHex(zpad, specifier, uppercase, prespec);
            else if(typeof(T) == typeof(ushort))
                return uint16(src).FormatHex(zpad, specifier, uppercase, prespec);
            else if(typeof(T) == typeof(uint))
                return uint32(src).FormatHex(zpad, specifier, uppercase, prespec);
            else if(typeof(T) == typeof(ulong))
                return uint64(src).FormatHex(zpad, specifier, uppercase, prespec);
            else
                return format_i(src,zpad,specifier,uppercase,prespec);
        }

        [MethodImpl(Inline)]
        static string format_i<T>(T src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return int8(src).FormatHex(zpad, specifier, uppercase, prespec);
            else if(typeof(T) == typeof(short))
                return int16(src).FormatHex(zpad, specifier, uppercase, prespec);
            else if(typeof(T) == typeof(int))
                return int32(src).FormatHex(zpad, specifier, uppercase, prespec);
            else if(typeof(T) == typeof(long))
                return int64(src).FormatHex(zpad, specifier, uppercase, prespec);
            else
                return format_f(src,zpad,specifier,uppercase,prespec);
        }

        [MethodImpl(Inline)]
        static string format_f<T>(T src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return float32(src).FormatHex(zpad, specifier, uppercase, prespec);
            else if(typeof(T) == typeof(double))
                return float64(src).FormatHex(zpad, specifier, uppercase, prespec);
            else
                throw no<T>();
        }


    }
}