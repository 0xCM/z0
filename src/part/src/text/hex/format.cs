//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Root;
    using static HexFormatSpecs;
    using static core;

    partial struct HexFormat
    {
        [MethodImpl(Inline), Op]
        public static HexDataFormatter DataFormatter(ulong? @base = null, ushort bpl = 20, bool labels = true)
            => new HexDataFormatter(new HexLineConfig(bpl, labels), @base);

        /// <summary>
        /// Creates a <see cref='HexFormatter<T>'/> for primitive numeric types
        /// </summary>
        /// <typeparam name="T">The primitive numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static HexFormatter<T> formatter<T>()
            where T : unmanaged
                => new HexFormatter<T>(SystemHexFormatters.create<T>());

        /// <summary>
        /// Formats a sequence of primal numeric calls as data-formatted hex
        /// </summary>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string array<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => HexFormat.formatter<T>().Format(src, HexFormatSpecs.HexArray);

        /// <summary>
        /// Formats a field segments as {typeof(V):Name}:{TrimmedBits}
        /// </summary>
        /// <param name="value">The field value</param>
        /// <typeparam name="E">The field value type</typeparam>
        /// <typeparam name="T">The field data type</typeparam>
        public static string field<E,T>(E src, Base10 @base, string name)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var data = Enums.scalar<E,T>(src);
            return text.concat(name, Chars.Colon, Numeric.format(data, @base));
        }

        /// <summary>
        /// Formats a field segments as {typeof(V):Name}:{TrimmedBits}
        /// </summary>
        /// <param name="value">The field value</param>
        /// <typeparam name="E">The field value type</typeparam>
        /// <typeparam name="T">The field data type</typeparam>
        public static string field<E,T>(E src, Base16 @base, string name)
            where E : unmanaged, Enum
            where T : unmanaged
                => text.concat(name, Chars.Colon, formatter<T>().FormatItem(Enums.scalar<E,T>(src)));

        [Op, Closures(Closure)]
        public static string format<T>(ReadOnlySpan<T> src, in HexFormatOptions config)
            where T : unmanaged
        {
            var result = text.buffer();
            var count = src.Length;
            for(var i = 0; i<count; i++)
            {
                var formatted = format(skip(src,i), config.ZeroPad, config.Specifier, config.Uppercase, config.PreSpec);
                result.Append(formatted);
                if(i != count - 1)
                    result.Append(config.ValueDelimiter);
            }

            return result.Emit();
        }

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
            var builder = text.build();
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