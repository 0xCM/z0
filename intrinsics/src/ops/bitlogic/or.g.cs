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
        [MethodImpl(Inline), ZFunc(PrimalKind.All)]
        public static Vector128<T> vor<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vor_u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vor_i(x,y);
            else 
                return vor_f(x,y);
        }

        [MethodImpl(Inline), ZFunc(PrimalKind.All)]
        public static Vector256<T> vor<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vor_u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vor_i(x,y);
            else 
                return vor_f(x,y);
        }

        /// <summary>
        /// Computes the bitwise or
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline), ZFunc(PrimalKind.All)]
        public static Vector512<T> vor<T>(in Vector512<T> x, in Vector512<T> y)
            where T : unmanaged
                => (vor(x.Lo,y.Lo), (vor(x.Hi, y.Hi)));

        [MethodImpl(Inline)]
        static Vector128<T> vor_u<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vor(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vor(v16u(x), v16u(y)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vor(v32u(x), v32u(y)));
            else
                return vgeneric<T>(dinx.vor(v64u(x), v64u(y)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vor_i<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vor(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vor(v16i(x), v16i(y)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vor(v32i(x), v32i(y)));
            else
                return vgeneric<T>(dinx.vor(v64i(x), v64i(y)));
        }
 
        [MethodImpl(Inline)]
        static Vector128<T> vor_f<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vor(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vor(v64f(x), v64f(y)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vor_u<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vor(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vor(v16u(x), v16u(y)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vor(v32u(x), v32u(y)));
            else
                return vgeneric<T>(dinx.vor(v64u(x), v64u(y)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vor_i<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vor(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vor(v16i(x), v16i(y)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vor(v32i(x), v32i(y)));
            else
                return vgeneric<T>(dinx.vor(v64i(x), v64i(y)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vor_f<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vor(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vor(v64f(x), v64f(y)));
            else
                throw unsupported<T>();
        }
    }
}