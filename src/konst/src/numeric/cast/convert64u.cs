//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct NumericCast
    {
        [MethodImpl(Inline)]
        static T convert64u_u<T>(ulong src)
        {
            if(typeof(T) == typeof(byte))
                return generic<T>((byte)src);
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)src);
            else if(typeof(T) == typeof(uint))
                return generic<T>((uint)src);
            else if(typeof(T) == typeof(ulong))
                return generic<T>((ulong)src);
            else
                return convert64u_i<T>(src);
        }

        [MethodImpl(Inline)]
        static T convert64u_i<T>(ulong src)
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)src);
            else if(typeof(T) == typeof(short))
                return generic<T>((short)src);
            else if(typeof(T) == typeof(int))
                return generic<T>((int)src);
            else if(typeof(T) == typeof(long))
                return generic<T>((long)src);
            else
                return convert64u_x<T>(src);
        }

        [MethodImpl(Inline)]
        static T convert64u_x<T>(ulong src)
        {
            if(typeof(T) == typeof(float))
                return generic<T>(float32(src));
            else if(typeof(T) == typeof(double))
                return generic<T>(float64(src));
            else if(typeof(T) == typeof(char))
                return generic<T>((char)src);
            else
                return no<ulong,T>();
        }
    }
}