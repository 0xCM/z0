//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static HexFormatSpecs;
    using static z;

    partial class Hex
    {

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string format<T>(in T src)
            where T : struct
        {
            var count = size<T>();
            var dst = span<char>(count*2);
            ref readonly var bytes = ref @as<T,byte>(src);
            var j = count*2 - 1;

            for(var i=0u; i<count; i++)
            {
                ref readonly var d = ref skip(bytes,i);
                seek(dst, j--) = (char)Hex.code(LowerCase, UI.crop4(d));
                seek(dst, j--) = (char)Hex.code(LowerCase, UI.srl(d, n4, w4));
            }

            return dst.ToString();
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
        internal static string format<T>(T src, bool zpad, bool specifier, bool uppercase = false, bool prespec = true)
            where T : unmanaged
                => format_u(src,zpad, specifier, uppercase, prespec);

        /// <summary>
        /// Formats a span pf presumed integral values as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to format the result as a vector</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static string format<T>(ReadOnlySpan<T> src,  char sep = Chars.Space, bool specifier = false)
            where T : unmanaged
        {
            var builder = Z0.text.build();
            for(var i = 0; i<src.Length; i++)
            {
                builder.Append(Hex.format(src[i], true, specifier));
                if(i != src.Length - 1)
                    builder.Append(sep);
            }

            return builder.ToString();
        }

        [MethodImpl(Inline), Op]
        static string format64(ulong src, bool postspec = false)
            => src.ToString(HexFormatSpecs.SmallHexSpec) + (postspec ? HexFormatSpecs.PostSpec : EmptyString);

        [MethodImpl(Inline), Op]
        static string format8(byte src, bool postspec = false)
            => format64(((ulong)src), postspec);

        [MethodImpl(Inline), Op]
        static string format16(ushort src, bool postspec = false)
            => format64(((ulong)src), postspec);

        [MethodImpl(Inline), Op]
        static string format32(uint src, bool postspec = false)
            => format64(((ulong)src), postspec);

        [MethodImpl(Inline), Op]
        public static string format(W8 w, byte src, bool postspec = false)
            => format8(src,postspec);

        [MethodImpl(Inline), Op]
        public static string format(W16 w, ushort src, bool postspec = false)
            => format16(src,postspec);

        [MethodImpl(Inline), Op]
        public static string format(W32 w, uint src, bool postspec = false)
            => format32(src,postspec);

        [MethodImpl(Inline), Op]
        public static string format(W64 w, ulong src, bool postspec = false)
            => format64(src,postspec);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string format<T>(W8 w, T src, bool postspec = false)
            where T : unmanaged
                => format8(uint8(src), postspec);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string format<T>(W16 w, T src, bool postspec = false)
            where T : unmanaged
                => format16(uint16(src), postspec);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string format<T>(W32 w, T src, bool postspec = false)
            where T : unmanaged
                => format32(uint32(src), postspec);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string format<T>(W64 w, T src, bool postspec = false)
             where T : unmanaged
                => format64(uint64(src), postspec);

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
        public static string format<W,T>(T value, W w = default)
            where W : unmanaged, IDataWidth
            where T : unmanaged
        {
            if(typeof(W) == typeof(W8))
                return SmallHex.format(NumericCast.force<T,byte>(value));
            else if(typeof(W) == typeof(W16))
                return SmallHex.format(NumericCast.force<T,ushort>(value));
            else if(typeof(W) == typeof(W32))
                return SmallHex.format(NumericCast.force<T,uint>(value));
            else if(typeof(W) == typeof(W64))
                return SmallHex.format(NumericCast.force<T,ulong>(value));
            else
                return default;
        }

        [MethodImpl(Inline), Op]
        public static string format(in HexString<Hex1Seq> src, Hex1Seq kind)
            => src.String(kind);

        [MethodImpl(Inline), Op]
        public static string format(in HexString<Hex2Seq> src,  Hex2Seq kind)
            => src.String(kind);

        [MethodImpl(Inline), Op]
        public static string format(in HexString<Hex3Seq> src, Hex3Seq kind)
            => src.String(kind);

        [MethodImpl(Inline), Op]
        public static string format(in HexString<Hex4Seq> src, Hex4Seq kind)
            => src.String(kind);

        [MethodImpl(Inline), Op]
        public static string format(Hex1Seq kind)
            => format(text(n1), kind);

        [MethodImpl(Inline), Op]
        public static string format(Hex2Seq kind)
            => format(text(n2), kind);

        [MethodImpl(Inline), Op]
        public static string format(Hex3Seq kind)
            => format(text(n3), kind);

        [MethodImpl(Inline), Op]
        public static string format(Hex4Seq kind)
            => format(text(n4), kind);

        [MethodImpl(Inline), Op]
        public static string format(ReadOnlySpan<byte> src)
            => format(src, HexFormatSpecs.HexData);

        [MethodImpl(Inline), Op]
        public static string format(ReadOnlySpan<byte> src, in HexFormatOptions config)
            => format(src, config.Delimiter, config.ZPad, config.Specifier);

        [MethodImpl(Inline), Op]
        public static string format(ReadOnlySpan<byte> src, char sep, bool zpad = true, bool specifier = true)
            => format(src, sep, zpad, specifier, false, true, null);

        [Op]
        public static string format(ReadOnlySpan<byte> src, char sep, bool zpad, bool specifier, bool uppercase, bool prespec, int? segwidth)
        {
            var dst = Z0.text.build();
            var size = src.Length;
            var pre = (specifier && prespec) ? "0x" : EmptyString;
            var post = (specifier && !prespec) ? "h" : EmptyString;
            var spec = CaseSpec(uppercase).ToString();
            var width = segwidth ?? int.MaxValue;
            var counter = 0;
            if(segwidth != null)
                dst.AppendLine();

            for(var i=0; i<size; i++)
            {
                var value = src[i].ToString(spec);
                var padded = zpad ? value.PadLeft(2, Chars.D0) : value;

                dst.Append(string.Concat(pre, padded, post));
                if(i != src.Length - 1)
                    dst.Append(sep);

                if(++counter == width)
                {
                    dst.AppendLine();
                    counter = 0;
                }
            }

            return dst.ToString();
        }
    }
}