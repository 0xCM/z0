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
    using static As;
    using static Root;

    partial struct V0p
    {
        /// <summary>
        /// Creates a 128-bit vector with component values k - 1, ..., 1, 0  where k is the length of the target vector
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> vdecrements<T>(N128 w)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return V0.vload<T>(w, Dec128x8u);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return V0.vload<T>(w, Dec128x16u);
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                return V0.vload<T>(w, Dec128x32u);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return V0.vload<T>(w, Dec128x64u);
            else
                throw Unsupported.define<T>();
        }

        /// <summary>
        /// Creates a 256-bit vector with component values k - 1, ..., 1, 0  where k is the length of the target vector
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public  static Vector256<T> vdecrements<T>(N256 w)
            where T : unmanaged
        {            
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return V0.vload<T>(w,Dec256x8u);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return V0.vload<T>(w,Dec256x16u);
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                return V0.vload<T>(w,Dec256x32u);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return V0.vload<T>(w,Dec256x64u);
            else
                throw Unsupported.define<T>();
        }        
    }
}