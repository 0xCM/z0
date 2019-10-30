//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Text;
    
    using static zfunc;    

    public static class HexFormat
    {
        const string UC = "X";

        const string LC = "x";

        [MethodImpl(Inline)]
        public static string HexDigits(this sbyte src, bool uppercase)
            => src.ToString(uppercase ? UC : LC);

        [MethodImpl(Inline)]
        public static string HexDigits(this byte src, bool uppercase)
            => src.ToString(uppercase ? UC : LC);

        [MethodImpl(Inline)]
        public static string HexDigits(this short src, bool uppercase)
            => src.ToString(uppercase ? UC : LC);

        [MethodImpl(Inline)]
        public static string HexDigits(this ushort src, bool uppercase)
            => src.ToString(uppercase ? UC : LC);

        [MethodImpl(Inline)]
        public static string HexDigits(this int src, bool uppercase)
            => src.ToString(uppercase ? UC : LC);

        [MethodImpl(Inline)]
        public static string HexDigits(this uint src, bool uppercase)
            => src.ToString(uppercase ? UC : LC);

        [MethodImpl(Inline)]
        public static string HexDigits(this long src, bool uppercase)
            => src.ToString(uppercase ? UC : LC);

        [MethodImpl(Inline)]
        public static string HexDigits(this ulong src, bool uppercase)
            => src.ToString(uppercase ? UC : LC);

        [MethodImpl(Inline)]
        public static string HexDigits(this float src, bool uppercase)
            => BitConverter.SingleToInt32Bits(src).ToString(uppercase ? UC : LC);

        [MethodImpl(Inline)]
        public static string HexDigits(this double src, bool uppercase)
            => BitConverter.DoubleToInt64Bits(src).ToString(uppercase ? UC : LC);

        /// <summary>
        /// Formats a span as a delimited list using a specified formatter
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        public static string FormatList<T>(this ReadOnlySpan<T> src, Func<T,string> format, char delimiter = ',', int offset = 0)
        {
            var sb = new StringBuilder();            
            for(var i = offset; i< src.Length; i++)
            {
                if(i != offset)
                    sb.Append(delimiter);
                sb.Append($"{format(src[i])}");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Formats a span pf presumed integral values as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="vectorize">Whether to format the result as a vector</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this ReadOnlySpan<T> src, bool vectorize = false, char? sep = null, bool specifier = false)
            where T : unmanaged
        {
                var delimiter = sep ?? (vectorize ? AsciSym.Comma : AsciSym.Space);
                var fmt = sbuild();
                if(vectorize)
                    fmt.Append(AsciSym.Lt);

                for(var i = 0; i<src.Length; i++)
                {
                    fmt.Append(Hex.format(src[i], true, specifier));
                    if(i != src.Length - 1)
                        fmt.Append((char)delimiter);
                }
                
                if(vectorize)
                    fmt.Append(AsciSym.Gt);
                
                return fmt.ToString();
        }

        /// <summary>
        /// Formats a span of integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="vectorize">Whether to render comma-separated values enclosed by angular brackets</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this T[] src, bool vectorize = false, char? sep = null, bool specifier = false)
            where T : unmanaged
                => FormatHex(src.ToReadOnlySpan(), vectorize, sep, specifier);

        /// <summary>
        /// Formats a span of integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="vectorize">Whether to render comma-separated values enclosed by angular brackets</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Span<T> src, bool vectorize = false, char? sep = null, bool specifier = false)
            where T : unmanaged
                => src.ReadOnly().FormatHex(vectorize, sep, specifier);

        /// <summary>
        /// Formats a span of natural length and integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="vectorize">Whether to format the result as a vector</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<N,T>(this Span<N,T> src, bool vectorize = false, char? sep = null, bool specifier = false)
            where N : ITypeNat, new()
            where T : unmanaged
                => src.Unsize().FormatHex(vectorize, sep, specifier);

        /// <summary>
        /// Formats a span of natural length and integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="vectorize">Whether to render comma-separated values enclosed by angular brackets</param>
        /// <param name="sep">The character to use as a separator, if applicable</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<N,T>(this ReadOnlySpan<N,T> src, bool vectorize = false, char? sep = null, bool specifier = false)
            where N : ITypeNat, new()
            where T : unmanaged
                => src.Unsize().FormatHex(vectorize, sep, specifier);


        /// <summary>
        /// Formats a span of integral type as a blocked hex
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="width">The block width</param>
        /// <param name="sep">The block delimiter</param>
        /// <typeparam name="T">The cell component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHexBlocks<T>(this ReadOnlySpan<T> src, int? width = null, char? sep = null)
            where T : unmanaged
                => src.FormatHex().SeparateBlocks(width ?? Unsafe.SizeOf<T>(), sep ?? AsciSym.Space);

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
                => src.FormatHex().SeparateBlocks(width ?? Unsafe.SizeOf<T>(), sep ?? AsciSym.Space, specifier ? "0x" : string.Empty);

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
                    => src.ReadOnly().FormatHexBlocks(width, sep);

        /// <summary>
        /// Formats span cells as blocked hex
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="width">The block width</param>
        /// <param name="sep">The block delimiter</param>
        /// <typeparam name="T">The cell component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHexBlocks<N,T>(this Span<N,T> src, int? width = null, char? sep = null)
                where N : ITypeNat, new()
                where T : unmanaged
                    => src.Unsize().FormatHexBlocks(width,sep);

        /// <summary>
        /// Formats span cells as blocked hex
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="width">The block width</param>
        /// <param name="sep">The block delimiter</param>
        /// <typeparam name="T">The cell component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHexBlocks<N,T>(this ReadOnlySpan<N,T> src, int? width = null, char? sep = null)
                where N : ITypeNat, new()
                where T : unmanaged
                    => src.Unsize().FormatHexBlocks(width,sep);        
    }
}