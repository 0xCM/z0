//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static NumericCast;

    [ApiHost("parser")]
    public class NumericParser
    {
        /// <summary>
        /// Parses a transposition in canonical form (i j), if possible; otherwise returns the empty transposition
        /// </summary>
        /// <param name="src">The source text</param>
        public static ParseResult<Pair<T>> transposition<T>(string src)
            where T : unmanaged
        {
            var indices = src.RemoveAny(Chars.LParen, Chars.RParen).Trim().Split(Chars.Space);
            if(indices.Length != 2)
                return ParseResult.Fail<Pair<T>>(src);

            var parser = Parsers.numeric<T>();
            var result = Option.Try(() => Tuples.pair(parser.Parse(indices[0]).ValueOrDefault(), parser.Parse(indices[1]).ValueOrDefault()));
            if(result.IsSome())
                return ParseResult.Success(src, result.Value());
            else
                return ParseResult.Fail<Pair<T>>(src);
        }

        [MethodImpl(Inline)]
        public static T succeed<T>(string src)
            where T : unmanaged
                => NumericParser.parse<T>(src).ValueOrDefault();

        /// <summary>
        /// Creates an infallible numeric parser
        /// </summary>
        /// <typeparam name="T">The numeric type to parse</typeparam>
        [MethodImpl(Inline)]
        public static NumericParserNoFail<T> infallible<T>()
            where T : unmanaged
                => default(NumericParserNoFail<T>);

        [MethodImpl(Inline), Op, NumericClosures(AllNumeric)]
        static bit parse<T>(string src, out T dst)
            where T : unmanaged
                => parse_u(src, out dst);

        /// <summary>
        /// Attempts to parse the source text as a parametrically-identified type
        /// </summary>
        /// <param name="src">The source text</param>
        [MethodImpl(Inline), Op, NumericClosures(AllNumeric)]
        public static ParseResult<T> parse<T>(string src)
            where T : unmanaged
        {
            if(parse(src, out T dst))
                return ParseResult.Success(src,dst);
            else
                return ParseResult.Fail<T>(src);
        }

        static ScalarParser SP
            => ScalarParser.Service;

        [MethodImpl(Inline)]
        static bit parse_u<T>(string src, out T dst)
            where T : unmanaged
        {
            dst = default;
            if(typeof(T) == typeof(byte))
            {
                if(SP.parse(src, out byte x))
                {
                    dst = force<T>(x);
                    return true;
                }
                else
                    return false;
            }
            else if(typeof(T) == typeof(ushort))
            {
                if(SP.parse(src, out ushort x))
                {
                    dst = force<T>(x);
                    return true;
                }
                else
                    return false;

            }
            else if(typeof(T) == typeof(uint))
            {
                if(SP.parse(src, out uint x))
                {
                    dst = force<T>(x);
                    return true;
                }
                else
                    return false;

            }
            else if(typeof(T) == typeof(ulong))
            {
                if(SP.parse(src, out ulong x))
                {
                    dst = force<T>(x);
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
                    dst = force<T>(x);
                    return true;
                }
                else
                    return false;
            }
            else if(typeof(T) == typeof(short))
            {
                if(SP.parse(src, out short x))
                {
                    dst = force<T>(x);
                    return true;
                }
                else
                    return false;

            }
            else if(typeof(T) == typeof(int))
            {
                if(SP.parse(src, out int x))
                {
                    dst = force<T>(x);
                    return true;
                }
                else
                    return false;

            }
            else if(typeof(T) == typeof(long))
            {
                if(SP.parse(src, out long x))
                {
                    dst = force<T>(x);
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
                    dst = force<T>(x);
                    return true;
                }
                else
                    return false;
            }
            else if(typeof(T) == typeof(double))
            {
                if(SP.parse(src, out double x))
                {
                    dst = force<T>(x);
                    return true;
                }
                else
                    return false;
            }
            return false;
        }
    }
}