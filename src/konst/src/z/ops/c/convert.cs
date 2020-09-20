//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static System.Runtime.CompilerServices.Unsafe;

    using static Konst;

    partial struct z
    {

        /// <summary>
        /// If possible, applies the conversion S -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T convert<S,T>(S src)
            => convert_u<S,T>(src);

        /// <summary>
        /// Unconditionally converts the source value to a value of parametric numeric type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T convert<T>(sbyte src)
            => convert8i_u<T>(src);

        /// <summary>
        /// Unconditionally converts the source value to a value of parametric numeric type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T convert<T>(byte src)
            => convert8u_u<T>(src);

        /// <summary>
        /// If possible, applies the conversion ushort -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T convert<T>(ushort src)
            => convert16u_u<T>(src);

        /// <summary>
        /// If possible, applies the conversion short -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T convert<T>(short src)
            => convert16i_u<T>(src);

        /// <summary>
        /// If possible, applies the conversion int -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T convert<T>(int src)
            => convert32i_u<T>(src);

        /// <summary>
        /// If possible, applies the conversion uint -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T convert<T>(uint src)
            => convert32u_u<T>(src);

        /// <summary>
        /// If possible, applies the conversion long -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T convert<T>(long src)
            => convert64i_u<T>(src);

        /// <summary>
        /// If possible, applies the conversion ulong -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T convert<T>(ulong src)
            => convert64u_u<T>(src);

        /// <summary>
        /// If possible, applies the conversion float -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T convert<T>(float src)
            => convert32f_u<T>(src);

        /// <summary>
        /// If possible, applies the conversion double -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T convert<T>(double src)
            => convert64f_u<T>(src);

        /// <summary>
        /// If possible, applies the conversion char -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T convert<T>(char src)
            => convert16c_u<T>(src);

        /// <summary>
        /// If possible, applies the conversion byte -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="t">A target representative used only for type inference</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T convert<T>(byte src, T t)
            where T : unmanaged
                => z.convert<T>(src);

        /// <summary>
        /// If possible, applies the conversion sbyte -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="t">A target representative used only for type inference</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T convert<T>(sbyte src, T t)
            where T : unmanaged
                => z.convert<T>(src);

        /// <summary>
        /// If possible, applies the conversion ushort -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="t">A target representative used only for type inference</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T convert<T>(ushort src, T t)
            where T : unmanaged
                => z.convert<T>(src);

        /// <summary>
        /// If possible, applies the conversion short -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="t">A target representative used only for type inference</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T convert<T>(short src, T t)
            where T : unmanaged
                => z.convert<T>(src);

        /// <summary>
        /// If possible, applies the conversion int -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="t">A target representative used only for type inference</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T convert<T>(int src, T t)
            where T : unmanaged
                => z.convert<T>(src);

        /// <summary>
        /// If possible, applies the conversion uint -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="t">A target representative used only for type inference</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T convert<T>(uint src, T t)
            where T : unmanaged
                => z.convert<T>(src);

        /// <summary>
        /// If possible, applies the conversion long -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="t">A target representative used only for type inference</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T convert<T>(long src, T t)
            where T : unmanaged
                => z.convert<T>(src);

        /// <summary>
        /// If possible, applies the conversion ulong -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="t">A target representative used only for type inference</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T convert<T>(ulong src, T t)
            where T : unmanaged
                => z.convert<T>(src);

        /// <summary>
        /// If possible, applies the conversion float -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="t">A target representative used only for type inference</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T convert<T>(float src, T t)
            where T : unmanaged
                => z.convert<T>(src);

        /// <summary>
        /// If possible, applies the conversion double -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="t">A target representative used only for type inference</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T convert<T>(double src, T t)
            where T : unmanaged
                => z.convert<T>(src);

        [MethodImpl(Inline)]
        static T convert_u<S,T>(S src)
        {
            if(typeof(S) == typeof(byte))
                return convert<T>(uint8(src));
            else if(typeof(S) == typeof(ushort))
                return convert<T>(uint16(src));
            else if(typeof(S) == typeof(uint))
                return convert<T>(uint32(src));
            else if(typeof(S) == typeof(ulong))
                return convert<T>(uint64(src));
            else
                return convert_i<S,T>(src);
        }

        [MethodImpl(Inline)]
        static T convert_i<S,T>(S src)
        {
            if(typeof(S) == typeof(sbyte))
                return convert<T>(int8(src));
            else if(typeof(S) == typeof(short))
                return convert<T>(int16(src));
            else if(typeof(S) == typeof(int))
                return convert<T>(int32(src));
            else if(typeof(S) == typeof(long))
                return convert<T>(int64(src));
            else
                return convert_x<S,T>(src);
        }

        [MethodImpl(Inline)]
        static T convert_x<S,T>(S src)
        {
            if(typeof(S) == typeof(float))
                return convert<T>(float32(src));
            else if(typeof(S) == typeof(double))
                return convert<T>(float64(src));
            else if(typeof(S) == typeof(char))
                return convert<T>(char16(src));
            else
                return no<S,T>();
        }
    }
}