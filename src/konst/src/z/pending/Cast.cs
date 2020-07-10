//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Konst;

    public static class Cast
    {
        /// <summary>
        /// Unconditionally casts from one numeric kind to another
        /// </summary>
        /// <param name="src">The soruce value</param>
        /// <typeparam name="S">The source numeric kind</typeparam>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]   
        public static T to<S,T>(S src)
            => Cast.numeric_u<S,T>(src);

        [MethodImpl(Inline)]   
        public static T to<T>(sbyte src)
            => z.numeric<T>(src);

        [MethodImpl(Inline)]   
        public static T to<T>(byte src)
            => z.numeric<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(short src)
            => z.numeric<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(ushort src)
            => z.numeric<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(int src)
            => z.numeric<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(uint src)
            => z.numeric<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(long src)
            => z.numeric<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(ulong src)
            => z.numeric<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(float src)
            => z.numeric<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(double src)
            => z.numeric<T>(src);
 
        [MethodImpl(Inline)]
        internal static T numeric_u<S,T>(S src)
        {
            if(typeof(S) == typeof(byte))
                return to<T>(z.uint8(src));
            else if(typeof(S) == typeof(ushort))
                return to<T>(z.uint16(src));
            else if(typeof(S) == typeof(uint))
                return to<T>(z.uint32(src));
            else if(typeof(S) == typeof(ulong))
                return to<T>(z.uint64(src));
            else
                return numeric_i<S,T>(src);
        }

        [MethodImpl(Inline)]
        static T numeric_i<S,T>(S src)
        {
            if(typeof(S) == typeof(sbyte))
                return to<T>(z.int8(src));
            else if(typeof(S) == typeof(short))
                return to<T>(z.int16(src));
            else if(typeof(S) == typeof(int))
                return to<T>(z.int32(src));
            else if(typeof(S) == typeof(long))
                return to<T>(z.int64(src));
            else 
                return numeric_x<S,T>(src);
        }

        [MethodImpl(Inline)]
        static T numeric_x<S,T>(S src)
        {
            if(typeof(S) == typeof(float))
                return to<T>(z.float32(src));
            else if(typeof(S) == typeof(double))
                return to<T>(z.float64(src));
            else if(typeof(S) == typeof(char))
                return z.numeric<T>(z.char16(src));
            else            
                return no<S,T>();
        }
    }
}