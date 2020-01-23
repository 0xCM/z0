//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    using static zfunc;    


    partial class xfunc
    {
        const string UC = "X";

        const string LC = "x";

        const int HexPad8 = 2;

        const int HexPad16 = 4;

        const int HexPad32 = 8;

        const int HexPad64 = 16;

        /// <summary>
        /// Formats a span pf presumed integral values as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to format the result as a vector</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        static string FormatHex<T>(this ReadOnlySpan<T> src, bool bracket = false, char? sep = null, bool specifier = false)
            where T : unmanaged
        {
            var delimiter = sep ?? AsciSym.Space;
            var fmt = text();
            if(bracket)
                fmt.Append(AsciSym.LBracket);

            for(var i = 0; i<src.Length; i++)
            {
                fmt.Append(Hex.format(src[i], true, specifier));
                if(i != src.Length - 1)
                    fmt.Append((char)delimiter);
            }
            
            if(bracket)
                fmt.Append(AsciSym.RBracket);
            
            return fmt.ToString();
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
        public static string FormatHex<T>(this Span<T> src, bool bracket = false, char? sep = null, bool specifier = false)
            where T : unmanaged
                => src.ReadOnly().FormatHex(bracket, sep, specifier);

        public static string FormatAsmHex(this ulong src, int? zpad = null)
            => zpad.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + Hex.PostSpec;

        public static string FormatAsmHex(this uint src, int? zpad = null)
            => zpad.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + Hex.PostSpec;

        public static string FormatAsmHex(this int src, int? zpad = null)
            => zpad.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + Hex.PostSpec;

        public static string FormatAsmHex(this ushort src, int? zpad = null)
            => zpad.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + Hex.PostSpec;

        public static string FormatAsmHex(this byte src, int? zpad = null)
            => zpad.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + Hex.PostSpec;

        public static string FormatSmallHex(this ulong src, bool postspec = false)
            => src.ToString("x4") + (postspec ? $"{Hex.PostSpec}" : string.Empty);

        public static string FormatSmallHex(this byte src, bool postspec = false)
            => ((ulong)src).FormatSmallHex(postspec);

        public static string FormatSmallHex(this uint src, bool postspec = false)
            => ((ulong)src).FormatSmallHex(postspec);

        public static string FormatSmallHex(this ushort src, bool postspec = false)
            => ((ulong)src).FormatSmallHex(postspec);



        public static string FormatHexBytes(this ReadOnlySpan<byte> src, char sep = AsciSym.Comma, bool zpad = true, bool specifier = true, 
            bool uppercase = false, bool prespec = true, int? segwidth = null)
        {
            var sb =text();
            var pre = (specifier && prespec) ? "0x" : string.Empty;
            var post = (specifier && !prespec) ? "h" : string.Empty;
            var spec = HexFmtSpec(uppercase);
            var width = segwidth ?? int.MaxValue;
            var counter = 0;
            if(segwidth != null)
                sb.AppendLine();

            for(var i=0; i<src.Length; i++)
            {                
                var value = src[i].ToString(spec);
                var padded = zpad ? value.PadLeft(2,AsciDigits.A0) : value;

                sb.Append(concat(pre, padded, post));
                if(i != src.Length - 1)
                    sb.Append(sep);
                
                if(++counter == width)
                {
                    sb.AppendLine();
                    counter = 0;
                }                
            }
            return sb.ToString();
        }

        public static string FormatHexBytes(this Span<byte> src, char sep = AsciSym.Comma, bool zpad = true, bool specifier = true, 
            bool uppercase = false, bool prespec = true, int? segwidth = null)
                => src.ReadOnly().FormatHexBytes(sep,zpad,specifier,uppercase,prespec,segwidth);
        
        public static string FormatHexBytes(this byte[] src, char sep = AsciSym.Comma, bool zpad = true, bool specifier = true, 
            bool uppercase = false, bool prespec = true, int? segwidth = null)
                => src.AsSpan().ReadOnly().FormatHexBytes(sep,zpad,specifier,uppercase,prespec,segwidth);
        
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

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded with zeros</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether hex characters should be upper-cased</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
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
        /// Formats a scalar stream as a hex string
        /// </summary>
        /// <param name="src">The source bytes</param>
        /// <param name="zpad">Specifies whether each value should be left-padded with zeros commensurate with size of the data type </param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether the hex digits A - F should be formmatted uppercase</param>
        public static string FormatHex(this IEnumerable<byte> src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => src.Select(x => x.FormatHex(zpad, specifier, uppercase, prespec)).Select(x => x.ToString()).Concat(" ");

        /// <summary>
        /// Formats a scalar stream as a hex string
        /// </summary>
        /// <param name="src">The source bytes</param>
        /// <param name="zpad">Specifies whether each value should be left-padded with zeros commensurate with size of the data type </param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether the hex digits A - F should be formmatted uppercase</param>
        public static string FormatHexList(this IEnumerable<byte> src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => bracket(src.Select(x => x.FormatHex(zpad, specifier, uppercase, prespec)).Select(x => x.ToString()).Concat(comma()));

        /// <summary>
        /// Formtas an array of bytes as a hex string
        /// </summary>
        /// <param name="src">The source bytes</param>
        /// <param name="sep"></param>
        /// <param name="zpad"></param>
        /// <param name="specifier"></param>
        /// <param name="uppercase"></param>
        /// <param name="prespec"></param>
        /// <param name="segwidth"></param>
        public static string FormatHex(this byte[] src, char sep, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true, int? segwidth = null)
            => src.ToReadOnlySpan().FormatHexBytes(sep,zpad,specifier,uppercase,prespec);
 
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

        /// <summary>
        /// Formats a scalar value as a sequence of hex digits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="uppercase">Whether to use uppercase characters for digits A - F</param>
        [MethodImpl(Inline)]
        public static string HexDigits(this float src, bool uppercase)
            => BitConverter.SingleToInt32Bits(src).ToString(uppercase ? UC : LC);

        /// <summary>
        /// Formats a scalar value as a sequence of hex digits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="uppercase">Whether to use uppercase characters for digits A - F</param>
        [MethodImpl(Inline)]
        public static string HexDigits(this double src, bool uppercase)
            => BitConverter.DoubleToInt64Bits(src).ToString(uppercase ? UC : LC);

        /// <summary>
        /// Formats a 64-bit blocked span as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Block64<T> src, bool bracket = false, char? sep = null, bool specifier = false)
            where T : unmanaged
                => src.Data.FormatHex(bracket, sep, specifier);

        /// <summary>
        /// Formats a 128-bit blocked span as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Block128<T> src, bool bracket = false, char? sep = null, bool specifier = false)
            where T : unmanaged
                => src.Data.FormatHex(bracket, sep, specifier);

        /// <summary>
        /// Formats a span of integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Block256<T> src, bool bracket = false, char? sep = null, bool specifier = false)
            where T : unmanaged
                => src.Data.FormatHex(bracket, sep, specifier);

        /// <summary>
        /// Formats a span of natural length and integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<N,T>(this NatSpan<N,T> src, bool bracket = false, char? sep = null, bool specifier = false)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Data.FormatHex(bracket, sep, specifier);

        /// <summary>
        /// Formats cpu vector components of integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use as a separator, if applicable</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Vector128<T> src, bool bracket = false, char? sep = null, bool specifier = false)
            where T : unmanaged
                => src.ToSpan().FormatHex(bracket, sep, specifier);

        /// <summary>
        /// Formats cpu vector components of integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use as a separator, if applicable</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Vector256<T> src, bool bracket = false, char? sep = null, bool specifier = false)
             where T : unmanaged
                => src.ToSpan().FormatHex(bracket,sep, specifier);                 
    }
}