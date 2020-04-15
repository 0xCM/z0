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

    partial class gmath
    {
        [MethodImpl(Inline), Op, NumericClosures(AllNumeric)]
        public static bit parse<T>(string src, out T dst)
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

        [MethodImpl(Inline)]
        static bit parse_u<T>(string src, out T dst)
            where T : unmanaged
        {
            dst = default;
            if(typeof(T) == typeof(byte))
            {
                if(math.parse(src, out byte x))
                {
                    dst = convert<T>(x);
                    return true;
                }
                else
                    return false;
            }
            else if(typeof(T) == typeof(ushort))
            {
                if(math.parse(src, out ushort x))
                {
                    dst = convert<T>(x);
                    return true;
                }
                else
                    return false;

            }
            else if(typeof(T) == typeof(uint))
            {
                if(math.parse(src, out uint x))
                {
                    dst = convert<T>(x);
                    return true;
                }
                else
                    return false;

            }
            else if(typeof(T) == typeof(ulong))
            {
                if(math.parse(src, out ulong x))
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
                if(math.parse(src, out sbyte x))
                {
                    dst = convert<T>(x);
                    return true;
                }
                else
                    return false;
            }
            else if(typeof(T) == typeof(short))
            {
                if(math.parse(src, out short x))
                {
                    dst = convert<T>(x);
                    return true;
                }
                else
                    return false;

            }
            else if(typeof(T) == typeof(int))
            {
                if(math.parse(src, out int x))
                {
                    dst = convert<T>(x);
                    return true;
                }
                else
                    return false;

            }
            else if(typeof(T) == typeof(long))
            {
                if(math.parse(src, out long x))
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
                if(math.parse(src, out float x))
                {
                    dst = convert<T>(x);
                    return true;
                }
                else
                    return false;
            }
            else if(typeof(T) == typeof(double))
            {
                if(math.parse(src, out double x))
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