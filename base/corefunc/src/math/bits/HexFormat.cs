//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    using System.Text;
    
    using static zfunc;    

    public static class HexFormatX
    {
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
                    fmt.Append(hexstring(src[i], true, specifier));
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
        /// Formats cpu vector components of integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="vectorize">Whether to render comma-separated values enclosed by angular brackets</param>
        /// <param name="sep">The character to use as a separator, if applicable</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Vec128<T> src, bool vectorize = true, char? sep = null, bool specifier = false)
            where T : unmanaged
                => src.ToSpan().FormatHex(vectorize, sep, specifier);

        /// <summary>
        /// Formats cpu vector components of integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="vectorize">Whether to render comma-separated values enclosed by angular brackets</param>
        /// <param name="sep">The character to use as a separator, if applicable</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Vector128<T> src, bool vectorize = true, char? sep = null, bool specifier = false)
            where T : unmanaged
                => src.ToSpan().FormatHex(vectorize, sep, specifier);

        /// <summary>
        /// Formats cpu vector components of integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="vectorize">Whether to render comma-separated values enclosed by angular brackets</param>
        /// <param name="sep">The character to use as a separator, if applicable</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Vec256<T> src, bool vectorize = true, char? sep = null, bool specifier = false)
             where T : unmanaged
                => src.ToSpan().FormatHex(vectorize,sep, specifier); 

        /// <summary>
        /// Formats cpu vector components of integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="vectorize">Whether to render comma-separated values enclosed by angular brackets</param>
        /// <param name="sep">The character to use as a separator, if applicable</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Vector256<T> src, bool vectorize = true, char? sep = null, bool specifier = false)
             where T : unmanaged
                => src.ToSpan().FormatHex(vectorize,sep, specifier); 

        /// <summary>
        /// Formats cpu vector components of integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="vectorize">Whether to render comma-separated values enclosed by angular brackets</param>
        /// <param name="sep">The character to use as a separator, if applicable</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Vec512<T> src, bool vectorize = true, char? sep = null, bool specifier = false)
            where T : unmanaged
                => src.ToSpan().FormatHex(vectorize,sep, specifier);

        /// <summary>
        /// Formats cpu vector components of integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="vectorize">Whether to render comma-separated values enclosed by angular brackets</param>
        /// <param name="sep">The character to use as a separator, if applicable</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Vec1024<T> src, bool vectorize = true, char? sep = null, bool specifier = false)
            where T : unmanaged
                => src.ToSpan().FormatHex(vectorize,sep, specifier);

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

        /// <summary>
        /// Formats vector components as blocked hex
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="width">The block width</param>
        /// <param name="sep">The block delimiter</param>
        /// <typeparam name="T">The cell component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHexBlocks<T>(this Vec256<T> src)
            where T : unmanaged                            
                => src.FormatHex(false, AsciSym.Space);

        /// <summary>
        /// Formats vector components as blocked hex
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="width">The block width</param>
        /// <param name="sep">The block delimiter</param>
        /// <typeparam name="T">The cell component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHexBlocks<T>(this Vector128<T> src)
            where T : unmanaged
                => src.FormatHex(false, AsciSym.Space);

        /// <summary>
        /// Formats vector components as blocked hex
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="width">The block width</param>
        /// <param name="sep">The block delimiter</param>
        /// <typeparam name="T">The cell component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHexBlocks<T>(this Vector256<T> src)
            where T : unmanaged
                => src.FormatHex(false, AsciSym.Space);

        /// <summary>
        /// Formats vector components as blocked hex
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="width">The block width</param>
        /// <param name="sep">The block delimiter</param>
        /// <typeparam name="T">The cell component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHexBlocks<T>(this Vec512<T> src)
                where T : unmanaged
                    => src.FormatHex(false, AsciSym.Space);
        
        [MethodImpl(Inline)]
        static string hexstring<T>(T src, bool zpad = true, bool specifier = true)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return hexdigits_u(src,zpad,specifier);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return hexdigits_i(src,zpad,specifier);
            else 
                return hexdigits_f(src,zpad,specifier);
        } 


        [MethodImpl(Inline)]
        static string format_hex_digits<T>(string digits, bool zpad = true, bool specifier = true)
            where T : unmanaged
        {
            var spec = specifier ? "0x" : string.Empty;
            return zpad ?  (spec + digits.PadLeft(size<T>() * 2, '0')) : (spec + digits);

        }

        [MethodImpl(Inline)]
        static string hexdigits_i<T>(T src, bool zpad = true, bool specifier = true)
            where T : unmanaged
        {
            var digits = string.Empty;
            const string fmt = "X";
            if(typeof(T) == typeof(sbyte))
                digits = As.int8(src).ToString(fmt);
            else if(typeof(T) == typeof(short))
                digits = As.int16(src).ToString(fmt);
            else if(typeof(T) == typeof(int))
                digits = As.int32(src).ToString(fmt);
            else 
                digits = As.int64(src).ToString(fmt);

            var spec = specifier ? "0x" : string.Empty;
            return zpad ?  (spec + digits.PadLeft(size<T>() * 2, '0')) : (spec + digits);
        } 

        [MethodImpl(Inline)]
        static string hexdigits_u<T>(T src, bool zpad = true, bool specifier = true)
            where T : unmanaged
        {
            var digits = string.Empty;
            var fmt = "X";
            if(typeof(T) == typeof(sbyte))
                digits = As.int8(src).ToString(fmt);
            else if(typeof(T) == typeof(byte))
                digits = As.uint8(src).ToString(fmt);
            else if(typeof(T) == typeof(short))
                digits = As.int16(src).ToString(fmt);
            else if(typeof(T) == typeof(ushort))
                digits = As.uint16(src).ToString(fmt);
            else if(typeof(T) == typeof(int))
                digits = As.int32(src).ToString(fmt);
            else if(typeof(T) == typeof(uint))
                digits = As.uint32(src).ToString(fmt);
            else if(typeof(T) == typeof(long))
                digits = As.int64(src).ToString(fmt);
            else if(typeof(T) == typeof(ulong))
                digits = As.uint64(src).ToString(fmt);
            else if(typeof(T) == typeof(float))
                digits = convert<float,int>(As.float32(src)).ToString(fmt);
            else if(typeof(T) == typeof(double))
                digits = convert<double,long>(As.float64(src)).ToString(fmt);
            else
                throw unsupported<T>();

            var spec = specifier ? "0x" : string.Empty;
            return zpad ?  (spec + digits.PadLeft(size<T>() * 2, '0')) : (spec + digits);
        } 

        [MethodImpl(Inline)]
        static string hexdigits_f<T>(T src, bool zpad = true, bool specifier = true)
            where T : unmanaged
        {
            var digits = string.Empty;
            var fmt = "X";
            if(typeof(T) == typeof(sbyte))
                digits = As.int8(src).ToString(fmt);
            else if(typeof(T) == typeof(byte))
                digits = As.uint8(src).ToString(fmt);
            else if(typeof(T) == typeof(short))
                digits = As.int16(src).ToString(fmt);
            else if(typeof(T) == typeof(ushort))
                digits = As.uint16(src).ToString(fmt);
            else if(typeof(T) == typeof(int))
                digits = As.int32(src).ToString(fmt);
            else if(typeof(T) == typeof(uint))
                digits = As.uint32(src).ToString(fmt);
            else if(typeof(T) == typeof(long))
                digits = As.int64(src).ToString(fmt);
            else if(typeof(T) == typeof(ulong))
                digits = As.uint64(src).ToString(fmt);
            else if(typeof(T) == typeof(float))
                digits = convert<float,int>(As.float32(src)).ToString(fmt);
            else if(typeof(T) == typeof(double))
                digits = convert<double,long>(As.float64(src)).ToString(fmt);
            else
                throw unsupported<T>();

            var spec = specifier ? "0x" : string.Empty;
            return zpad ?  (spec + digits.PadLeft(size<T>() * 2, '0')) : (spec + digits);
        } 

    }
}