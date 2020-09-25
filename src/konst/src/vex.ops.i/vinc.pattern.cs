//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static VectorKonst;

    partial struct z
    {
        /// <summary>
        /// Creates a 128-bit vector with component values 0, 1, ... k - 1 where k is the length of the target vector
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public  static Vector128<T> vinc<T>(W128 w)
            where T : unmanaged
       {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return generic<T>(vload(w, first(Inc128x8u)));
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return generic<T>(vload(w, first(Inc128x16u)));
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int) || typeof(T) == typeof(float))
                return generic<T>(vload(w, first(Inc128x32u)));
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return generic<T>(vload(w, first(Inc128x64u)));
            else
                throw no<T>();
        }

        /// <summary>
        /// Creates a 256-bit vector with component values 0, 1, ... k - 1 where k is the length of the target vector
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public  static Vector256<T> vinc<T>(W256 w)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return generic<T>(vload(w, first(Inc256x8u)));
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return generic<T>(vload(w, first(Inc256x16u)));
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int)  || typeof(T) == typeof(float))
                return generic<T>(vload(w, first(Inc256x32u)));
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return generic<T>(vload(w, first(Inc256x64u)));
            else
                throw no<T>();
        }

        /// <summary>
        /// Creates a 512-bit vector with component values 0, 1, ... k - 1 where k is the length of the target vector
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector512<T> vinc<T>(W512 w)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return vload<T>(w, Inc512x8u);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return vload<T>(w, Inc512x16u);
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int) || typeof(T) == typeof(float))
                return vload<T>(w, Inc512x32u);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return vload<T>(w,Inc512x64u);
            else
                throw no<T>();
        }
    }
}