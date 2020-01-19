//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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

        [MethodImpl(Inline), Op("convert32f"), PrimalClosures(PrimalKind.All)]
        public static T convert<T>(float src)
            where T : unmanaged
                => convert_u<T>(src);

        [MethodImpl(Inline)]
        static T convert_u<T>(float src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(FloatConvert.to8u(src));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(FloatConvert.to16u(src));
            else if(typeof(T) == typeof(uint))
                return generic<T>(FloatConvert.to32u(src));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(FloatConvert.to64u(src));
            else
                return convert_i<T>(src);
        }

        [MethodImpl(Inline)]
        static T convert_i<T>(float src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(FloatConvert.to8i(src));
            else if(typeof(T) == typeof(short))
                return generic<T>(FloatConvert.to16i(src));
            else if(typeof(T) == typeof(int))
                return generic<T>(FloatConvert.to32i(src));
            else if(typeof(T) == typeof(long))
                return generic<T>(FloatConvert.to64i(src));
            else
                return convert_x<T>(src);
        }


        [MethodImpl(Inline)]
        static T convert_x<T>(float src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>((float)src);
            else if(typeof(T) == typeof(double))
                return generic<T>((double)src);
            else if(typeof(T) == typeof(char))
                return generic<T>((char)(int)src);
            else            
                return unhandled<float,T>(src);
        }
    }
}