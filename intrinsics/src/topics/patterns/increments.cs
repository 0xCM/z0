//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static As;
    using static HexConst;
    using static ginx;
    using static Data;
 
    partial class VPattern
    {
        /// <summary>
        /// Creates a 128-bit vector with component values 0, 1, ... k - 1 where k is the length of the target vector
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), NatOp, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> vincrements<T>(N128 w)
            where T : unmanaged
       {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return load<T>(w,Inc128x8u);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return load<T>(w,Inc128x16u);
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int) || typeof(T) == typeof(float))
                return load<T>(w,Inc128x32u);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return load<T>(w,Inc128x64u);
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Creates a 256-bit vector with component values 0, 1, ... k - 1 where k is the length of the target vector
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), NatOp, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> vincrements<T>(N256 w)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return load<T>(w,Inc256x8u);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return load<T>(w,Inc256x16u);
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int)  || typeof(T) == typeof(float))
                return load<T>(w,Inc256x32u);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return load<T>(w,Inc256x64u);
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Creates a 512-bit vector with component values 0, 1, ... k - 1 where k is the length of the target vector
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector512<T> vincrements<T>(N512 w)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return load<T>(w,Inc512x8u);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return load<T>(w,Inc512x16u);
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int) || typeof(T) == typeof(float))
                return load<T>(w,Inc512x32u);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return load<T>(w,Inc512x64u);
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Creates a 128-bit vector with components that increase by unit step from an initial value
        /// </summary>
        /// <param name="x0">The value of the first component</param>
        /// <param name="step">The distance between adjacent components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vincrements<T>(N128 n, T x0)
            where T : unmanaged
                => vadd(vincrements<T>(n), x0);

        /// <summary>
        /// Creates a 256-bit vector with components that increase by unit step from an initial value
        /// </summary>
        /// <param name="x0">The value of the first component</param>
        /// <param name="step">The distance between adjacent components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vincrements<T>(N256 n, T x0)
            where T : unmanaged
                => vadd(vincrements<T>(n), x0);

        /// <summary>
        /// Creates a 256-bit vector with components that increase by unit step from an initial value
        /// </summary>
        /// <param name="x0">The value of the first component</param>
        /// <param name="step">The distance between adjacent components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector512<T> vincrements<T>(N512 n, T x0)
            where T : unmanaged
                => vadd(vincrements<T>(n), x0); 
    }

}