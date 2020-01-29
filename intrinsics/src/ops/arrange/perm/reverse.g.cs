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
    
    using static As;
    using static zfunc;

    partial class ginx
    {
        /// <summary>
        /// Reverses the source vector components
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> vreverse<T>(Vector128<T> x)
            where T : unmanaged
                => vreverse_u(x);

        /// <summary>
        /// Reverses the source vector components
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> vreverse<T>(Vector256<T> x)
            where T : unmanaged
                => vreverse_u(x);

        [MethodImpl(Inline)]
        static Vector256<T> vreverse_u<T>(Vector256<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vreverse(v8u(x)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vreverse(v16u(x)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vreverse(v32u(x)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vreverse(v64u(x)));
            else
                return vreverse_i(x);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vreverse_i<T>(Vector256<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vreverse(v8i(x)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vreverse(v16i(x)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vreverse(v32i(x)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vreverse(v64i(x)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector128<T> vreverse_u<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vreverse(v8u(x)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vreverse(v16u(x)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vreverse(v32u(x)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vreverse(v64u(x)));
            else
                return vreverse_i(x);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vreverse_i<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vreverse(v8i(x)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vreverse(v16i(x)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vreverse(v32i(x)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vreverse(v64i(x)));
            else
                throw unsupported<T>();
        }
    }
}