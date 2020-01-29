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
        /// Forms a vector z[i] = testbit(spec[i],7) ? x[i] : y[i] where i = 0,...15
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> vblend<T>(Vector128<T> x, Vector128<T> y, Vector128<byte> spec)        
            where T : unmanaged
                => vblend_u(x,y,spec);

        /// <summary>
        /// Forms a vector z[i] = testbit(spec[i],7) ? x[i] : y[i] where i = 0,...31
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> vblend<T>(Vector256<T> x, Vector256<T> y, Vector256<byte> spec)        
            where T : unmanaged
                => vblend_u(x,y,spec);

        /// <summary>
        /// Forms a vector z[i] = testbit(spec,i) ? x[i] : y[i] where i = 0,...15
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> vblend<T>(Vector128<T> x, Vector128<T> y, ushort spec)
            where T : unmanaged
                => vblend(x,y,dinx.vmakemask(spec));

        /// <summary>
        /// Forms a vector z[i] = testbit(spec,i) ? x[i] : y[i] where i = 0,...31
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> vblend<T>(Vector256<T> x, Vector256<T> y, uint spec)        
            where T : unmanaged
                => vblend(x,y,dinx.vmakemask(spec));

        [MethodImpl(Inline)]
        static Vector256<T> vblend_u<T>(Vector256<T> x, Vector256<T> y, Vector256<byte> spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vblend(v8u(x), v8u(y), spec));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vblend(v16u(x), v16u(y), spec));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vblend(v32u(x), v32u(y), spec));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vblend(v64u(x), v64u(y), spec));
            else
                return vblend_i(x,y,spec);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vblend_i<T>(Vector256<T> x, Vector256<T> y, Vector256<byte> spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vblend(v8i(x), v8i(y), spec));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vblend(v16i(x), v16i(y), spec));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vblend(v32i(x), v32i(y), spec));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vblend(v64i(x), v64i(y), spec));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector128<T> vblend_u<T>(Vector128<T> x, Vector128<T> y, Vector128<byte> spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vblend(v8u(x), v8u(y), spec));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vblend(v16u(x), v16u(y), spec));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vblend(v32u(x), v32u(y), spec));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vblend(v64u(x), v64u(y), spec));
            else
                return vblend_i(x,y,spec);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vblend_i<T>(Vector128<T> x, Vector128<T> y, Vector128<byte> spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vblend(v8i(x), v8i(y), spec));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vblend(v16i(x), v16i(y), spec));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vblend(v32i(x), v32i(y), spec));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vblend(v64i(x), v64i(y), spec));
            else
                throw unsupported<T>();
        }
    }
}