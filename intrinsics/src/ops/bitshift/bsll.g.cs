//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    
    using static As;
    
    partial class ginx
    {
        /// <summary>
        /// Applies a leftward shift over the full 128 vector bits at byte-level resolution
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The number of bytes to shift</param>
        /// <typeparam name="T">THe primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> vbsll<T>(Vector128<T> x, [Shift] byte count)
            where T : unmanaged
                => vbsll_u(x,count);

        /// <summary>
        /// Applies a leftward shift to each 128-bit lane at byte-level resolution
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The number of bytes to shift</param>
        /// <typeparam name="T">THe primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> vbsll<T>(Vector256<T> x, [Shift] byte count)
            where T : unmanaged
                => vbsll_u(x,count);

        [MethodImpl(Inline)]
        static Vector128<T> vbsll_u<T>(Vector128<T> x, [Shift] byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vbsll(v8u(x), count));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vbsll(v16u(x), count));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vbsll(v32u(x), count));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vbsll(v64u(x), count));
            else
                return vbsll_i(x,count);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vbsll_i<T>(Vector128<T> x, [Shift] byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vbsll(v8i(x), count));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vbsll(v16i(x), count));
            else if(typeof(T) == typeof(int)) 
                return vgeneric<T>(dinx.vbsll(v32i(x), count));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vbsll(v64i(x), count));
            else
                throw unsupported<T>();
        }
        
        [MethodImpl(Inline)]
        static Vector256<T> vbsll_u<T>(Vector256<T> x, [Shift] byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vbsll(v8u(x), count));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vbsll(v16u(x), count));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vbsll(v32u(x), count));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vbsll(v64u(x), count));
            else
                return vbsll_i(x,count);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vbsll_i<T>(Vector256<T> x, [Shift] byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vbsll(v8i(x), count));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vbsll(v16i(x), count));
            else if(typeof(T) == typeof(int)) 
                return vgeneric<T>(dinx.vbsll(v32i(x), count));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vbsll(v64i(x), count));
            else
                throw unsupported<T>();
       }

    }
}