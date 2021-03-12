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
                return force<T>(sbyte.MaxValue);
            else if(typeof(T) == typeof(short))
                return force<T>(short.MaxValue);
            else if(typeof(T) == typeof(int))
                return force<T>(int.MaxValue);
            else
                return force<T>(long.MaxValue);
        }

        [MethodImpl(Inline)]
        static T maxval_u<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return force<T>(byte.MaxValue);
            else if(typeof(T) == typeof(ushort))
                return force<T>(ushort.MaxValue);
            else if(typeof(T) == typeof(uint))
                return force<T>(uint.MaxValue);
            else
                return force<T>(ulong.MaxValue);
        }

        [MethodImpl(Inline)]
        static T maxval_f<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return force<T>(float.MaxValue);
            else if(typeof(T) == typeof(double))
                return force<T>(double.MaxValue);
            else
                throw no<T>();
        }
    }
}