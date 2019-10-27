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

    partial class Converter
    {

        [MethodImpl(Inline)]
        public static T convert<T>(double src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return convert_i<T>(src);
            else if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return convert_u<T>(src);
            else
                return convert_x<T>(src);
        }

        [MethodImpl(Inline)]
        static T convert_i<T>(double src)
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(FloatConvert.to8i(src));
            else if(typeof(T) == typeof(short))
                return generic<T>(FloatConvert.to16i(src));
            else if(typeof(T) == typeof(int))
                return generic<T>(FloatConvert.to32i(src));
            else  
                return generic<T>(FloatConvert.to64i(src));
        }

        [MethodImpl(Inline)]
        static T convert_u<T>(double src)
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(FloatConvert.to8u(src));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(FloatConvert.to16u(src));
            else if(typeof(T) == typeof(uint))
                return generic<T>(FloatConvert.to32u(src));
            else  
                return generic<T>(FloatConvert.to64u(src));
        }

        [MethodImpl(Inline)]
        static T convert_x<T>(double src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return g32f<T>((float)src);
            else if(typeof(T) == typeof(double))
                return g64f<T>(src);
            else if(typeof(T) == typeof(char))
                return g16ch<T>((char)(int)src);
            else            
                return unhandled<double,T>(src);
        }
    }
}