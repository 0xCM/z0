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
        /// Returns the minimum value supported by a parametrically-identified primal type
        /// </summary>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T minval<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte)
            || typeof(T) == typeof(short)
            || typeof(T) == typeof(int)
            || typeof(T) == typeof(long))
                return minval_i<T>();
            else if(typeof(T) == typeof(byte)
            || typeof(T) == typeof(ushort)
            || typeof(T) == typeof(uint)
            || typeof(T) == typeof(ulong))
                return minval_u<T>();
            else
                return minval_f<T>();
        }

        [MethodImpl(Inline)]
        static T minval_i<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return force<T>(sbyte.MinValue);
            else if(typeof(T) == typeof(short))
                return force<T>(short.MinValue);
            else if(typeof(T) == typeof(int))
                return force<T>(int.MinValue);
            else
                return force<T>(long.MinValue);
        }

        [MethodImpl(Inline)]
        static T minval_u<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return force<T>(byte.MinValue);
            else if(typeof(T) == typeof(ushort))
                return force<T>(ushort.MinValue);
            else if(typeof(T) == typeof(uint))
                return force<T>(uint.MinValue);
            else
                return force<T>(ulong.MinValue);
        }

        [MethodImpl(Inline)]
        static T minval_f<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return force<T>(float.MinValue);
            else if(typeof(T) == typeof(double))
                return force<T>(double.MinValue);
            else
                throw no<T>();
        }
    }
}