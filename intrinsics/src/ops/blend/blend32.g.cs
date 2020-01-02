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

        [MethodImpl(Inline)]
        public static Vector128<T> vblend<T>(Vector128<T> x, Vector128<T> y, Blend4x32 spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vblend_u(x, y, spec);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vblend_i(x, y, spec);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Forms a vector z[i] := testbit(spec,i) ? x[i] : y[i], i = 0,...7
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vblend<T>(Vector256<T> x, Vector256<T> y, Blend8x32 spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vblend_u(x, y, spec);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vblend_i(x, y, spec);
            else 
                throw unsupported<T>();
        }

 
        [MethodImpl(Inline)]
        static Vector256<T> vblend_u<T>(Vector256<T> x, Vector256<T> y, Blend8x32 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(v8u(dinx.vblend(v32u(x), v32u(y), spec)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(v16u(dinx.vblend(v32u(x), v32u(y), spec)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vblend(vcast32u(x), vcast32u(y), spec));
            else
                return vgeneric<T>(v64u(dinx.vblend(v32u(x), v32u(y), spec)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vblend_i<T>(Vector256<T> x, Vector256<T> y, Blend8x32 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(v8i(dinx.vblend(v32u(x), v32u(y), spec)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(v16i(dinx.vblend(v32u(x), v32u(y), spec)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vblend(vcast32i(x), vcast32i(y), spec));
            else
                return vgeneric<T>(v64i(dinx.vblend(v32u(x), v32u(y), spec)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vblend_i<T>(Vector128<T> x, Vector128<T> y, Blend4x32 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return As.vgeneric<T>(v8i(dinx.vblend(v32u(x), v32u(y), spec)));
            else if(typeof(T) == typeof(short))
                return As.vgeneric<T>(v16i(dinx.vblend(v32u(x), v32u(y), spec)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vblend(vcast32i(x), vcast32i(y), spec));
            else
                return vgeneric<T>(v64u(dinx.vblend(v32u(x), v32u(y), spec)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vblend_u<T>(Vector128<T> x, Vector128<T> y, Blend4x32 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(v8u(dinx.vblend(v32u(x), v32u(y), spec)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(v16u(dinx.vblend(v32u(x), v32u(y), spec)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vblend(vcast32u(x), vcast32u(y), spec));
            else
                return vgeneric<T>(v64u(dinx.vblend(v32u(x), v32u(y), spec)));
        }


    }

}