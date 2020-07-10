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
    
    partial struct z
    {
        /// <summary>
        /// Unconditionally converts the source value to a value of parametric numeric type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T numeric<T>(float src)
            => numeric_u<T>(src);

        [MethodImpl(Inline)]
        static T numeric_u<T>(float src)
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(uint8(src));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(uint16(src));
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(src));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(src));
            else
                return numeric_i<T>(src);
        }

        [MethodImpl(Inline)]
        static T numeric_i<T>(float src)
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(int8(src));
            else if(typeof(T) == typeof(short))
                return generic<T>(int16(src));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(src));
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(src));
            else
                return numeric_x<T>(src);
        }

        [MethodImpl(Inline)]
        static T numeric_x<T>(float src)
        {
            if(typeof(T) == typeof(float))
                return generic<T>((float)src);
            else if(typeof(T) == typeof(double))
                return generic<T>((double)src);
            else if(typeof(T) == typeof(char))
                return generic<T>((char)(int)src);
            else            
                return no<float,T>();
        }
    }
}