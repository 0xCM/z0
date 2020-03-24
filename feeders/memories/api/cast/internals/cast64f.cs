//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static As;
    using static CastInternals;

    partial class Cast
    {
        [MethodImpl(Inline)]
        static T to_u<T>(double src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(to8u(src));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(to16u(src));
            else if(typeof(T) == typeof(uint))
                return generic<T>(to32u(src));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(to64u(src));
            else
                return to_i<T>(src);
        }

        [MethodImpl(Inline)]
        static T to_i<T>(double src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(to8i(src));
            else if(typeof(T) == typeof(short))
                return generic<T>(to16i(src));
            else if(typeof(T) == typeof(int))
                return generic<T>(to32i(src));
            else if(typeof(T) == typeof(long))
                return generic<T>(to64i(src));
            else
                return convert_x<T>(src);
        }

        [MethodImpl(Inline)]
        static T convert_x<T>(double src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>((float)src);
            else if(typeof(T) == typeof(double))
                return generic<T>(src);
            else if(typeof(T) == typeof(char))
                return generic<T>((char)(int)src);
            else            
                return unhandled<double,T>(src);
        }
    }
}