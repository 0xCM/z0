//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static zfunc;
    using static AsIn;     

    public static class Hex
    {
        /// <summary>
        /// Defines the asci character codes for uppercase hex digits 1,2, ..., 9, A, ..., F
        /// </summary>
        static ReadOnlySpan<byte> HexCodes 
            => new byte[]{48,49,50,51,52,53,54,55,56,57,65,66,67,68,69,70};

        [MethodImpl(Inline)]
        public static byte code(byte value)
            => skip(in head(HexCodes), value & 0xf);

        public static ReadOnlySpan<char> digits(byte value)
        {
            Span<char> digits = new char[2];
            ref var dst = ref head(digits);
            ref readonly var codes = ref head(HexCodes);
            seek(ref dst, 1) = (char)skip(in codes, 0xF & value);
            seek(ref dst, 0) = (char)skip(in codes, (value >> 4) & 0xF);
            return digits;            
        }

        [MethodImpl(Inline)]
        public static void digits(byte value, out char d0, out char d1)
        {
            ref readonly var codes = ref head(HexCodes);
            d0 = (char)skip(in codes, 0xF & value);
            d1 = (char)skip(in codes, (value >> 4) & 0xF);
        }

        [MethodImpl(Inline)]
        public static char digit(byte value)
            => (char)skip(in head(HexCodes), 0xF & value);

        public static ReadOnlySpan<char> digits(ushort value)
        {
            var len = size<ushort>()*2;
            Span<char> digits = new char[len];
            ref var dst = ref head(digits);
            ref readonly var codes = ref head(HexCodes);
            for(var i=0; i < len; i++)
                seek(ref dst, len - i - 1) = (char)skip(in codes, (value >> i*4) & 0xF);
            return digits;            
        }

        [MethodImpl(Inline)]
        public static string text<T>(T src, bool uppercase = true)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return hexdigits_u(src,uppercase);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return hexdigits_i(src,uppercase);
            else 
                return hexdigits_f(src,uppercase);

        }

        [MethodImpl(Inline)]
        public static string format<T>(T src, bool zpad = true, bool specifier = true, bool uppercase = true)
            where T : unmanaged
                => format_hex_digits<T>(text(src,uppercase),zpad,specifier);

        /// <summary>
        /// Parses the Hex digit if possible; otherwise raises an error
        /// </summary>
        /// <param name="c">The source character</param>
        [MethodImpl(Inline)]    
        public static byte parse(char c)
        {
            if(byte.TryParse(c.ToString(), out var result))
                return result;
            else
                return Errors.Throw<byte>($"The character {c} is not a valid hex digit");
        }

        /// <summary>
        /// Parses valid hex digits from the source string, ignoring characters
        /// that aren't digits
        /// </summary>
        /// <param name="src">The source string</param>
        public static Span<byte> parse(string src)
        {            
            var offset = src.StartsWithAny(items("0x","0X"))  ? 2 : 0;
            var len = src.Length - offset;
            Span<byte> dst = new byte[len];
            for(var i = offset; i< len; i++)
                dst[i] = parse(src[i]);
            return dst;            
        }


        [MethodImpl(Inline)]
        static string format_hex_digits<T>(string digits, bool zpad = true, bool specifier = true)
            where T : unmanaged
        {
            var spec = specifier ? "0x" : string.Empty;
            return zpad ?  (spec + digits.PadLeft(size<T>() * 2, '0')) : (spec + digits);
        }

        [MethodImpl(Inline)]
        static string hexdigits_i<T>(T src, bool uppercase)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return As.int8(src).HexDigits(uppercase);
            else if(typeof(T) == typeof(short))
                return As.int16(src).HexDigits(uppercase);
            else if(typeof(T) == typeof(int))
                return As.int32(src).HexDigits(uppercase);
            else 
                return As.int64(src).HexDigits(uppercase);

        } 

        [MethodImpl(Inline)]
        static string hexdigits_u<T>(T src, bool uppercase)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return uint8(src).HexDigits(uppercase);
            else if(typeof(T) == typeof(ushort))
                return As.uint16(src).HexDigits(uppercase);
            else if(typeof(T) == typeof(uint))
                return As.uint32(src).HexDigits(uppercase);
            else 
                return  As.uint64(src).HexDigits(uppercase);
        } 

        [MethodImpl(Inline)]
        static string hexdigits_f<T>(T src, bool uppercase)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return As.float32(src).HexDigits(uppercase);
            else if(typeof(T) == typeof(double))
                return As.float64(src).HexDigits(uppercase);
            else
                throw unsupported<T>();
        } 
    }
}
