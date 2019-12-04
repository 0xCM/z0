//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        /// Determines whether all mask-identified source bits are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
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
        /// Determines whether all mask-identified source bits are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
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

        [MethodImpl(Inline)]
        static bit vtestz_u<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dinx.vtestz(vcast8u(src), vcast8u(mask));
            else if(typeof(T) == typeof(ushort))
                return dinx.vtestz(vcast16u(src), vcast16u(mask));
            else if(typeof(T) == typeof(uint))
                return dinx.vtestz(vcast32u(src), vcast32u(mask));
            else
                return dinx.vtestz(vcast64u(src), vcast64u(mask));
        }

        [MethodImpl(Inline)]
        static bit vtestz_i<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.vtestz(vcast8i(src), vcast8i(mask));
            else if(typeof(T) == typeof(short))
                return dinx.vtestz(vcast16i(src), vcast16i(mask));
            else if(typeof(T) == typeof(int))
                return dinx.vtestz(vcast32i(src), vcast32i(mask));
            else
                return dinx.vtestz(vcast64i(src), vcast64i(mask));
        }

        [MethodImpl(Inline)]
        static bit vtestz_f<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fpinx.vtestz(vcast32f(src), vcast32f(mask));
            else if(typeof(T) == typeof(double))
                return fpinx.vtestz(vcast64f(src), vcast64f(mask));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static bit vtestz_u<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dinx.vtestz(vcast8u(src), vcast8u(mask));
            else if(typeof(T) == typeof(ushort))
                return dinx.vtestz(vcast16u(src), vcast16u(mask));
            else if(typeof(T) == typeof(uint))
                return dinx.vtestz(vcast32u(src), vcast32u(mask));
            else
                return dinx.vtestz(vcast64u(src), vcast64u(mask));
        }

        [MethodImpl(Inline)]
        static bit vtestz_i<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.vtestz(vcast8i(src), vcast8i(mask));
            else if(typeof(T) == typeof(short))
                return dinx.vtestz(vcast16i(src), vcast16i(mask));
            else if(typeof(T) == typeof(int))
                return dinx.vtestz(vcast32i(src), vcast32i(mask));
            else
                return dinx.vtestz(vcast64i(src), vcast64i(mask));
        }

        [MethodImpl(Inline)]
        static bit vtestz_f<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fpinx.vtestz(vcast32f(src), vcast32f(mask));
            else if(typeof(T) == typeof(double))
                return fpinx.vtestz(vcast64f(src), vcast64f(mask));
            else 
                throw unsupported<T>();
        }

    }
}