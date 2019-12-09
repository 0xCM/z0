//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gmath
    {
        [MethodImpl(Inline)]
        public static T parse<T>(string src)
            where T : unmanaged
        {
            if(!parse(src, out T dst))
            {
                return dst;
            }
            else
            {
                Errors.Throw(src);
                return default;
            }                
        }
        
        [MethodImpl(Inline)]
        public static bit parse<T>(string src, out T dst)
            where T : unmanaged
        {
            dst = default;
            if(typeof(T) == typeof(byte))
            {
                if(math.parse(src, out byte x))
                {
                    dst = generic<T>(x);
                    return true;
                }
                else
                    return false;
            }
            else if(typeof(T) == typeof(ushort))
            {
                if(math.parse(src, out ushort x))
                {
                    dst = generic<T>(x);
                    return true;
                }
                else
                    return false;

            }
            else if(typeof(T) == typeof(uint))
            {
                if(math.parse(src, out uint x))
                {
                    dst = generic<T>(x);
                    return true;
                }
                else
                    return false;

            }
            else if(typeof(T) == typeof(ulong))
            {
                if(math.parse(src, out ulong x))
                {
                    dst = generic<T>(x);
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
                    dst = generic<T>(x);
                    return true;
                }
                else
                    return false;
            }
            else if(typeof(T) == typeof(short))
            {
                if(math.parse(src, out short x))
                {
                    dst = generic<T>(x);
                    return true;
                }
                else
                    return false;

            }
            else if(typeof(T) == typeof(int))
            {
                if(math.parse(src, out int x))
                {
                    dst = generic<T>(x);
                    return true;
                }
                else
                    return false;

            }
            else if(typeof(T) == typeof(long))
            {
                if(math.parse(src, out long x))
                {
                    dst = generic<T>(x);
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
                    dst = generic<T>(x);
                    return true;
                }
                else
                    return false;
            }
            else if(typeof(T) == typeof(double))
            {
                if(math.parse(src, out double x))
                {
                    dst = generic<T>(x);
                    return true;
                }
                else
                    return false;

            }
            return false;
        }    
    }
}