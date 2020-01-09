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
        /// <summary>
        /// Returns 1 if all mask-identified source bits are disabled, 0 otherwise
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline), ZFunc(PrimalKind.All)]
        public static bit vtestz<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vtestz_u(src,mask);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vtestz_i(src,mask);
            else 
                return vtestz_f<T>(src,mask);
         }

        /// <summary>
        /// Returns 1 if all mask-identified source bits are disabled, 0 otherwise
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline), ZFunc(PrimalKind.All)]
        public static bit vtestz<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
             if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vtestz_u(src,mask);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vtestz_i(src,mask);
            else 
                return vtestz_f<T>(src,mask);
       }

        /// <summary>
        /// Returns 1 if all mask-identified source bits are disabled, 0 otherwise
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline), ZFunc(PrimalKind.All)]
        public static bit vtestz<T>(in Vector512<T> src, in Vector512<T> mask)
            where T : unmanaged
                => vtestz(src.Lo,mask.Lo) && vtestz(src.Hi,mask.Hi);
        
        [MethodImpl(Inline)]
        static bit vtestz_u<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dinx.vtestz(v8u(src), v8u(mask));
            else if(typeof(T) == typeof(ushort))
                return dinx.vtestz(v16u(src), v16u(mask));
            else if(typeof(T) == typeof(uint))
                return dinx.vtestz(v32u(src), v32u(mask));
            else
                return dinx.vtestz(v64u(src), v64u(mask));
        }

        [MethodImpl(Inline)]
        static bit vtestz_i<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.vtestz(v8i(src), v8i(mask));
            else if(typeof(T) == typeof(short))
                return dinx.vtestz(v16i(src), v16i(mask));
            else if(typeof(T) == typeof(int))
                return dinx.vtestz(v32i(src), v32i(mask));
            else
                return dinx.vtestz(v64i(src), v64i(mask));
        }

        [MethodImpl(Inline)]
        static bit vtestz_f<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinxfp.vtestz(v32f(src), v32f(mask));
            else if(typeof(T) == typeof(double))
                return dinxfp.vtestz(v64f(src), v64f(mask));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static bit vtestz_u<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dinx.vtestz(v8u(src), v8u(mask));
            else if(typeof(T) == typeof(ushort))
                return dinx.vtestz(v16u(src), v16u(mask));
            else if(typeof(T) == typeof(uint))
                return dinx.vtestz(v32u(src), v32u(mask));
            else
                return dinx.vtestz(v64u(src), v64u(mask));
        }

        [MethodImpl(Inline)]
        static bit vtestz_i<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.vtestz(v8i(src), v8i(mask));
            else if(typeof(T) == typeof(short))
                return dinx.vtestz(v16i(src), v16i(mask));
            else if(typeof(T) == typeof(int))
                return dinx.vtestz(v32i(src), v32i(mask));
            else
                return dinx.vtestz(v64i(src), v64i(mask));
        }

        [MethodImpl(Inline)]
        static bit vtestz_f<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinxfp.vtestz(v32f(src), v32f(mask));
            else if(typeof(T) == typeof(double))
                return dinxfp.vtestz(v64f(src), v64f(mask));
            else 
                throw unsupported<T>();
        }

    }
}