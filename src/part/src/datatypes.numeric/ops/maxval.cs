//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;


    partial struct Numeric
    {
        /// <summary>
        /// Returns the maximim value supported by a parametrically-identified primal type
        /// </summary>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T maxval<T>(T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte)
            || typeof(T) == typeof(short)
            || typeof(T) == typeof(int)
            || typeof(T) == typeof(long))
                return maxval_i<T>();
            else if(typeof(T) == typeof(byte)
            || typeof(T) == typeof(ushort)
            || typeof(T) == typeof(uint)
            || typeof(T) == typeof(ulong))
                return maxval_u<T>();
            else
                return maxval_f<T>();
        }


        [MethodImpl(Inline)]
        static T maxval_i<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return force<T>(i8max);
            else if(typeof(T) == typeof(short))
                return force<T>(i16max);
            else if(typeof(T) == typeof(int))
                return force<T>(i32max);
            else
                return force<T>(i64max);
        }

        [MethodImpl(Inline)]
        static T maxval_u<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return force<T>(u8max);
            else if(typeof(T) == typeof(ushort))
                return force<T>(u16max);
            else if(typeof(T) == typeof(uint))
                return force<T>(u32max);
            else
                return force<T>(u64max);
        }

        [MethodImpl(Inline)]
        static T maxval_f<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return force<T>(f32max);
            else if(typeof(T) == typeof(double))
                return force<T>(f64max);
            else
                throw no<T>();
        }

       /// <summary>
        /// The maximum value for an 8-bit signed integer
        /// </summary>
        const sbyte i8max = sbyte.MaxValue;

        /// <summary>
        /// The maximum value for an 8-bit unsigned integer
        /// </summary>
        const byte u8max = byte.MaxValue;

        /// <summary>
        /// The maximum value for a 16-bit signed integer
        /// </summary>
        const short i16max = short.MaxValue;

        /// <summary>
        /// The maximum value for a 16-bit unsigned integer
        /// </summary>
        const ushort u16max = ushort.MaxValue;

        /// <summary>
        /// The maximum value for a 32-bit signed integer
        /// </summary>
        const int i32max = int.MaxValue;

        /// <summary>
        /// The maximum value for a 32-bit unsigned integer
        /// </summary>
        const uint u32max = uint.MaxValue;

        /// <summary>
        /// The maximum value for a 64-bit signed integer
        /// </summary>
        const long i64max = long.MaxValue;

        /// <summary>
        /// The maximum value for a 64-bit unsigned integer
        /// </summary>
        const ulong u64max = ulong.MaxValue;

        /// <summary>
        /// The maximum value for a 32-bit float
        /// </summary>
        const float f32max = float.MaxValue;

        /// <summary>
        /// The maximum value for a 64-bit float
        /// </summary>
        const double f64max = double.MaxValue;
    }
}