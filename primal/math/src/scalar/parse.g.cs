//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gmath
    {
        [MethodImpl(Inline)]
        public static T parse<T>(string src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return parse_u<T>(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return parse_i<T>(src);
            else 
                return parse_f<T>(src);
        }

        [MethodImpl(Inline)]
        public static ref T parse<T>(string src, out T dst)
            where T : unmanaged
        {
            dst = parse<T>(src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        static T parse_i<T>(string src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.parse(src, out sbyte x));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.parse(src, out short x));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.parse(src, out int x));
            else 
                return generic<T>(math.parse(src, out long x));
        }

        [MethodImpl(Inline)]
        static T parse_u<T>(string src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.parse(src, out byte x));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.parse(src, out ushort x));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.parse(src, out uint x));
            else
                return generic<T>(math.parse(src, out ulong x));
        }

        [MethodImpl(Inline)]
        static T parse_f<T>(string src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(math.parse(src, out float x));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.parse(src, out double x));
            else            
                throw unsupported<T>();
        }
    }
}