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
        /// <summary>
        /// If possible, applies the conversion S -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T force<S,T>(S src)
            => convert_u<S,T>(src);

        [MethodImpl(Inline)]
        static T convert_u<S,T>(S src)
        {
            if(typeof(S) == typeof(byte))
                return z.force<T>(uint8(src));
            else if(typeof(S) == typeof(ushort))
                return z.force<T>(uint16(src));
            else if(typeof(S) == typeof(uint))
                return z.force<T>(uint32(src));
            else if(typeof(S) == typeof(ulong))
                return z.force<T>(uint64(src));
            else
                return convert_i<S,T>(src);
        }

        [MethodImpl(Inline)]
        static T convert_i<S,T>(S src)
        {
            if(typeof(S) == typeof(sbyte))
                return z.force<T>(int8(src));
            else if(typeof(S) == typeof(short))
                return z.force<T>(int16(src));
            else if(typeof(S) == typeof(int))
                return z.force<T>(int32(src));
            else if(typeof(S) == typeof(long))
                return z.force<T>(int64(src));
            else
                return convert_x<S,T>(src);
        }

        [MethodImpl(Inline)]
        static T convert_x<S,T>(S src)
        {
            if(typeof(S) == typeof(float))
                return z.force<T>(float32(src));
            else if(typeof(S) == typeof(double))
                return z.force<T>(float64(src));
            else if(typeof(S) == typeof(char))
                return z.force<T>(char16(src));
            else
                return no<S,T>();
        }
    }
}