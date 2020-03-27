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

    using static Textual;
    using static P2K;     
    using static CharStacks;
    using static refs;
    using static As;

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

 
        [MethodImpl(Inline)]
        public static string format<T>(T src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return hexdigits_u(src, zpad, specifier, uppercase, prespec);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return hexdigits_i(src, zpad, specifier, uppercase, prespec);
            else 
                return hexdigits_f(src, zpad, specifier, uppercase, prespec);
        }

        /// <summary>
        /// Determines whether a character is a hex digit
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline)]
        public static bool isdigit(char c)
        {
            var u = Char.ToUpper(c);
            return islo(u) || ishi(u);
        }
        
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

        [MethodImpl(Inline)]
        public static (char d0, char d1) tuple(byte value)
        {
            ref readonly var codes = ref head(HexCodes);
            return (
                (char)skip(in codes, 0xF & value),
                (char)skip(in codes, (value >> 4) & 0xF)
            );
        }

        [MethodImpl(Inline)]
        public static (char d0, char d1, char d2, char d3) tuple(ushort value)
            => (digit(value,0), digit(value,1), digit(value,3), digit(value,3));

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
                throw Unsupported.define<T>();
        }

        /// <summary>
        /// Returns the 2-character hex representation of a byte
        /// </summary>
        /// <param name="value">The byte value</param>
        [MethodImpl(Inline)]
        static ReadOnlySpan<char> digits(byte value)
        {
            ref readonly var codes = ref head(HexCodes);
            var storage = chars(p2x1);
            ref var dst = ref storage.C0;
            
            seek(ref dst,0) = (char)skip(in codes, 0xF & value);
            seek(ref dst,1) = (char)skip(in codes, (value >> 4) & 0xF);
            return charspan(ref storage);
        }

        /// <summary>
        /// Returns the 4-character hex representation of an unsigned 16-bit integer
        /// </summary>
        /// <param name="value">The byte value</param>
        [MethodImpl(Inline)]
        static ReadOnlySpan<char> digits(ushort value)
        {
            const int count = 4;
            ref readonly var codes = ref head(HexCodes);
            var storage = chars(p2x2);
            ref var dst = ref storage.C0;

            for(var i=0; i < count; i++)
                @char(ref dst, i) = (char)skip(in codes, (value >> i*4) & 0xF);
            return charspan(ref storage);
        }

        /// <summary>
        /// Returns the 8-character hex representation of an unsigned 32-bit integer
        /// </summary>
        /// <param name="value">The byte value</param>
        [MethodImpl(Inline)]
        static ReadOnlySpan<char> digits(uint value)
        {
            const int count = 8;
            ref readonly var codes = ref head(HexCodes);
            var storage = chars(p2x3);
            ref var dst = ref storage.C0;

            for(var i=0; i < count; i++)
                @char(ref dst, i) = (char)skip(in codes, (int) ((value >> i*4) & 0xF));
            return charspan(ref storage);
        }

        /// <summary>
        /// Returns the 16-character hex representation of an unsigned 64-bit integer
        /// </summary>
        /// <param name="value">The byte value</param>
        [MethodImpl(Inline)]
        static ReadOnlySpan<char> digits(ulong value)
        {
            const int count = 16;
            ref readonly var codes = ref head(HexCodes);
            var storage = chars(p2x4);
            ref var dst = ref storage.C0;

            for(var i=0; i < count; i++)
                @char(ref dst, i) = (char)skip(in codes, (int) ((value >> i*4) & 0xF));
            return charspan(ref storage);
        }


               
        [MethodImpl(Inline)]
        static string format_hex_digits<T>(string digits, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            where T : unmanaged
        {
            var spec = specifier ? PreSpec : string.Empty;
            return zpad ?  (spec + digits.PadLeft(core.size<T>() * 2, '0')) : (spec + digits);
        }

        [MethodImpl(Inline)]
        static string hexdigits_i<T>(T src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return int8(src).FormatHex(zpad,specifier,uppercase,prespec);
            else if(typeof(T) == typeof(short))
                return int16(src).FormatHex(zpad,specifier,uppercase,prespec);
            else if(typeof(T) == typeof(int))
                return int32(src).FormatHex(zpad,specifier,uppercase,prespec);
            else 
                return int64(src).FormatHex(zpad,specifier,uppercase,prespec);
        } 

        [MethodImpl(Inline)]
        static string hexdigits_u<T>(T src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return uint8(src).FormatHex(zpad,specifier,uppercase,prespec);
            else if(typeof(T) == typeof(ushort))
                return uint16(src).FormatHex(zpad,specifier,uppercase,prespec);
            else if(typeof(T) == typeof(uint))
                return uint32(src).FormatHex(zpad,specifier,uppercase,prespec);
            else 
                return  uint64(src).FormatHex(zpad,specifier,uppercase,prespec);
        } 

        [MethodImpl(Inline)]
        static string hexdigits_f<T>(T src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return float32(src).FormatHex(zpad,specifier,uppercase,prespec);
            else if(typeof(T) == typeof(double))
                return float64(src).FormatHex(zpad,specifier,uppercase,prespec);
            else
                throw Unsupported.define<T>();
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
        static bool islo(char c)
            => (byte)c >= MinCode && (byte)c <= MaxLoCode;

        [MethodImpl(Inline)]
        static bool ishi(char c)
            => (byte)c >= MinHiCode && (byte)c <= MaxCode;
    }
}