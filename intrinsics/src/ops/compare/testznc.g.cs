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

    partial class ginx
    {
        [MethodImpl(Inline), ZFunc(PrimalKind.All)]
        public static bit vtestznc<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vtestznc_u(src,mask);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vtestznc_i(src,mask);
            else 
                return vtestznc_f(src,mask);
        }

        [MethodImpl(Inline), ZFunc(PrimalKind.All)]
        public static bit vtestznc<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vtestznc_u(src,mask);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vtestznc_i(src,mask);
            else 
                return vtestznc_f(src,mask);
        }


        [MethodImpl(Inline)]
        static bit vtestznc_i<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.vtestznc(v8i(src), v8i(mask));
            else if(typeof(T) == typeof(short))
                return dinx.vtestznc(v16i(src), v16i(mask));
            else if(typeof(T) == typeof(int))
                return dinx.vtestznc(v32i(src), v32i(mask));
            else 
                return dinx.vtestznc(v64i(src), v64i(mask));
        }

        [MethodImpl(Inline)]
        static bit vtestznc_u<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dinx.vtestznc(v8u(src), v8u(mask));
            else if(typeof(T) == typeof(ushort))
                return dinx.vtestznc(v16u(src), v16u(mask));
            else if(typeof(T) == typeof(uint))
                return dinx.vtestznc(v32u(src), v32u(mask));
            else 
                return dinx.vtestznc(v64u(src), v64u(mask));
        }

        [MethodImpl(Inline)]
        static bit vtestznc_f<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinx.vtestznc(v32f(src), v32f(mask));
            else if(typeof(T) == typeof(double))
                return dinx.vtestznc(v64f(src), v64f(mask));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static bit vtestznc_i<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.vtestznc(v8i(src), v8i(mask));
            else if(typeof(T) == typeof(short))
                return dinx.vtestznc(v16i(src), v16i(mask));
            else if(typeof(T) == typeof(int))
                return dinx.vtestznc(v32i(src), v32i(mask));
            else 
                return dinx.vtestznc(v64i(src), v64i(mask));
        }

        [MethodImpl(Inline)]
        static bit vtestznc_u<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dinx.vtestznc(v8u(src), v8u(mask));
            else if(typeof(T) == typeof(ushort))
                return dinx.vtestznc(v16u(src), v16u(mask));
            else if(typeof(T) == typeof(uint))
                return dinx.vtestznc(v32u(src), v32u(mask));
            else 
                return dinx.vtestznc(v64u(src), v64u(mask));
        }

        [MethodImpl(Inline)]
        static bit vtestznc_f<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinx.vtestznc(v32f(src), v32f(mask));
            else if(typeof(T) == typeof(double))
                return dinx.vtestznc(v64f(src), v64f(mask));
            else 
                throw unsupported<T>();
        }
    }
}