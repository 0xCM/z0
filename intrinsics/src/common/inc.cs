//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static ginx;
    using static HexConst;
    using static As;

    partial class CpuVector
    {
        /// <summary>
        /// Creates a 128-bit vector with component values 0, 1, ... k - 1 where k is the length of the target vector
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> increments<T>(N128 w)
            where T : unmanaged
       {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return load<T>(w,Inc128x8);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return load<T>(w,Inc128x16);
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int) || typeof(T) == typeof(float))
                return load<T>(w,Inc128x32);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return load<T>(w,Inc128x64);
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Creates a 256-bit vector with component values 0, 1, ... k - 1 where k is the length of the target vector
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> increments<T>(N256 w)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return load<T>(w,Inc256x8);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return load<T>(w,Inc256x16);
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int)  || typeof(T) == typeof(float))
                return load<T>(w,Inc256x32);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return load<T>(w,Inc256x64);
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Creates a 512-bit vector with component values 0, 1, ... k - 1 where k is the length of the target vector
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector512<T> increments<T>(N512 w)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return load<T>(w,Inc512x8);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return load<T>(w,Inc512x16);
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int) || typeof(T) == typeof(float))
                return load<T>(w,Inc512x32);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return load<T>(w,Inc512x64);
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
        public static Vector128<T> increments<T>(N128 n, T x0)
            where T : unmanaged
                => vadd(increments<T>(n), x0);

        /// <summary>
        /// Creates a 256-bit vector with components that increase by unit step from an initial value
        /// </summary>
        /// <param name="x0">The value of the first component</param>
        /// <param name="step">The distance between adjacent components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> increments<T>(N256 n, T x0)
            where T : unmanaged
                => vadd(increments<T>(n), x0);

        /// <summary>
        /// Creates a 256-bit vector with components that increase by unit step from an initial value
        /// </summary>
        /// <param name="x0">The value of the first component</param>
        /// <param name="step">The distance between adjacent components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector512<T> increments<T>(N512 n, T x0)
            where T : unmanaged
                => vadd(increments<T>(n), x0);

        static ReadOnlySpan<byte> Inc128x8  
            => new byte[16]{0,1,2,3,4,5,6,7,8,9,10,B,12,13,14,F};

        static ReadOnlySpan<byte> Inc128x16  
            => new byte[16]{0,0,1,0,2,0,3,0,4,0,5,0,6,0,7,0};

        static ReadOnlySpan<byte> Inc128x32  
            => new byte[16]{0,0,0,0,1,0,0,0,2,0,0,0,3,0,0,0};

        static ReadOnlySpan<byte> Inc128x64  
            => new byte[16]{0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0};

        public static ReadOnlySpan<byte> Inc256x8  
            => new byte[32]{
                0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,
                16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31
                };
        static ReadOnlySpan<byte> Inc256x16  
            => new byte[32]{
                0,0,1,0,2,0,3,0,4,0,5,0,6,0,7,0,
                8,0,9,0,10,0,11,0,12,0,13,0,14,0,15,0
                };

        static ReadOnlySpan<byte> Inc256x32  
            => new byte[32]{
                0,0,0,0,1,0,0,0,2,0,0,0,3,0,0,0,
                4,0,0,0,5,0,0,0,6,0,0,0,7,0,0,0
                };

        static ReadOnlySpan<byte> Inc256x64  
            => new byte[32]{
                0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,
                2,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0
                };

        static ReadOnlySpan<byte> Inc512x8  
            => new byte[64]{
                0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,
                16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,
                32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,
                48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63
                };

        static ReadOnlySpan<byte> Inc512x16  
            => new byte[64]{
                0,0,1,0,2,0,3,0,4,0,5,0,6,0,7,0,
                8,0,9,0,10,0,11,0,12,0,13,0,14,0,15,0,
                16,0,17,0,18,0,19,0,20,0,21,0,22,0,23,0,
                24,0,25,0,26,0,27,0,28,0,29,0,30,0,31,0
                };

        static ReadOnlySpan<byte> Inc512x32  
            => new byte[64]{
                0,0,0,0,1,0,0,0,2,0,0,0,3,0,0,0,
                4,0,0,0,5,0,0,0,6,0,0,0,7,0,0,0,
                8,0,0,0,9,0,0,0,A,0,0,0,B,0,0,0,
                C,0,0,0,D,0,0,0,E,0,0,0,F,0,0,0
                };

        static ReadOnlySpan<byte> Inc512x64  
            => new byte[64]{
                0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,
                2,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0,
                4,0,0,0,0,0,0,0,5,0,0,0,0,0,0,0,
                6,0,0,0,0,0,0,0,7,0,0,0,0,0,0,0,
                };

    }
}