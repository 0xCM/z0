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
        static T to_i<T>(ulong src)
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)src);
            else if(typeof(T) == typeof(short))
                return generic<T>((short)src);
            else if(typeof(T) == typeof(int))
                return generic<T>((int)src);
            else  
                return generic<T>((long)src);           
        }

        [MethodImpl(Inline)]
        static T to_u<T>(ulong src)
        {
            if(typeof(T) == typeof(byte))
                return generic<T>((byte)src);
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)src);
            else if(typeof(T) == typeof(uint))
                return generic<T>((uint)src);
            else  
                return generic<T>((ulong)src);
        }

        [MethodImpl(Inline)]
        static T to_x<T>(ulong src)
        {
            if(typeof(T) == typeof(float))
                return As.generic<T>((float)src);
            else if(typeof(T) == typeof(double))
                return As.generic<T>((double)(long)src);
            else if(typeof(T) == typeof(char))
                return As.generic<T>((char)src);
            else            
                return unhandled<ulong,T>(src);
        }
    }
}