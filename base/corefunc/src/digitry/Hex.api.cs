//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    using static zfunc;
    using static AsIn;     
    using static Stacks;

    public static class Hex
    {
        /// <summary>
        /// Standard hex specifier that leads the numeric content
        /// </summary>
        public const string PreSpec = "0x";

        /// <summary>
        /// Standard hex specifier that trails the numeric content
        /// </summary>
        public const char PostSpec = 'h';
        
        /// <summary>
        /// Determines whether a character is a hex digit
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline)]
        public static bit isdigit(char c)
            => islo(c) || ishi(c);
        
        /// <summary>
        /// Returns the hex character code for a number in the interval [0,15]
        /// </summary>
        /// <param name="value">The value to be hex-encoded</param>
        [MethodImpl(Inline)]
        public static byte code(byte value)
            => skip(in head(HexCodes), value & 0xf);

        [MethodImpl(Inline)]
        public static void digits(byte value, out char d0, out char d1)
        {
            ref readonly var codes = ref head(HexCodes);
            d0 = (char)skip(in codes, 0xF & value);
            d1 = (char)skip(in codes, (value >> 4) & 0xF);
        }

        /// <summary>
        /// Presuming a source value int the range [0,15], returns the corresponding hex 
        /// </summary>
        /// <param name="value">The value to interpret</param>
        [MethodImpl(Inline)]
        public static char digit(byte value)
            => (char)skip(in head(HexCodes), 0xF & value);

        [MethodImpl(Inline)]
        public static char digit(byte value, int pos)
            => (char)skip(in head(HexCodes), 0xF & (byte)(value >> pos*4));

        [MethodImpl(Inline)]
        public static char digit(ushort value, int pos)
            => (char)skip(in head(HexCodes), 0xF & (byte)(value >> pos*4));

        [MethodImpl(Inline)]
        public static char digit(uint value, int pos)
            => (char)skip(in head(HexCodes), 0xF & (byte)(value >> pos*4));

        [MethodImpl(Inline)]
        public static char digit(ulong value, int pos)
            => (char)skip(in head(HexCodes), 0xF & (byte)(value >> pos*4));

        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> digits<T>(T value)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return digits(uint8(value));
            else if(typeof(T) == typeof(ushort))
                return digits(uint16(value));
            else if(typeof(T) == typeof(uint))
                return digits(uint32(value));
            else if(typeof(T) == typeof(ulong))
                return digits(uint64(value));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Returns the 2-character hex representation of a byte
        /// </summary>
        /// <param name="value">The byte value</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> digits(byte value)
        {
            ref readonly var codes = ref head(HexCodes);
            var storage = Stacks.chars(n2);
            ref var dst = ref storage.C0;
            
            seek(ref dst,0) = (char)skip(in codes, 0xF & value);
            seek(ref dst,1) = (char)skip(in codes, (value >> 4) & 0xF);
            return Stacks.charspan(ref storage);
        }

        /// <summary>
        /// Returns the 4-character hex representation of an unsigned 16-bit integer
        /// </summary>
        /// <param name="value">The byte value</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> digits(ushort value)
        {
            const int count = 4;
            ref readonly var codes = ref head(HexCodes);
            var storage = Stacks.chars(n4);
            ref var dst = ref storage.C0;

            for(var i=0; i < count; i++)
                @char(ref dst, i) = (char)skip(in codes, (value >> i*4) & 0xF);
            return Stacks.charspan(ref storage);
        }

        /// <summary>
        /// Returns the 8-character hex representation of an unsigned 32-bit integer
        /// </summary>
        /// <param name="value">The byte value</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> digits(uint value)
        {
            const int count = 8;
            ref readonly var codes = ref head(HexCodes);
            var storage = Stacks.chars(n8);
            ref var dst = ref storage.C0;

            for(var i=0; i < count; i++)
                @char(ref dst, i) = (char)skip(in codes, (int) ((value >> i*4) & 0xF));
            return Stacks.charspan(ref storage);
        }

        /// <summary>
        /// Returns the 16-character hex representation of an unsigned 64-bit integer
        /// </summary>
        /// <param name="value">The byte value</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> digits(ulong value)
        {
            const int count = 16;
            ref readonly var codes = ref head(HexCodes);
            var storage = Stacks.chars(n16);
            ref var dst = ref storage.C0;

            for(var i=0; i < count; i++)
                @char(ref dst, i) = (char)skip(in codes, (int) ((value >> i*4) & 0xF));
            return Stacks.charspan(ref storage);
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

        static string clean(string src)
            => src.Remove(PreSpec).RemoveAny(AsciLower.h);

        /// <summary>
        /// Parses the Hex digit if possible; otherwise raises an error
        /// </summary>
        /// <param name="c">The source character</param>
        public static byte parse(char c)
        {
            var u = Char.ToUpperInvariant(c);
            if(islo(u))
                return (byte)((byte)u - MinCode);
            else if(ishi(u))
                return (byte)((byte)u - MinHiCode + 0xA);
            else
                return Errors.ThrowArgException<char,byte>(c);
        }


        /// <summary>
        /// Attempts to parse a hex string as an unsigned long
        /// </summary>
        /// <param name="src">The source text</param>
        public static Option<ulong> parse(string src)
        {
            if(ulong.TryParse(clean(src), NumberStyles.HexNumber, null,  out ulong value))
                return value;
            return default;
        }

        /// <summary>
        /// Parses a hex byte
        /// </summary>
        /// <param name="src">hex text</param>
        public static byte parsebyte(string src)    
            => byte.Parse(clean(src), NumberStyles.HexNumber);

        /// <summary>
        /// Parses a delimited sequence of hex bytes
        /// </summary>
        /// <param name="src">The delimited hex</param>
        /// <param name="sep">The delimiter</param>
        public static IEnumerable<byte> parsebytes(string src, char sep = AsciSym.Comma)
            => src.Split(sep).Select(parsebyte);
               
        [MethodImpl(Inline)]
        static string format_hex_digits<T>(string digits, bool zpad = true, bool specifier = true)
            where T : unmanaged
        {
            var spec = specifier ? PreSpec : string.Empty;
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

        const byte MinCode = 48;
        
        const byte MaxLoCode = 57;

        const byte MinHiCode = 65;

        const byte MaxCode = 70;

        /// <summary>
        /// Defines the asci character codes for uppercase hex digits 1,2, ..., 9, A, ..., F
        /// </summary>
        static ReadOnlySpan<byte> HexCodes 
            => new byte[]{48,49,50,51,52,53,54,55,56,57,65,66,67,68,69,70};

        [MethodImpl(Inline)]
        static bit islo(char c)
            => (byte)c >= MinCode && (byte)c <= MaxLoCode;

        [MethodImpl(Inline)]
        static bit ishi(char c)
            => (byte)c >= MinHiCode && (byte)c <= MaxCode;


    }
}
