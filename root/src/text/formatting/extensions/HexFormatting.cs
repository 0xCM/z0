//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Root;

    public static class HexFormatting
    {
        const string UC = "X";

        const string LC = "x";

        const int HexPad8 = 2;

        const int HexPad16 = 4;

        const int HexPad32 = 8;

        const int HexPad64 = 16;

        const char PostSpec = 'h';

        [MethodImpl(Inline)]
        static string HexFmtSpec(bool upper)
            => upper ? "X" : "x";

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded with zeros</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether hex characters should be upper-cased</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this sbyte src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => (specifier && prespec ? "0x" : string.Empty) 
            + (zpad ? src.ToString(HexFmtSpec(uppercase)).PadLeft(HexPad8, '0') 
            : src.ToString(HexFmtSpec(uppercase)))
             + (specifier && !prespec ? "h" : string.Empty);

        [MethodImpl(Inline)]
        public static string FormatHex(this byte src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => (specifier && prespec ? "0x" : string.Empty) 
             + (zpad ? src.ToString(HexFmtSpec(uppercase)).PadLeft(HexPad8, '0') 
                     : src.ToString(HexFmtSpec(uppercase)))
             + (specifier && !prespec ? "h" : string.Empty);

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded with zeros</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether hex characters should be upper-cased</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this short src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => (specifier && prespec ? "0x" : string.Empty) 
             + (zpad ? src.ToString(HexFmtSpec(uppercase)).PadLeft(HexPad16, '0') 
                     : src.ToString(HexFmtSpec(uppercase)))
             + (specifier && !prespec ? "h" : string.Empty);

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded with zeros</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether hex characters should be upper-cased</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this ushort src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => (specifier && prespec ? "0x" : string.Empty) 
             + (zpad ? src.ToString(HexFmtSpec(uppercase)).PadLeft(HexPad16, '0') 
                     : src.ToString(HexFmtSpec(uppercase)))
             + (specifier && !prespec ? "h" : string.Empty);

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded with zeros</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether hex characters should be upper-cased</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this int src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => (specifier && prespec ? "0x" : string.Empty) 
             + (zpad ? src.ToString(HexFmtSpec(uppercase)).PadLeft(HexPad32, '0') 
                     : src.ToString(HexFmtSpec(uppercase)))
             + (specifier && !prespec ? "h" : string.Empty);

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded with zeros</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether hex characters should be upper-cased</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this uint src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => (specifier && prespec ? "0x" : string.Empty) 
             + (zpad ? src.ToString(HexFmtSpec(uppercase)).PadLeft(HexPad32, '0') 
                     : src.ToString(HexFmtSpec(uppercase)))
             + (specifier && !prespec ? "h" : string.Empty);

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded with zeros</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether hex characters should be upper-cased</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this long src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => (specifier && prespec ? "0x" : string.Empty) 
             + (zpad ? src.ToString(HexFmtSpec(uppercase)).PadLeft(HexPad64, '0') 
                     : src.ToString(HexFmtSpec(uppercase)))
             + (specifier && !prespec  ? "h" : string.Empty);

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded with zeros</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether hex characters should be upper-cased</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this ulong src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => (specifier && prespec ? "0x" : string.Empty) 
             + (zpad ? src.ToString(HexFmtSpec(uppercase)).PadLeft(HexPad64, '0') 
                     : src.ToString(HexFmtSpec(uppercase)))
             + (specifier && !prespec  ? "h" : string.Empty);    

        /// <summary>
        /// Formats a scalar value as a sequence of hex digits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="uppercase">Whether to use uppercase characters for digits A - F</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this float src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => BitConverter.SingleToInt32Bits(src).FormatHex(zpad, specifier, uppercase, prespec);

        /// <summary>
        /// Formats a scalar value as a sequence of hex digits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="uppercase">Whether to use uppercase characters for digits A - F</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this double src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => BitConverter.DoubleToInt64Bits(src).FormatHex(zpad, specifier, uppercase, prespec);

        /// <summary>
        /// Formats a scalar stream as a hex string
        /// </summary>
        /// <param name="src">The source bytes</param>
        /// <param name="zpad">Specifies whether each value should be left-padded with zeros commensurate with size of the data type </param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether the hex digits A - F should be formmatted uppercase</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        public static string FormatHex(this IEnumerable<byte> src, bool zpad, bool specifier, bool uppercase, bool prespec )
            => src.Select(x => x.FormatHex(zpad, specifier, uppercase, prespec)).Select(x => x.ToString()).Concat(" ");

        /// <summary>
        /// Formats a scalar stream as a hex string
        /// </summary>
        /// <param name="src">The source bytes</param>
        /// <param name="zpad">Specifies whether each value should be left-padded with zeros commensurate with size of the data type </param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether the hex digits A - F should be formmatted uppercase</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        public static string FormatHexList(this IEnumerable<byte> src, bool zpad = true, bool specifier = true, 
            bool uppercase = false, bool prespec = true)
                => text.bracket(src.Select(x => x.FormatHex(zpad, specifier, uppercase, prespec)).Select(x => x.ToString()).Concat(AsciSym.Comma));

        /// <summary>
        /// Formats a scalar value as a sequence of hex digits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="uppercase">Whether to use uppercase characters for digits A - F</param>
        [MethodImpl(Inline)]
        public static string HexDigits(this sbyte src, bool uppercase)
            => src.ToString(uppercase ? UC : LC);

        /// <summary>
        /// Formats a scalar value as a sequence of hex digits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="uppercase">Whether to use uppercase characters for digits A - F</param>
        [MethodImpl(Inline)]
        public static string HexDigits(this byte src, bool uppercase)
            => src.ToString(uppercase ? UC : LC);

        /// <summary>
        /// Formats a scalar value as a sequence of hex digits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="uppercase">Whether to use uppercase characters for digits A - F</param>
        [MethodImpl(Inline)]
        public static string HexDigits(this short src, bool uppercase)
            => src.ToString(uppercase ? UC : LC);

        /// <summary>
        /// Formats a scalar value as a sequence of hex digits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="uppercase">Whether to use uppercase characters for digits A - F</param>
        [MethodImpl(Inline)]
        public static string HexDigits(this ushort src, bool uppercase)
            => src.ToString(uppercase ? UC : LC);

        /// <summary>
        /// Formats a scalar value as a sequence of hex digits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="uppercase">Whether to use uppercase characters for digits A - F</param>
        [MethodImpl(Inline)]
        public static string HexDigits(this int src, bool uppercase)
            => src.ToString(uppercase ? UC : LC);

        /// <summary>
        /// Formats a scalar value as a sequence of hex digits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="uppercase">Whether to use uppercase characters for digits A - F</param>
        [MethodImpl(Inline)]
        public static string HexDigits(this uint src, bool uppercase)
            => src.ToString(uppercase ? UC : LC);

        /// <summary>
        /// Formats a scalar value as a sequence of hex digits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="uppercase">Whether to use uppercase characters for digits A - F</param>
        [MethodImpl(Inline)]
        public static string HexDigits(this long src, bool uppercase)
            => src.ToString(uppercase ? UC : LC);

        /// <summary>
        /// Formats a scalar value as a sequence of hex digits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="uppercase">Whether to use uppercase characters for digits A - F</param>
        [MethodImpl(Inline)]
        public static string HexDigits(this ulong src, bool uppercase)
            => src.ToString(uppercase ? UC : LC);

        public static string FormatHexBytes(this ReadOnlySpan<byte> src, char sep = AsciSym.Comma, bool zpad = true, bool specifier = true, 
            bool uppercase = false, bool prespec = true, int? segwidth = null)
        {
            var builder = factory<string>().Builder();
            var pre = (specifier && prespec) ? "0x" : string.Empty;
            var post = (specifier && !prespec) ? "h" : string.Empty;
            var spec = HexFmtSpec(uppercase);
            var width = segwidth ?? int.MaxValue;
            var counter = 0;
            if(segwidth != null)
                builder.AppendLine();

            for(var i=0; i<src.Length; i++)
            {                
                var value = src[i].ToString(spec);
                var padded = zpad ? value.PadLeft(2,AsciDigits.A0) : value;

                builder.Append(text.concat(pre, padded, post));
                if(i != src.Length - 1)
                    builder.Append(sep);
                
                if(++counter == width)
                {
                    builder.AppendLine();
                    counter = 0;
                }                
            }
            return builder.ToString();
        }

        /// <summary>
        /// Formtas an array of bytes as a hex string
        /// </summary>
        /// <param name="src">The source bytes</param>
        /// <param name="sep"></param>
        /// <param name="zpad">Specifies whether each value should be left-padded with zeros commensurate with size of the data type </param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether the hex digits A - F should be formmatted uppercase</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        /// <param name="segwidth">The maximum number of bytes on a single line</param>
        public static string FormatHex(this byte[] src, char sep, bool zpad = true, bool specifier = true, 
            bool uppercase = false, bool prespec = true, int? segwidth = null)
                => src.ToReadOnlySpan().FormatHexBytes(sep, zpad, specifier, uppercase, prespec, segwidth);

        public static string FormatSmallHex(this ulong src, bool postspec = false)
            => src.ToString("x4") + (postspec ? $"{PostSpec}" : string.Empty);

        public static string FormatSmallHex(this byte src, bool postspec = false)
            => ((ulong)src).FormatSmallHex(postspec);

        public static string FormatSmallHex(this uint src, bool postspec = false)
            => ((ulong)src).FormatSmallHex(postspec);

        public static string FormatSmallHex(this ushort src, bool postspec = false)
            => ((ulong)src).FormatSmallHex(postspec);

        public static string FormatAsmHex(this ulong src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + PostSpec;    

        public static string FormatAsmHex(this long src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + PostSpec;    

        public static string FormatAsmHex(this uint src, int? digits = null)        
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + PostSpec;

        public static string FormatAsmHex(this int src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + PostSpec;

        public static string FormatAsmHex(this ushort src)
            => src.ToString($"x4") + PostSpec;

        public static string FormatAsmHex(this byte src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + PostSpec;

        /// <summary>
        /// Formats a span pf presumed integral values as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to format the result as a vector</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static string FormatHex<T>(this ReadOnlySpan<T> src, bool bracket = false, char? sep = null, bool specifier = false)
            where T : unmanaged
        {
            var delimiter = sep ?? AsciSym.Space;
            var builder = factory<string>().Builder();
            if(bracket)
                builder.Append(AsciSym.LBracket);

            for(var i = 0; i<src.Length; i++)
            {
                builder.Append(Hex.format(src[i], true, specifier));
                if(i != src.Length - 1)
                    builder.Append((char)delimiter);
            }
            
            if(bracket)
                builder.Append(AsciSym.RBracket);
            
            return builder.ToString();
        }

        /// <summary>
        /// Formats a span of integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Span<T> src, bool bracket, char? sep, bool specifier)
            where T : unmanaged
                => src.ReadOnly().FormatHex(bracket, sep, specifier);
                
        public static string FormatHex(this ReadOnlySpan<byte> src, char sep = AsciSym.Space)
            => src.FormatHexBytes(sep:sep, zpad:true, specifier:false, uppercase: false);

        public static string FormatHex(this byte[] src, char sep = AsciSym.Space)
            => src.AsSpan().ReadOnly().FormatHex(sep);

        public static string FormatHex(this Span<byte> src, char sep = AsciSym.Space)
            => src.ReadOnly().FormatHex(sep);

        /// <summary>
        /// Formats the source data with optional line length/numbering
        /// </summary>
        /// <param name="data">The source data</param>
        /// <param name="fmt">The format options</param>
        public static IReadOnlyList<string> FormatHexLines(this ReadOnlySpan<byte> data, HexLineFormat? fmt = null)
        {
            var builder = factory<string>().Builder();
            var configured = fmt ?? HexLineFormat.Default;  
            var lines = new List<string>();
            var line = factory<string>().Builder();
            for(ushort i=0; i< data.Length; i++)
            {                
                if(i % configured.BytesPerLine == 0)
                {
                    if(i != 0)
                    {                        
                        builder.AppendLine();
                        
                        line.AppendLine();
                        lines.Add(line.ToString());
                        line.Clear();
                    }

                    if(configured.LineLabels)
                    {
                        builder.Append(i.FormatHex(true,false,false,true));
                        builder.Append(AsciLower.h);
                        builder.Append(AsciSym.Space);

                        line.Append(i.FormatHex(true,false,false,true));
                        line.Append(AsciLower.h);
                        line.Append(AsciSym.Space);
                    }
                }

                builder.Append(data[i].FormatHex(true, true, false, true));
                builder.Append(AsciSym.Space);

                line.Append(data[i].FormatHex(true, true, false, true));
                line.Append(AsciSym.Space);
            }
            var last = line.ToString();
            if(last.IsNotBlank())
                lines.Add(last);   

            builder.AppendLine();
            return lines;           
        } 

        public static IReadOnlyList<string> FormatHexLines(this byte[] data, HexLineFormat? fmt = null)
            => data.ToReadOnlySpan().FormatHexLines(fmt);            
    }
}