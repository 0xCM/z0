//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Konst;
    
    partial struct z
    {
        /// <summary>
        /// Unconditionally converts the source value to a value of parametric numeric type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T numeric<T>(sbyte src)
            => to_u<T>(src);

        [MethodImpl(Inline)]
        static T to_u<T>(sbyte src)
        {
            if(typeof(T) == typeof(byte))
                return z.generic<T>((byte)src);
            else if(typeof(T) == typeof(ushort))
                return z.generic<T>((ushort)src);
            else if(typeof(T) == typeof(uint))
                return z.generic<T>((uint)src);
            else if(typeof(T) == typeof(ulong)) 
                return z.generic<T>((ulong)src);
            else 
                return to_i<T>(src);
        }

        [MethodImpl(Inline)]
        static T to_i<T>(sbyte src)
        {
            if(typeof(T) == typeof(sbyte))
                return z.generic<T>((sbyte)src);
            else if(typeof(T) == typeof(short))
                return z.generic<T>((short)src);
            else if(typeof(T) == typeof(int))
                return z.generic<T>((int)src);
            else if(typeof(T) == typeof(long))
                return z.generic<T>((long)src);           
            else 
                return to_x<T>(src);
        }

        [MethodImpl(Inline)]
        static T to_x<T>(sbyte src)
        {
            if(typeof(T) == typeof(float))
                return z.generic<T>((float)src);
            else if(typeof(T) == typeof(double))
                return z.generic<T>((double)((long)src));
            else if(typeof(T) == typeof(char))
                return z.generic<T>((char)src);
            else            
                return no<sbyte,T>();
       }
   }
}