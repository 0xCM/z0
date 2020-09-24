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
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        internal static string format<T>(T src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            where T : unmanaged
                => format_u(src,zpad, specifier, uppercase,prespec);

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
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline), Op]
        public static string format<W,T>(T value, W w = default)
            where W : unmanaged, IDataWidth
            where T : unmanaged
        {
            if(typeof(W) == typeof(W8))
                return SmallHex.format(Cast.to<T,byte>(value));
            else if(typeof(W) == typeof(W16))
                return SmallHex.format(Cast.to<T,ushort>(value));
            else if(typeof(W) == typeof(W32))
                return SmallHex.format(Cast.to<T,uint>(value));
            else if(typeof(W) == typeof(W64))
                return SmallHex.format(Cast.to<T,ulong>(value));
            else
                return default;
        }

        [MethodImpl(Inline), Op]
        public static string format(in HexText<Hex1Seq> src, Hex1Seq kind)
            => src.String(kind);

        [MethodImpl(Inline), Op]
        public static string format(in HexText<Hex2Seq> src,  Hex2Seq kind)
            => src.String(kind);

        [MethodImpl(Inline), Op]
        public static string format(in HexText<Hex3Seq> src, Hex3Seq kind)
            => src.String(kind);

        [MethodImpl(Inline), Op]
        public static string format(in HexText<Hex4Seq> src, Hex4Seq kind)
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
            => format(src, HexFormatOptions.HexData);

        [MethodImpl(Inline), Op]
        public static string format(ReadOnlySpan<byte> src, in HexFormatOptions config)
            => format(src, config.Delimiter, config.ZPad, config.Specifier);

        [MethodImpl(Inline), Op]
        public static string format(ReadOnlySpan<byte> src, char sep, bool zpad = true, bool specifier = true)
            => format(src, sep, zpad, specifier, false, true, null);

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