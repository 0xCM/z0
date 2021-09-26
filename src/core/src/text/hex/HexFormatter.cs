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
    using static HexFormatSpecs;

    [ApiHost]
    public readonly struct HexFormatter
    {
        const NumericKind Closure = UnsignedInts;

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
        public static string format<T>(ReadOnlySpan<T> src, char sep = Chars.Space, bool specifier = false)
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

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ISystemFormatter<T> sysformatter<T>()
            where T : struct
                => SystemHexFormatters.system_u<T>();

        /// <summary>
        /// Formats a sequence of primal numeric calls as data-formatted hex
        /// </summary>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string array<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => formatter<T>().Format(src, HexFormatSpecs.HexArray);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static HexFormatter<T> formatter<T>()
            where T : unmanaged
                => new HexFormatter<T>(sysformatter<T>());

        [Op, Closures(Closure)]
        public static string format<T>(W8 w, T src, bool postspec = false)
            where T : unmanaged
                => format(w, bw8(src), postspec);

        [Op, Closures(Closure)]
        public static string format<T>(W16 w, T src, bool postspec = false)
            where T : unmanaged
                => format(w, bw16(src), postspec);

        [Op, Closures(Closure)]
        public static string format<T>(W32 w, T src, bool postspec = false)
            where T : unmanaged
                => format(w, bw32(src), postspec);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string format<T>(W64 w, T src, bool postspec = false)
             where T : unmanaged
                => format(w, bw64(src), postspec);

        [Op]
        public static string format(ReadOnlySpan<byte> src, in HexFormatOptions config)
        {
            int? blockwidth = null;
            var dst = new StringBuilder();
            var count = src.Length;
            var pre = (config.Specifier && config.PreSpec) ? "0x" : EmptyString;
            var post = (config.Specifier && !config.PreSpec) ? "h" : EmptyString;
            var spec = CaseSpec(config.Uppercase).ToString();
            var width = config.BlockWidth == 0 ? ushort.MaxValue : config.BlockWidth;
            var counter = 0;

            for(var i=0; i<count; i++)
            {
                var value = skip(src,i).ToString(spec);
                var padded = config.ZeroPad ? value.PadLeft(2, Chars.D0) : value;
                dst.Append(string.Concat(pre, padded, post));
                if(config.DelimitSegs && i != count - 1)
                    dst.Append(config.SegDelimiter);

                if(++counter >= width && config.DelimitBlocks)
                {
                    if(config.BlockDelimiter == Chars.NL || config.BlockDelimiter == Chars.CR)
                        dst.AppendLine();
                    else
                        dst.Append(config.BlockDelimiter);
                    counter = 0;
                }
            }

            return dst.ToString();
        }

        [Op]
        public static string format(W8 w, byte src, bool postspec = false)
            => src.ToString(HexFormatSpecs.Hex8Spec) + (postspec ? HexFormatSpecs.PostSpec : EmptyString);

        [Op]
        public static string format(W16 w, ushort src, bool postspec = false)
            => src.ToString(HexFormatSpecs.Hex16Spec) + (postspec ? HexFormatSpecs.PostSpec : EmptyString);

        [Op]
        public static string format(W32 w, uint src, bool postspec = false)
            => src.ToString(HexFormatSpecs.Hex32Spec) + (postspec ? HexFormatSpecs.PostSpec : EmptyString);

        [Op]
        public static string format(W64 w, ulong src, bool postspec = false)
            => src.ToString(HexFormatSpecs.Hex64Spec) + (postspec ? HexFormatSpecs.PostSpec : EmptyString);

        [Op]
        public static string asmhex(sbyte src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x2")) + PostSpec;

        [Op]
        public static string asmhex(byte src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x2")) + PostSpec;

        [Op]
        public static string asmhex(short src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x4")) + PostSpec;

        [Op]
        public static string asmhex(ushort src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x4")) + PostSpec;

        [Op]
        public static string asmhex(int src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + PostSpec;

        [Op]
        public static string asmhex(uint src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x8")) + PostSpec;

        [Op]
        public static string asmhex(ulong src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + PostSpec;

        [Op]
        public static string asmhex(long src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + PostSpec;

        [Op]
        public static string format(byte src, int? digits = null, bool prespec = false, bool postspec = false)
            => (prespec ? HexFormatSpecs.PreSpec : EmptyString)
            + digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x2"))
            + (postspec ? PostSpec : EmptyString);

        [Op]
        public static string format(sbyte src, int? digits = null, bool prespec = false, bool postspec = false)
            => (prespec ? HexFormatSpecs.PreSpec : EmptyString)
            + digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x2"))
            + (postspec ? PostSpec : EmptyString);

        [Op]
        public static string format(short src, int? digits = null, bool prespec = false, bool postspec = false)
            => (prespec ? HexFormatSpecs.PreSpec : EmptyString)
            + digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x4"))
            + (postspec ? PostSpec : EmptyString);

        [Op]
        public static string format(ushort src, int? digits = null, bool prespec = false, bool postspec = false)
            => (prespec ? HexFormatSpecs.PreSpec : EmptyString)
            + digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x4"))
            + (postspec ? PostSpec : EmptyString);

        [Op]
        public static string format(int src, int? digits = null, bool prespec = false, bool postspec = false)
            => (prespec ? HexFormatSpecs.PreSpec : EmptyString)
            + digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x8"))
            + (postspec ? PostSpec : EmptyString);

        [Op]
        public static string format(uint src, int? digits = null, bool prespec = false, bool postspec = false)
            => (prespec ? HexFormatSpecs.PreSpec : EmptyString)
            + digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x8"))
            + (postspec ? PostSpec : EmptyString);

        [Op]
        public static string format(long src, int? digits = null, bool prespec = false, bool postspec = false)
            => (prespec ? HexFormatSpecs.PreSpec : EmptyString)
            + digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x"))
            + (postspec ? PostSpec : EmptyString);

        [Op]
        public static string format(ulong src, int? digits = null, bool prespec = false, bool postspec = false)
            => (prespec ? HexFormatSpecs.PreSpec : EmptyString)
            + digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x"))
            + (postspec ? PostSpec : EmptyString);

        [Op]
        public static string bytes(ushort src)
            => core.bytes(src).HexCoreFormat(HexFormatSpecs.HexData);

        [Op]
        public static string bytes(short src)
            => core.bytes(src).HexCoreFormat(HexFormatSpecs.HexData);

        [Op]
        public static string bytes(int src)
            => core.bytes(src).HexCoreFormat(HexFormatSpecs.HexData);

        [Op]
        public static string bytes(uint src)
            => core.bytes(src).HexCoreFormat(HexFormatSpecs.HexData);

        [Op]
        public static string bytes(long src)
            => core.bytes(src).HexCoreFormat(HexFormatSpecs.HexData);

        [Op]
        public static string bytes(ulong src)
            => core.bytes(src).HexCoreFormat(HexFormatSpecs.HexData);

        public static string bytes<T>(T src)
            where T : unmanaged
                => core.bytes(src).HexCoreFormat(HexFormatSpecs.HexData);

        [Op, Closures(AllNumeric)]
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

        [MethodImpl(Inline), Op]
        public static string format<W,T>(T value, W w = default, bool postspec = false)
            where W : unmanaged, IDataWidth
            where T : unmanaged
        {
            if(typeof(W) == typeof(W8))
                return format(w8, bw8(value), postspec);
            else if(typeof(W) == typeof(W16))
                return format(w16, bw16(value), postspec);
            else if(typeof(W) == typeof(W32))
                return format(w32, bw32(value), postspec);
            else
                return format(w64, bw64(value), postspec);
        }
    }
}