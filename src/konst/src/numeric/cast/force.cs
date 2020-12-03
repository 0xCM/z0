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
        /// Unconditionally converts the source value to a value of parametric numeric type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T force<T>(sbyte src)
            => convert8i_u<T>(src);

        /// <summary>
        /// Unconditionally converts the source value to a value of parametric numeric type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T force<T>(byte src)
            => convert8u_u<T>(src);

        /// <summary>
        /// If possible, applies the conversion ushort -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T force<T>(ushort src)
            => convert16u_u<T>(src);

        /// <summary>
        /// If possible, applies the conversion short -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T force<T>(short src)
            => convert16i_u<T>(src);

        /// <summary>
        /// If possible, applies the conversion int -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T force<T>(int src)
            => convert32i_u<T>(src);

        /// <summary>
        /// If possible, applies the conversion uint -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T force<T>(uint src)
            => convert32u_u<T>(src);

        /// <summary>
        /// If possible, applies the conversion long -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T force<T>(long src)
            => convert64i_u<T>(src);

        /// <summary>
        /// If possible, applies the conversion ulong -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T force<T>(ulong src)
            => convert64u_u<T>(src);

        /// <summary>
        /// If possible, applies the conversion float -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T force<T>(float src)
            => convert32f_u<T>(src);

        /// <summary>
        /// If possible, applies the conversion double -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T force<T>(double src)
            => convert64f_u<T>(src);

        /// <summary>
        /// If possible, applies the conversion char -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T force<T>(char src)
            => convert16c_u<T>(src);

        /// <summary>
        /// If possible, applies the conversion S -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T force<S,T>(S src)
            => convert_u<S,T>(src);

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

        [MethodImpl(Inline)]
        static T convert_u<S,T>(S src)
        {
            if(typeof(S) == typeof(byte))
                return force<T>(uint8(src));
            else if(typeof(S) == typeof(ushort))
                return force<T>(uint16(src));
            else if(typeof(S) == typeof(uint))
                return force<T>(uint32(src));
            else if(typeof(S) == typeof(ulong))
                return force<T>(uint64(src));
            else
                return convert_i<S,T>(src);
        }

        [MethodImpl(Inline)]
        static T convert_i<S,T>(S src)
        {
            if(typeof(S) == typeof(sbyte))
                return force<T>(int8(src));
            else if(typeof(S) == typeof(short))
                return force<T>(int16(src));
            else if(typeof(S) == typeof(int))
                return force<T>(int32(src));
            else if(typeof(S) == typeof(long))
                return force<T>(int64(src));
            else
                return convert_x<S,T>(src);
        }

        [MethodImpl(Inline)]
        static T convert_x<S,T>(S src)
        {
            if(typeof(S) == typeof(float))
                return force<T>(float32(src));
            else if(typeof(S) == typeof(double))
                return force<T>(float64(src));
            else if(typeof(S) == typeof(char))
                return force<T>(char16(src));
            else
                return no<S,T>();
        }
    }
}