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
        /// Computes ~(x | y) for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), ZFunc(PrimalKind.All)]
        public static Vector128<T> vnor<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => vnor_u(x,y);

        /// <summary>
        /// Computes ~(x | y) for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), ZFunc(PrimalKind.All)]
        public static Vector256<T> vnor<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => vnor_u(x,y);

        [MethodImpl(Inline)]
        static Vector128<T> vnor_u<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vnor(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vnor(v16u(x), v16u(y)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vnor(v32u(x), v32u(y)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vnor(v64u(x), v64u(y)));
            else
                return vnor_i(x,y);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vnor_i<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vnor(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vnor(v16i(x), v16i(y)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vnor(v32i(x), v32i(y)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vnor(v64i(x), v64i(y)));
            else
                return vnor_f(x,y);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vnor_f<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinx.vnor(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinx.vnor(v64f(x), v64f(y)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vnor_u<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vnor(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vnor(v16u(x), v16u(y)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vnor(v32u(x), v32u(y)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vnor(v64u(x), v64u(y)));
            else
                return vnor_i(x,y);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vnor_i<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vnor(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vnor(v16i(x), v16i(y)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vnor(v32i(x), v32i(y)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vnor(v64i(x), v64i(y)));
            else
                return vnor_f(x,y);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vnor_f<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinx.vnor(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinx.vnor(v64f(x), v64f(y)));
            else
                throw unsupported<T>();
        }
    }
}