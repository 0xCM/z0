//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static root;

    using SP = ScalarParser;

    [ApiHost]
    public class NumericParser
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static NumericParser<T> create<T>()
            where T : unmanaged
                => default(NumericParser<T>);

        /// <summary>
        /// Parses a transposition in canonical form (i j), if possible; otherwise returns the empty transposition
        /// </summary>
        /// <param name="src">The source text</param>
        public static ParseResult<Pair<T>> transposition<T>(string src)
            where T : unmanaged
        {
            var indices = src.RemoveAny(Chars.LParen, Chars.RParen).Trim().Split(Chars.Space);
            if(indices.Length != 2)
                return unparsed<Pair<T>>(src);

            var parser = create<T>();
            var result = Option.Try(() => Tuples.pair(parser.Parse(indices[0]).ValueOrDefault(), parser.Parse(indices[1]).ValueOrDefault()));
            if(result.IsSome())
                return parsed(src, result.Value());
            else
                return unparsed<Pair<T>>(src);
        }

        [MethodImpl(Inline)]
        public static T succeed<T>(string src)
            where T : unmanaged
                => parse<T>(src).ValueOrDefault();

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
                return parsed(src,dst);
            else
                return unparsed<T>(src);
        }

        [MethodImpl(Inline)]
        static bit parse_u<T>(string src, out T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return parse_8u(src, out dst);
            else if(typeof(T) == typeof(ushort))
                return parse_16u(src, out dst);
            else if(typeof(T) == typeof(uint))
                return parse_32u(src, out dst);
            else if(typeof(T) == typeof(ulong))
                return parse_64u(src, out dst);
            else
                return parse_i(src, out dst);
        }

        [MethodImpl(Inline)]
        static bit parse_i<T>(string src, out T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return parse_8i(src, out dst);
            else if(typeof(T) == typeof(short))
                return parse_16i(src, out dst);
            else if(typeof(T) == typeof(int))
                return parse_32i(src, out dst);
            else if(typeof(T) == typeof(long))
                return parse_64i(src, out dst);
            else
                return parse_f(src, out dst);
        }

        [MethodImpl(Inline)]
        static bit parse_f<T>(string src, out T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return parse_32f(src, out dst);
            else if(typeof(T) == typeof(double))
                return parse_64f(src, out dst);
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Int8k)]
        static bit parse_8i<T>(string src, out T dst)
        {
            if(SP.parse(src, out sbyte x))
            {
                dst = @as<T>(x);
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }

        [MethodImpl(Inline), Op, Closures(UInt8k)]
        static bit parse_8u<T>(string src, out T dst)
        {
            if(SP.parse(src, out byte x))
            {
                dst = @as<T>(x);
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }

        [MethodImpl(Inline), Op, Closures(UInt16k)]
        static bit parse_16u<T>(string src, out T dst)
        {
            if(SP.parse(src, out ushort x))
            {
                dst = @as<T>(x);
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }

        [MethodImpl(Inline), Op, Closures(UInt32k)]
        static bit parse_32u<T>(string src, out T dst)
        {
            if(SP.parse(src, out uint x))
            {
                dst = @as<T>(x);
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        static bit parse_64u<T>(string src, out T dst)
        {
            if(SP.parse(src, out ulong x))
            {
                dst = @as<T>(x);
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }

        [MethodImpl(Inline), Op, Closures(Int16k)]
        static bit parse_16i<T>(string src, out T dst)
        {
            if(SP.parse(src, out short x))
            {
                dst = @as<T>(x);
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }

        [MethodImpl(Inline), Op, Closures(Int32k)]
        static bit parse_32i<T>(string src, out T dst)
        {
            if(SP.parse(src, out int x))
            {
                dst = @as<T>(x);
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }

        [MethodImpl(Inline), Op, Closures(Int64k)]
        static bit parse_64i<T>(string src, out T dst)
        {
            if(SP.parse(src, out long x))
            {
                dst = @as<T>(x);
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }

        [MethodImpl(Inline), Op, Closures(Float64k)]
        static bit parse_64f<T>(string src, out T dst)
        {
            if(SP.parse(src, out double x))
            {
                dst = @as<T>(x);
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }

        [MethodImpl(Inline), Op, Closures(Float32k)]
        static bit parse_32f<T>(string src, out T dst)
        {
            if(SP.parse(src, out float x))
            {
                dst = @as<T>(x);
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }
    }
}