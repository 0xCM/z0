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
        public static Vector128<T> vblend<T>(Vector128<T> x, Vector128<T> y, Blend8x16 spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vblend16_u(x, y, spec);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vblend_i(x, y, spec);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vblend<T>(Vector256<T> x, Vector256<T> y, Blend8x16 spec)        
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
        static Vector128<T> vblend16_u<T>(Vector128<T> x, Vector128<T> y, Blend8x16 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(v8u(dinx.vblend(v16u(x), v16u(y), spec)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vblend(vcast16u(x), vcast16u(y), spec));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(v32u(dinx.vblend(v16u(x), v16u(y), spec)));
            else
                return vgeneric<T>(v64u(dinx.vblend(v16u(x), v16u(y), spec)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vblend_i<T>(Vector128<T> x, Vector128<T> y, Blend8x16 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return As.vgeneric<T>(v8i(dinx.vblend(v16u(x), v16u(y), spec)));
            else if(typeof(T) == typeof(short))
                return As.vgeneric<T>(dinx.vblend(vcast16i(x), vcast16i(y), spec));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(v32i(dinx.vblend(v16u(x), v16u(y), spec)));
            else
                return vgeneric<T>(v64i(dinx.vblend(v16u(x), v16u(y), spec)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vblend_u<T>(Vector256<T> x, Vector256<T> y, Blend8x16 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(v8u(dinx.vblend(v16u(x), v16u(y), spec)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vblend(vcast16u(x), vcast16u(y), spec));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(v32u(dinx.vblend(v16u(x), v16u(y), spec)));
            else
                return vgeneric<T>(v64u(dinx.vblend(v16u(x), v16u(y), spec)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vblend_i<T>(Vector256<T> x, Vector256<T> y, Blend8x16 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(v8i(dinx.vblend(v16u(x), v16u(y), spec)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vblend(vcast16i(x), vcast16i(y), spec));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(v32i(dinx.vblend(v16u(x), v16u(y), spec)));
            else
                return vgeneric<T>(v64i(dinx.vblend(v16u(x), v16u(y), spec)));
        }


    }

}