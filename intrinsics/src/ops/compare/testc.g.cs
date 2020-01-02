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
        /// Returns 1 if all mask-identified source bits are all enabled and 0 otherwise
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static bit vtestc<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vtestc_u(src,mask);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vtestc_i(src,mask);
            else 
                return vtestc_f(src,mask);
        }
        
        /// <summary>
        /// Returns 1 if all mask-identified source bits are all enabled and 0 otherwise
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static bit vtestc<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vtestc_u(src,mask);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vtestc_i(src,mask);
            else 
                return vtestc_f(src,mask);
        }

        /// <summary>
        /// Returns 1 if all mask-identified source bits are all enabled and 0 otherwise
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static bit vtestc<T>(in Vector512<T> src, in Vector512<T> mask)
            where T : unmanaged
                => vtestc(src.Lo, mask.Lo) && vtestc(src.Hi, mask.Lo);

        /// <summary>
        /// Returns 1 if all source bits are enabled and 0 otherwise
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static bit vtestc<T>(Vector128<T> src)
            where T : unmanaged
                => vtestc(src, VPattern.vones<T>(n128));

        /// <summary>
        /// Returns 1 if all source bits are enabled and 0 otherwise
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static bit vtestc<T>(Vector256<T> src)
            where T : unmanaged
                => vtestc(src, VPattern.vones<T>(n256));        

        /// <summary>
        /// Returns 1 if all source bits are enabled and 0 otherwise
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static bit vtestc<T>(Vector512<T> src)
            where T : unmanaged
                => vtestc(src, VPattern.vones<T>(n512));        

        [MethodImpl(Inline)]
        static bit vtestc_i<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.vtestc(vcast8i(src), vcast8i(mask));
            else if(typeof(T) == typeof(short))
                return dinx.vtestc(vcast16i(src), vcast16i(mask));
            else if(typeof(T) == typeof(int))
                return dinx.vtestc(vcast32i(src), vcast32i(mask));
            else 
                return dinx.vtestc(vcast64i(src), vcast64i(mask));
        }

        [MethodImpl(Inline)]
        static bit vtestc_u<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dinx.vtestc(vcast8u(src), vcast8u(mask));
            else if(typeof(T) == typeof(ushort))
                return dinx.vtestc(vcast16u(src), vcast16u(mask));
            else if(typeof(T) == typeof(uint))
                return dinx.vtestc(vcast32u(src), vcast32u(mask));
            else 
                return dinx.vtestc(vcast64u(src), vcast64u(mask));
        }

        [MethodImpl(Inline)]
        static bit vtestc_f<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinxfp.vtestc(vcast32f(src), vcast32f(mask));
            else if(typeof(T) == typeof(double))
                return dinxfp.vtestc(vcast64f(src), vcast64f(mask));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static bit vtestc_i<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.vtestc(vcast8i(src), vcast8i(mask));
            else if(typeof(T) == typeof(short))
                return dinx.vtestc(vcast16i(src), vcast16i(mask));
            else if(typeof(T) == typeof(int))
                return dinx.vtestc(vcast32i(src), vcast32i(mask));
            else 
                return dinx.vtestc(vcast64i(src), vcast64i(mask));
        }

        [MethodImpl(Inline)]
        static bit vtestc_u<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dinx.vtestc(vcast8u(src), vcast8u(mask));
            else if(typeof(T) == typeof(ushort))
                return dinx.vtestc(vcast16u(src), vcast16u(mask));
            else if(typeof(T) == typeof(uint))
                return dinx.vtestc(vcast32u(src), vcast32u(mask));
            else 
                return dinx.vtestc(vcast64u(src), vcast64u(mask));
        }

        [MethodImpl(Inline)]
        static bit vtestc_f<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinxfp.vtestc(vcast32f(src), vcast32f(mask));
            else if(typeof(T) == typeof(double))
                return dinxfp.vtestc(vcast64f(src), vcast64f(mask));
            else 
                throw unsupported<T>();
        }
    }
}