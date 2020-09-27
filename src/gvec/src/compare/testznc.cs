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
    using static V0;

    partial class gvec
    {
        [MethodImpl(Inline), TestZnC, Closures(AllNumeric)]
        public static Bit32 vtestznc<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
                => vtestznc_u(src,mask);

        [MethodImpl(Inline), TestZnC, Closures(AllNumeric)]
        public static Bit32 vtestznc<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
                => vtestznc_u(src,mask);

        [MethodImpl(Inline)]
        static Bit32 vtestznc_u<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return z.vtestznc(v8u(src), v8u(mask));
            else if(typeof(T) == typeof(ushort))
                return z.vtestznc(v16u(src), v16u(mask));
            else if(typeof(T) == typeof(uint))
                return z.vtestznc(v32u(src), v32u(mask));
            else if(typeof(T) == typeof(ulong))
                return z.vtestznc(v64u(src), v64u(mask));
            else
                return vtestznc_i(src,mask);
        }

        [MethodImpl(Inline)]
        static Bit32 vtestznc_i<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return z.vtestznc(v8i(src), v8i(mask));
            else if(typeof(T) == typeof(short))
                return z.vtestznc(v16i(src), v16i(mask));
            else if(typeof(T) == typeof(int))
                return z.vtestznc(v32i(src), v32i(mask));
            else if(typeof(T) == typeof(long))
                return z.vtestznc(v64i(src), v64i(mask));
            else
                return vtestznc_f(src,mask);
        }

        [MethodImpl(Inline)]
        static Bit32 vtestznc_f<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return z.vtestznc(v32f(src), v32f(mask));
            else if(typeof(T) == typeof(double))
                return z.vtestznc(v64f(src), v64f(mask));
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static Bit32 vtestznc_u<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return z.vtestznc(v8u(src), v8u(mask));
            else if(typeof(T) == typeof(ushort))
                return z.vtestznc(v16u(src), v16u(mask));
            else if(typeof(T) == typeof(uint))
                return z.vtestznc(v32u(src), v32u(mask));
            else if(typeof(T) == typeof(ulong))
                return z.vtestznc(v64u(src), v64u(mask));
            else
                return vtestznc_i(src,mask);
        }

        [MethodImpl(Inline)]
        static Bit32 vtestznc_i<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return z.vtestznc(v8i(src), v8i(mask));
            else if(typeof(T) == typeof(short))
                return z.vtestznc(v16i(src), v16i(mask));
            else if(typeof(T) == typeof(int))
                return z.vtestznc(v32i(src), v32i(mask));
            else if(typeof(T) == typeof(long))
                return z.vtestznc(v64i(src), v64i(mask));
            else
                return vtestznc_f(src,mask);
        }

        [MethodImpl(Inline)]
        static Bit32 vtestznc_f<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return z.vtestznc(v32f(src), v32f(mask));
            else if(typeof(T) == typeof(double))
                return z.vtestznc(v64f(src), v64f(mask));
            else
                throw no<T>();
        }
    }
}