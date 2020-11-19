//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    partial class gvec
    {
        /// <summary>
        /// Returns 1 if all mask-identified source bits are disabled, 0 otherwise
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline), TestZ, Closures(AllNumeric)]
        public static bit vtestz<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
                => vtestz_u(src,mask);

        /// <summary>
        /// Returns 1 if all mask-identified source bits are disabled, 0 otherwise
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline), TestZ, Closures(AllNumeric)]
        public static bit vtestz<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
                => vtestz_u(src,mask);

        /// <summary>
        /// Returns 1 if all mask-identified source bits are disabled, 0 otherwise
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline), TestZ, Closures(AllNumeric)]
        public static bit vtestz<T>(in Vector512<T> src, in Vector512<T> mask)
            where T : unmanaged
                => vtestz(src.Lo,mask.Lo) && vtestz(src.Hi,mask.Hi);

        [MethodImpl(Inline)]
        static bit vtestz_u<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return z.vtestz(v8u(src), v8u(mask));
            else if(typeof(T) == typeof(ushort))
                return z.vtestz(v16u(src), v16u(mask));
            else if(typeof(T) == typeof(uint))
                return z.vtestz(v32u(src), v32u(mask));
            else if(typeof(T) == typeof(ulong))
                return z.vtestz(v64u(src), v64u(mask));
            else
                return vtestz_i(src,mask);
        }

        [MethodImpl(Inline)]
        static bit vtestz_i<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return z.vtestz(v8i(src), v8i(mask));
            else if(typeof(T) == typeof(short))
                return z.vtestz(v16i(src), v16i(mask));
            else if(typeof(T) == typeof(int))
                return z.vtestz(v32i(src), v32i(mask));
            else if(typeof(T) == typeof(long))
                return z.vtestz(v64i(src), v64i(mask));
            else
                return vtestz_f<T>(src,mask);
        }

        [MethodImpl(Inline)]
        static bit vtestz_f<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return z.vtestz(v32f(src), v32f(mask));
            else if(typeof(T) == typeof(double))
                return z.vtestz(v64f(src), v64f(mask));
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static bit vtestz_u<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return z.vtestz(v8u(src), v8u(mask));
            else if(typeof(T) == typeof(ushort))
                return z.vtestz(v16u(src), v16u(mask));
            else if(typeof(T) == typeof(uint))
                return z.vtestz(v32u(src), v32u(mask));
            else if(typeof(T) == typeof(ulong))
                return z.vtestz(v64u(src), v64u(mask));
            else
                return vtestz_i(src,mask);
        }

        [MethodImpl(Inline)]
        static bit vtestz_i<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return z.vtestz(v8i(src), v8i(mask));
            else if(typeof(T) == typeof(short))
                return z.vtestz(v16i(src), v16i(mask));
            else if(typeof(T) == typeof(int))
                return z.vtestz(v32i(src), v32i(mask));
            else if(typeof(T) == typeof(long))
                return z.vtestz(v64i(src), v64i(mask));
            else
                return vtestz_f<T>(src,mask);
        }

        [MethodImpl(Inline)]
        static bit vtestz_f<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return z.vtestz(v32f(src), v32f(mask));
            else if(typeof(T) == typeof(double))
                return z.vtestz(v64f(src), v64f(mask));
            else
                throw no<T>();
        }
    }
}