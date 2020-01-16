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
        /// 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static Vector128<T> vblendv<T>(Vector128<T> x, Vector128<T> y, Vector128<T> spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vblendv(v8u(x), v8u(y), v8u(spec)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vblendv(v16u(x), v16u(y), v16u(spec)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vblendv(v32u(x), v32u(y), v32u(spec)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vblendv(v64u(x), v64u(y), v64u(spec)));
            else
                return vblendv_i(x,y,spec);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static Vector256<T> vblendv<T>(Vector256<T> x, Vector256<T> y, Vector256<T> spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vblendv(v8u(x), v8u(y), v8u(spec)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vblendv(v16u(x), v16u(y), v16u(spec)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vblendv(v32u(x), v32u(y), v32u(spec)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vblendv(v64u(x), v64u(y), v64u(spec)));
            else
                return vblendv_i(x,y,spec);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vblendv_i<T>(Vector128<T> x, Vector128<T> y, Vector128<T> spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vblendv(v8i(x), v8i(y), v8i(spec)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vblendv(v16i(x), v16i(y), v16i(spec)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vblendv(v32i(x), v32i(y), v32i(spec)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vblendv(v64i(x), v64i(y), v64i(spec)));
            else
                return vblendv_f(x,y,spec);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vblendv_f<T>(Vector128<T> x, Vector128<T> y, Vector128<T> spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinx.vblendv(v32f(x), v32f(y), v32f(spec)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinx.vblendv(v64f(x), v64f(y), v64f(spec)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vblendv_i<T>(Vector256<T> x, Vector256<T> y, Vector256<T> spec)        
            where T : unmanaged
        {
             if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vblendv(v8i(x), v8i(y), v8i(spec)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vblendv(v16i(x), v16i(y), v16i(spec)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vblendv(v32i(x), v32i(y), v32i(spec)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vblendv(v64i(x), v64i(y), v64i(spec)));
            else
                return vblendv_f(x,y,spec);

        }

        [MethodImpl(Inline)]
        static Vector256<T> vblendv_f<T>(Vector256<T> x, Vector256<T> y, Vector256<T> spec)        
            where T : unmanaged
        {
             if(typeof(T) == typeof(float))
                return vgeneric<T>(dinx.vblendv(v32f(x), v32f(y), v32f(spec)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinx.vblendv(v64f(x), v64f(y), v64f(spec)));
            else
                throw unsupported<T>();

        }
    }
}