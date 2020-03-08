//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Globalization;

    using static Root;

    public static class NumericParser
    {
        /// <summary>
        /// Attempts to parse a hex string as an unsigned long
        /// </summary>
        /// <param name="src">The source text</param>
        public static Option<ulong> ParseHex(string src)
        {            
            static string clean(string src)
                => src.Remove("0x").RemoveAny(AsciLower.h);            

            if(ulong.TryParse(clean(src), NumberStyles.HexNumber, null,  out ulong value))
                return value;
            return default;
        }

        [MethodImpl(Inline), NumericClosures(NumericKind.All)]
        public static T parse<T>(string src)
            where T : unmanaged
        {
            if(parse(src, out T dst))
                return dst;
            else
                return ParseError<T>(src);
        }
        
        [MethodImpl(Inline)]
        public static bit parse<T>(string src, out T dst)
            where T : unmanaged
        {
            dst = default;
            if(typeof(T) == typeof(byte))
            {
                if(parse(src, out byte x))
                {
                    dst = convert<T>(x);
                    return true;
                }
                else
                    return false;
            }
            else if(typeof(T) == typeof(ushort))
            {
                if(parse(src, out ushort x))
                {
                    dst = convert<T>(x);
                    return true;
                }
                else
                    return false;

            }
            else if(typeof(T) == typeof(uint))
            {
                if(parse(src, out uint x))
                {
                    dst = convert<T>(x);
                    return true;
                }
                else
                    return false;

            }
            else if(typeof(T) == typeof(ulong))
            {
                if(parse(src, out ulong x))
                {
                    dst = convert<T>(x);
                    return true;
                }
                else
                    return false;

            }
            else
                return parse_i(src, out dst);

        }

        [MethodImpl(Inline)]
        static bit parse_i<T>(string src, out T dst)
            where T : unmanaged
        {
            dst = default;
            if(typeof(T) == typeof(sbyte))
            {
                if(parse(src, out sbyte x))
                {
                    dst = convert<T>(x);
                    return true;
                }
                else
                    return false;
            }
            else if(typeof(T) == typeof(short))
            {
                if(parse(src, out short x))
                {
                    dst = convert<T>(x);
                    return true;
                }
                else
                    return false;

            }
            else if(typeof(T) == typeof(int))
            {
                if(parse(src, out int x))
                {
                    dst = convert<T>(x);
                    return true;
                }
                else
                    return false;

            }
            else if(typeof(T) == typeof(long))
            {
                if(parse(src, out long x))
                {
                    dst = convert<T>(x);
                    return true;
                }
                else
                    return false;

            }
            else 
                return parse_f(src, out dst);
        }

        [MethodImpl(Inline)]
        static bit parse_f<T>(string src, out T dst)
            where T : unmanaged
        {
            dst = default;
            
            if(typeof(T) == typeof(float))
            {
                if(parse(src, out float x))
                {
                    dst = convert<T>(x);
                    return true;
                }
                else
                    return false;
            }
            else if(typeof(T) == typeof(double))
            {
                if(parse(src, out double x))
                {
                    dst = convert<T>(x);
                    return true;
                }
                else
                    return false;

            }
            return false;
        }    

        static T ParseError<T>(string src)
            where T : unmanaged
        {
            var msg = $"Attempted to parse '{src}':{typeof(T).DisplayName()} but failed";
            AppErrors.Throw(msg);

            return default;
        }
 

        [MethodImpl(Inline), Op]
        static bit parse(string src, out sbyte dst)
            => sbyte.TryParse(src, out dst);

        [MethodImpl(Inline), Op]
        static bit parse(string src, out byte dst)
            => byte.TryParse(src, out dst);

        [MethodImpl(Inline), Op]
        static bit parse(string src, out short dst)
            => short.TryParse(src, out dst);

        [MethodImpl(Inline), Op]
        static bit parse(string src, out ushort dst)
            => ushort.TryParse(src, out dst);

        [MethodImpl(Inline), Op]
        static bit parse(string src, out int dst)
            => int.TryParse(src, out dst);

        [MethodImpl(Inline), Op]
        static bit parse(string src, out uint dst)
            => uint.TryParse(src, out dst);

        [MethodImpl(Inline), Op]
        static bit parse(string src, out long dst)
            => long.TryParse(src, out dst);

        [MethodImpl(Inline), Op]
        static bit parse(string src, out ulong dst)
            => ulong.TryParse(src, out dst);

        [MethodImpl(Inline), Op]
        static bit parse(string src, out float dst)
            => float.TryParse(src, out dst);

        [MethodImpl(Inline), Op]
        static bit parse(string src, out double dst)
            => double.TryParse(src, out dst);
    }
}