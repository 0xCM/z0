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
        /// <summary>
        /// byte -> T
        /// </summary>
        /// <param name="src">The value to convert</param>
        /// <typeparam name="T">The target conversion type</typeparam>
        [MethodImpl(Inline), Op("convert8u"), NumericClosures(NumericKind.All)]
        public static T convert<T>(byte src)
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
        static T convert_i<T>(byte src)
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
        static T convert_u<T>(byte src)
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
        static T convert_x<T>(byte src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>((float)src);
            else if(typeof(T) == typeof(double))
                return generic<T>(FloatConvert.to64f(src));
            else if(typeof(T) == typeof(char))
                return  generic<T>((char)src);
            else            
                return unhandled<byte,T>(src);

        }
    }
}