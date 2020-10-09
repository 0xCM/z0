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

    [ApiHost("numeric.cast")]
    public readonly struct NumericCast
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T force<T>(object src)
            where T : unmanaged
                => force_u<T>(src);

        [MethodImpl(Inline)]
        static T force_u<T>(object src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return force<T>(unbox<byte>(src));
            else if(typeof(T) == typeof(ushort))
                return force<T>(unbox<ushort>(src));
            else if(typeof(T) == typeof(uint))
                return force<T>(unbox<uint>(src));
            else if(typeof(T) == typeof(ulong))
                return force<T>(unbox<ulong>(src));
            else
                return force_i<T>(src);
        }

        [MethodImpl(Inline)]
        static T force_i<T>(object src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return force<T>(unbox<sbyte>(src));
            else if(typeof(T) == typeof(short))
                return force<T>(unbox<short>(src));
            else if(typeof(T) == typeof(int))
                return force<T>(unbox<int>(src));
            else if(typeof(T) == typeof(long))
                return force<T>(unbox<long>(src));
            else
                return force_x<T>(src);
        }

        [MethodImpl(Inline)]
        static T force_x<T>(object src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return force<T>(unbox<float>(src));
            else if(typeof(T) == typeof(double))
                return force<T>(unbox<double>(src));
            else
                throw no<T>();
        }

        /// <summary>
        /// If possible, applies the conversion S -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T force<S,T>(S src)
            where T : unmanaged
            where S : unmanaged
                => z.force<S,T>(src);

        /// <summary>
        /// If possible, applies the conversion byte -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T force<T>(byte src, T t = default)
            where T : unmanaged
                => z.force<T>(src);

        /// <summary>
        /// If possible, applies the conversion sbyte -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T force<T>(sbyte src, T t = default)
            where T : unmanaged
                => z.force<T>(src);

        /// <summary>
        /// If possible, applies the conversion ushort -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T force<T>(ushort src, T t = default)
            where T : unmanaged
                => z.force<T>(src);

        /// <summary>
        /// If possible, applies the conversion short -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T force<T>(short src, T t = default)
            where T : unmanaged
                => z.force<T>(src);

        /// <summary>
        /// If possible, applies the conversion int -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T force<T>(int src, T t = default)
            where T : unmanaged
                => z.force<T>(src);

        /// <summary>
        /// If possible, applies the conversion uint -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T force<T>(uint src, T t = default)
            where T : unmanaged
                => z.force<T>(src);

        /// <summary>
        /// If possible, applies the conversion long -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T force<T>(long src, T t = default)
            where T : unmanaged
                => z.force<T>(src);

        /// <summary>
        /// If possible, applies the conversion ulong -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T force<T>(ulong src, T t = default)
            where T : unmanaged
                => z.force<T>(src);

        /// <summary>
        /// If possible, applies the conversion float -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T force<T>(float src, T t = default)
            where T : unmanaged
                => z.force<T>(src);

        /// <summary>
        /// If possible, applies the conversion double -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T force<T>(double src, T t = default)
            where T : unmanaged
                => z.force<T>(src);
   }
}