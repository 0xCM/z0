//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        public static string FormatHex<T>(this ReadOnlySpan<T> src, bool bracket = false, char? sep = null, bool specifier = false)
            where T : unmanaged
        {
            var delimiter = sep ?? AsciSym.Space;
            var fmt = sbuild();
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

        public static string FormatHex(this ReadOnlySpan<byte> src, char sep, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
        {
            var sb =sbuild();
            var pre = (specifier && prespec) ? "0x" : string.Empty;
            var post = (specifier && !prespec) ? "h" : string.Empty;
            var spec = uppercase ? "X" : "x";
            
            for(var i=0; i<src.Length; i++)
            {
                var value = src[i].ToString(spec);
                var padded = zpad ? value.PadLeft(2,AsciDigits.A0) : value;
                sb.Append(concat(pre, padded, post));
                if(i != src.Length - 1)
                    sb.Append(sep);
            }
            return sb.ToString();
        }

        [MethodImpl(Inline)]
        static string hexX(bool upper = false)
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
            + (zpad ? src.ToString(hexX(uppercase)).PadLeft(HexPad8, '0') 
            : src.ToString(hexX(uppercase)))
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
             + (zpad ? src.ToString(hexX(uppercase)).PadLeft(HexPad8, '0') 
                     : src.ToString(hexX(uppercase)))
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
             + (zpad ? src.ToString(hexX(uppercase)).PadLeft(HexPad16, '0') 
                     : src.ToString(hexX(uppercase)))
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
             + (zpad ? src.ToString(hexX(uppercase)).PadLeft(HexPad16, '0') 
                     : src.ToString(hexX(uppercase)))
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
             + (zpad ? src.ToString(hexX(uppercase)).PadLeft(HexPad32, '0') 
                     : src.ToString(hexX(uppercase)))
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
             + (zpad ? src.ToString(hexX(uppercase)).PadLeft(HexPad32, '0') 
                     : src.ToString(hexX(uppercase)))
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
             + (zpad ? src.ToString(hexX(uppercase)).PadLeft(HexPad64, '0') 
                     : src.ToString(hexX(uppercase)))
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
             + (zpad ? src.ToString(hexX(uppercase)).PadLeft(HexPad64, '0') 
                     : src.ToString(hexX(uppercase)))
             + (specifier && !prespec  ? "h" : string.Empty);
    
        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this float src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => BitConverter.SingleToInt32Bits(src).FormatHex(zpad, specifier, uppercase, prespec);
        
        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this double src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            =>  BitConverter.DoubleToInt64Bits(src).FormatHex(zpad, specifier, uppercase, prespec);

        /// <summary>
        /// Produces a stream of hex strings from a stream of scalars
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether each value should be left-padded with zeros commensurate with size of the data type </param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether the hex digits A - F should be formmatted uppercase</param>
        public static IEnumerable<string> FormatHex(this IEnumerable<byte> src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => src.Select(x => x.FormatHex(zpad, specifier, uppercase, prespec));

        /// <summary>
        /// Produces a stream of hex strings from a stream of scalars
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether each value should be left-padded with zeros commensurate with size of the data type </param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether the hex digits A - F should be formmatted uppercase</param>
        public static IEnumerable<string> FormatHex(this IEnumerable<sbyte> src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => src.Select(x => x.FormatHex(zpad, specifier, uppercase, prespec));

        /// <summary>
        /// Produces a stream of hex strings from a stream of scalars
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether each value should be left-padded with zeros commensurate with size of the data type </param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether the hex digits A - F should be formmatted uppercase</param>
        public static IEnumerable<string> FormatHex(this IEnumerable<short> src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => src.Select(x => x.FormatHex(zpad, specifier, uppercase, prespec));

        /// <summary>
        /// Produces a stream of hex strings from a stream of scalars
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether each value should be left-padded with zeros commensurate with size of the data type </param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether the hex digits A - F should be formmatted uppercase</param>
        public static IEnumerable<string> FormatHex(this IEnumerable<ushort> src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => src.Select(x => x.FormatHex(zpad, specifier, uppercase, prespec));

        /// <summary>
        /// Produces a stream of hex strings from a stream of scalars
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether each value should be left-padded with zeros commensurate with size of the data type </param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether the hex digits A - F should be formmatted uppercase</param>
        public static IEnumerable<string> FormatHex(this IEnumerable<int> src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => src.Select(x => x.FormatHex(zpad, specifier, uppercase, prespec));

        /// <summary>
        /// Produces a stream of hex strings from a stream of scalars
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether each value should be left-padded with zeros commensurate with size of the data type </param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether the hex digits A - F should be formmatted uppercase</param>
        public static IEnumerable<string> FormatHex(this IEnumerable<uint> src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => src.Select(x => x.FormatHex(zpad, specifier, uppercase, prespec));

        /// <summary>
        /// Produces a stream of hex strings from a stream of scalars
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether each value should be left-padded with zeros commensurate with size of the data type </param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether the hex digits A - F should be formmatted uppercase</param>
        public static IEnumerable<string> FormatHex(this IEnumerable<long> src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => src.Select(x => x.FormatHex(zpad, specifier, uppercase, prespec));

        /// <summary>
        /// Produces a stream of hex strings from a stream of scalars
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether each value should be left-padded with zeros commensurate with size of the data type </param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether the hex digits A - F should be formmatted uppercase</param>
        public static IEnumerable<string> FormatHex(this IEnumerable<ulong> src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => src.Select(x => x.FormatHex(zpad, specifier, uppercase, prespec));

        /// <summary>
        /// Produces a stream of hex strings from a stream of scalars
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether each value should be left-padded with zeros commensurate with size of the data type </param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether the hex digits A - F should be formmatted uppercase</param>
        public static IEnumerable<string> FormatHex(this IEnumerable<float> src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => src.Select(x => x.FormatHex(zpad, specifier, uppercase, prespec));

        /// <summary>
        /// Produces a stream of hex strings from a stream of scalars
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether each value should be left-padded with zeros commensurate with size of the data type </param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether the hex digits A - F should be formmatted uppercase</param>
        public static IEnumerable<string> FormatHex(this IEnumerable<double> src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => src.Select(x => x.FormatHex(zpad, specifier,uppercase, prespec));
 
        public static string FormatHex(this byte[] src, char sep, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => src.ToReadOnlySpan().FormatHex(sep,zpad,specifier,uppercase,prespec);
 
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

        /// <summary>
        /// Formats a 64-bit blocked span as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Span64<T> src, bool bracket = false, char? sep = null, bool specifier = false)
            where T : unmanaged
                => src.Unblocked.FormatHex(bracket, sep, specifier);

        /// <summary>
        /// Formats a 128-bit blocked span as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Span128<T> src, bool bracket = false, char? sep = null, bool specifier = false)
            where T : unmanaged
                => src.Unblocked.FormatHex(bracket, sep, specifier);

        /// <summary>
        /// Formats a span of integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Span256<T> src, bool bracket = false, char? sep = null, bool specifier = false)
            where T : unmanaged
                => src.Unblocked.FormatHex(bracket, sep, specifier);

        /// <summary>
        /// Formats a span of natural length and integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<N,T>(this Span<N,T> src, bool bracket = false, char? sep = null, bool specifier = false)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Unsized.FormatHex(bracket, sep, specifier);

        /// <summary>
        /// Formats a bitspan of natural length and integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<N,T>(this BitSpan<N,T> src, bool bracket = false, char? sep = null, bool specifier = false)
            where N : unmanaged, ITypeNat<N>
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
                
        /// <summary>
        /// Formats a span of natural length and integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use as a separator, if applicable</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<N,T>(this ReadOnlySpan<N,T> src, bool bracket = false, char? sep = null, bool specifier = false)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Unsize().FormatHex(bracket, sep, specifier);

        /// <summary>
        /// Formats a span of integral type as a blocked hex
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="sep">The character to use as a separator, if applicable</param>
        /// <param name="specifier">Whether to prefix each block with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHexBlocks<T>(this ReadOnlySpan<T> src, int? width, char? sep, bool specifier)
            where T : unmanaged
                => src.FormatHex().SeparateBlocks(width ?? size<T>()*2, sep ?? AsciSym.Space, specifier ? "0x" : string.Empty);

        /// <summary>
        /// Formats a span of integral type as a blocked hex
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="sep">The character to use as a separator, if applicable</param>
        /// <param name="specifier">Whether to prefix each block with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHexBlocks<T>(this Span<T> src, int? width, char? sep, bool specifier)
            where T : unmanaged
                => src.ReadOnly().FormatHexBlocks(width,sep,specifier);

        /// <summary>
        /// Formats span cells as blocked hex
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="width">The block width</param>
        /// <param name="sep">The block delimiter</param>
        /// <typeparam name="T">The cell component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHexBlocks<T>(this Span<T> src, int? width = null, char? sep = null)
            where T : unmanaged
                => src.ReadOnly().FormatHexBlocks(width, sep, false);

        /// <summary>
        /// Formats span cells as blocked hex
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="width">The block width</param>
        /// <param name="sep">The block delimiter</param>
        /// <typeparam name="T">The cell component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHexBlocks<T>(this Span128<T> src, int? width = null, char? sep = null)
            where T : unmanaged
                => src.Unblocked.FormatHexBlocks(width, sep);
        
        /// <summary>
        /// Formats span cells as blocked hex
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="width">The block width</param>
        /// <param name="sep">The block delimiter</param>
        /// <typeparam name="T">The cell component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHexBlocks<T>(this Span256<T> src, int? width = null, char? sep = null)
            where T : unmanaged
                => src.Unblocked.FormatHexBlocks(width, sep);

        /// <summary>
        /// Formats span cells as blocked hex
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="width">The block width</param>
        /// <param name="sep">The block delimiter</param>
        /// <typeparam name="T">The cell component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHexBlocks<N,T>(this Span<N,T> src, int? width = null, char? sep = null)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Unsized.FormatHexBlocks(width,sep);

        /// <summary>
        /// Formats span cells as blocked hex
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="width">The block width</param>
        /// <param name="sep">The block delimiter</param>
        /// <typeparam name="T">The cell component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHexBlocks<N,T>(this ReadOnlySpan<N,T> src, int? width = null, char? sep = null)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Unsized.FormatHexBlocks(width,sep,false);    
    }

}