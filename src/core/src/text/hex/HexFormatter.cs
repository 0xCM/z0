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
    using static core;

    [ApiHost]
    public readonly struct HexFormatter
    {
        const NumericKind Closure = AllNumeric;

        [Op, Closures(Closure)]
        public static string format<T>(W8 w, T src, bool postspec = false)
            where T : unmanaged
                => HexFormat.format(w, bw8(src), postspec);

        [Op, Closures(Closure)]
        public static string format<T>(W16 w, T src, bool postspec = false)
            where T : unmanaged
                => HexFormat.format(w, bw16(src), postspec);

        [Op, Closures(Closure)]
        public static string format<T>(W32 w, T src, bool postspec = false)
            where T : unmanaged
                => HexFormat.format(w, bw32(src), postspec);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string format<T>(W64 w, T src, bool postspec = false)
             where T : unmanaged
                => HexFormat.format(w, bw64(src), postspec);

        [Op]
        public static string format(W32 w, uint src, bool postspec = false)
            => src.ToString(HexFormatSpecs.Hex32Spec) + (postspec ? HexFormatSpecs.PostSpec : EmptyString);

        [Op]
        public static string format(W64 w, ulong src, bool postspec = false)
            => src.ToString(HexFormatSpecs.Hex64Spec) + (postspec ? HexFormatSpecs.PostSpec : EmptyString);

        /// <summary>
        /// Creates a <see cref='HexFormatter<T>'/> for primitive numeric types
        /// </summary>
        /// <typeparam name="T">The primitive numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static HexFormatter<T> formatter<T>()
            where T : unmanaged
                => new HexFormatter<T>(SystemHexFormatters.create<T>());

        /// <summary>
        /// Renders a sequence of primal numeric T-cells as a sequence of hex-formatted values
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="config">The format configuration</param>
        /// <param name="dst">The rendered data receiver</param>
        /// <typeparam name="T">The primal numeric type</typeparam>
        [Op, Closures(Closure)]
        public static void format<T>(ReadOnlySpan<T> src, in HexFormatOptions config, ITextBuffer dst)
            where T : unmanaged
        {
            var count = src.Length;
            ref readonly var cell = ref first(src);
            var last = count - 1;
            for(var i=0u; i<count; i++)
            {
                dst.Append(format(skip(cell,i), config.ZeroPad, config.Specifier, config.Uppercase, config.PreSpec));
                if(i != last)
                    dst.Append(config.SegDelimiter);
            }
        }

        /// <summary>
        /// Formats a sequence of primal numeric calls as data-formatted hex
        /// </summary>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string array<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => formatter<T>().Format(src, HexFormatSpecs.HexArray);

        [Op, Closures(Closure)]
        public static string format<T>(ReadOnlySpan<T> src, in HexFormatOptions config)
            where T : unmanaged
        {
            var result = new StringBuilder();
            var count = src.Length;
            for(var i = 0; i<count; i++)
            {
                var formatted = format(skip(src,i), config.ZeroPad, config.Specifier, config.Uppercase, config.PreSpec);
                result.Append(formatted);
                if(i != count - 1)
                    result.Append(config.ValueDelimiter);
            }

            return result.ToString();
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
            var result = new StringBuilder();
            var count = src.Length;
            for(var i = 0; i<count; i++)
            {
                result.Append(format(skip(src,i), true, specifier));
                if(i != count - 1)
                    result.Append(sep);
            }

            return result.ToString();
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
                => format_u(src, zpad, specifier, uppercase, prespec);

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