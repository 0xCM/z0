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
    
    using static Core;    
    using static vgeneric;
    using static Nats;

    partial class gvec
    {        
        /// <summary>
        /// Returns 1 if all mask-identified source bits are all enabled and 0 otherwise
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static bit vtestc<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
                => vtestc_u(src,mask);

        /// <summary>
        /// Returns 1 if all mask-identified source bits are all enabled and 0 otherwise
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static bit vtestc<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
                => vtestc_u(src,mask);

        /// <summary>
        /// Returns 1 if all mask-identified source bits are all enabled and 0 otherwise
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static bit vtestc<T>(in Vector512<T> src, in Vector512<T> mask)
            where T : unmanaged
                => vtestc(src.Lo, mask.Lo) && vtestc(src.Hi, mask.Lo);

        /// <summary>
        /// Returns 1 if all source bits are enabled and 0 otherwise
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static bit vtestc<T>(Vector128<T> src)
            where T : unmanaged
                => vtestc(src, gvec.vones<T>(n128));

        /// <summary>
        /// Returns 1 if all source bits are enabled and 0 otherwise
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static bit vtestc<T>(Vector256<T> src)
            where T : unmanaged
                => vtestc(src, gvec.vones<T>(n256));        

        /// <summary>
        /// Returns 1 if all source bits are enabled and 0 otherwise
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static bit vtestc<T>(Vector512<T> src)
            where T : unmanaged
                => vtestc(src, gvec.vones<T>(n512));        

        [MethodImpl(Inline)]
        static bit vtestc_u<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dvec.vtestc(v8u(src), v8u(mask));
            else if(typeof(T) == typeof(ushort))
                return dvec.vtestc(v16u(src), v16u(mask));
            else if(typeof(T) == typeof(uint))
                return dvec.vtestc(v32u(src), v32u(mask));
            else if(typeof(T) == typeof(ulong))
                return dvec.vtestc(v64u(src), v64u(mask));
            else
                return vtestc_i(src,mask);
        }

        [MethodImpl(Inline)]
        static bit vtestc_i<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dvec.vtestc(v8i(src), v8i(mask));
            else if(typeof(T) == typeof(short))
                return dvec.vtestc(v16i(src), v16i(mask));
            else if(typeof(T) == typeof(int))
                return dvec.vtestc(v32i(src), v32i(mask));
            else if(typeof(T) == typeof(long))
                return dvec.vtestc(v64i(src), v64i(mask));
            else
                return vtestc_f(src,mask);
        }

        [MethodImpl(Inline)]
        static bit vtestc_f<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinxfp.vtestc(v32f(src), v32f(mask));
            else if(typeof(T) == typeof(double))
                return dinxfp.vtestc(v64f(src), v64f(mask));
            else 
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        static bit vtestc_u<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dvec.vtestc(v8u(src), v8u(mask));
            else if(typeof(T) == typeof(ushort))
                return dvec.vtestc(v16u(src), v16u(mask));
            else if(typeof(T) == typeof(uint))
                return dvec.vtestc(v32u(src), v32u(mask));
            else if(typeof(T) == typeof(ulong))
                return dvec.vtestc(v64u(src), v64u(mask));
            else
                return vtestc_i(src,mask);
        }

        [MethodImpl(Inline)]
        static bit vtestc_i<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dvec.vtestc(v8i(src), v8i(mask));
            else if(typeof(T) == typeof(short))
                return dvec.vtestc(v16i(src), v16i(mask));
            else if(typeof(T) == typeof(int))
                return dvec.vtestc(v32i(src), v32i(mask));
            else if(typeof(T) == typeof(long))
                return dvec.vtestc(v64i(src), v64i(mask));
            else
                return vtestc_f(src,mask);
        }

        [MethodImpl(Inline)]
        static bit vtestc_f<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinxfp.vtestc(v32f(src), v32f(mask));
            else if(typeof(T) == typeof(double))
                return dinxfp.vtestc(v64f(src), v64f(mask));
            else 
                throw Unsupported.define<T>();
        }
    }
}