//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static CastNumeric;

    using SP = ScalarParser;

    public readonly struct NumericParser<T> : IParser<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public ParseResult<T> Parse(string src)
            => NumericParser.parse<T>(src);
    }

    public readonly struct NumericParserInfallible<T> : IInfallibleParser<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public T Parse(string src)
            => NumericParser.parse<T>(src).ValueOrDefault();
        
        public T Zero => default;
    }

    public class ScalarParser
    {
        [MethodImpl(Inline)]
        public static bit parse(string src, out sbyte dst)
            => sbyte.TryParse(src, out dst);

        [MethodImpl(Inline)]
        public static bit parse(string src, out byte dst)
            => byte.TryParse(src, out dst);

        [MethodImpl(Inline)]
        public static bit parse(string src, out short dst)
            => short.TryParse(src, out dst);

        [MethodImpl(Inline)]
        public static bit parse(string src, out ushort dst)
            => ushort.TryParse(src, out dst);

        [MethodImpl(Inline)]
        public static bit parse(string src, out int dst)
            => int.TryParse(src, out dst);

        [MethodImpl(Inline)]
        public static bit parse(string src, out uint dst)
            => uint.TryParse(src, out dst);

        [MethodImpl(Inline)]
        public static bit parse(string src, out long dst)
            => long.TryParse(src, out dst);

        [MethodImpl(Inline)]
        public static bit parse(string src, out ulong dst)
            => ulong.TryParse(src, out dst);

        [MethodImpl(Inline)]
        public static bit parse(string src, out float dst)
            => float.TryParse(src, out dst);

        [MethodImpl(Inline)]
        public static bit parse(string src, out double dst)
            => double.TryParse(src, out dst);            
    }

    [ApiHost("parser")]
    public class NumericParser  : IApiHost<NumericParser>
    {
        /// <summary>
        /// Creates a numeric parser
        /// </summary>
        /// <typeparam name="T">The numeric type to parse</typeparam>
        [MethodImpl(Inline)]
        public static NumericParser<T> create<T>()
            where T : unmanaged
                => default(NumericParser<T>);

        /// <summary>
        /// Creates an infallible numeric parser
        /// </summary>
        /// <typeparam name="T">The numeric type to parse</typeparam>
        [MethodImpl(Inline)]
        public static NumericParserInfallible<T> infallible<T>()
            where T : unmanaged
                => default(NumericParserInfallible<T>);

        [MethodImpl(Inline), Op, NumericClosures(AllNumeric)]
        static bit parse<T>(string src, out T dst)
            where T : unmanaged
                => parse_u(src, out dst);

        /// <summary>
        /// Attempts to parse the source text as a parametrically-identified type
        /// </summary>
        /// <param name="src">The source text</param>
        [MethodImpl(Inline), Op, NumericClosures(AllNumeric)]
        internal static ParseResult<T> parse<T>(string src)
            where T : unmanaged
        {
            if(parse(src, out T dst))
                return ParseResult.Success(src,dst);
            else
                return ParseResult.Fail<T>(src);
        }

        [MethodImpl(Inline)]
        static bit parse_u<T>(string src, out T dst)
            where T : unmanaged
        {
            dst = default;
            if(typeof(T) == typeof(byte))
            {
                if(SP.parse(src, out byte x))
                {
                    dst = convert<T>(x);
                    return true;
                }
                else
                    return false;
            }
            else if(typeof(T) == typeof(ushort))
            {
                if(SP.parse(src, out ushort x))
                {
                    dst = convert<T>(x);
                    return true;
                }
                else
                    return false;

            }
            else if(typeof(T) == typeof(uint))
            {
                if(SP.parse(src, out uint x))
                {
                    dst = convert<T>(x);
                    return true;
                }
                else
                    return false;

            }
            else if(typeof(T) == typeof(ulong))
            {
                if(SP.parse(src, out ulong x))
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
                if(SP.parse(src, out sbyte x))
                {
                    dst = convert<T>(x);
                    return true;
                }
                else
                    return false;
            }
            else if(typeof(T) == typeof(short))
            {
                if(SP.parse(src, out short x))
                {
                    dst = convert<T>(x);
                    return true;
                }
                else
                    return false;

            }
            else if(typeof(T) == typeof(int))
            {
                if(SP.parse(src, out int x))
                {
                    dst = convert<T>(x);
                    return true;
                }
                else
                    return false;

            }
            else if(typeof(T) == typeof(long))
            {
                if(SP.parse(src, out long x))
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
                if(SP.parse(src, out float x))
                {
                    dst = convert<T>(x);
                    return true;
                }
                else
                    return false;
            }
            else if(typeof(T) == typeof(double))
            {
                if(SP.parse(src, out double x))
                {
                    dst = convert<T>(x);
                    return true;
                }
                else
                    return false;
            }
            return false;
        }    
    }
}