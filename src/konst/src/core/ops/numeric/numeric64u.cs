//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Konst;

    partial struct core
    {
        /// <summary>
        /// Unconditionally converts the source value to a value of parametric numeric type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T numeric<T>(ulong src)
            => numeric_u<T>(src);

        [MethodImpl(Inline)]
        static T numeric_u<T>(ulong src)
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
                return numeric_i<T>(src);
        }

        [MethodImpl(Inline)]
        static T numeric_i<T>(ulong src)
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
                return numeric_x<T>(src);    
        }

        [MethodImpl(Inline)]
        static T numeric_x<T>(ulong src)
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