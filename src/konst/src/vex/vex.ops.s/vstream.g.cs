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

    partial struct z
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstream<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
                => vstream_u(src, ref dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstream<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
                => vstream_u(src, ref dst);

        [MethodImpl(Inline)]
        static unsafe void vstream_u<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                z.vstream(v8u(src), ref z.uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                z.vstream(v16u(src), ref z.uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                z.vstream(v32u(src), ref z.uint32(ref dst));
            else if(typeof(T) == typeof(ulong))
                z.vstream(v64u(src), ref z.uint64(ref dst));
            else
                 vstream_i(src,ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vstream_i<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                z.vstream(v8i(src), ref z.int8(ref dst));
            else if(typeof(T) == typeof(short))
                z.vstream(v16i(src), ref z.int16(ref dst));
            else if(typeof(T) == typeof(int))
                z.vstream(v32i(src), ref z.int32(ref dst));
            else if(typeof(T) == typeof(long))
                z.vstream(v64i(src), ref z.int64(ref dst));
            else
                vstream_f(src, ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vstream_f<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                z.vstream(v32f(src), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                z.vstream(v64f(src), ref float64(ref dst));
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void vstream_u<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                z.vstream(v8u(src), ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                z.vstream(v16u(src), ref uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                z.vstream(v32u(src), ref uint32(ref dst));
            else if(typeof(T) == typeof(ulong))
                z.vstream(v64u(src), ref uint64(ref dst));
            else
                 vstream_i(src,ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vstream_i<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                z.vstream(v8i(src), ref int8(ref dst));
            else if(typeof(T) == typeof(short))
                z.vstream(v16i(src), ref int16(ref dst));
            else if(typeof(T) == typeof(int))
                z.vstream(v32i(src), ref int32(ref dst));
            else if(typeof(T) == typeof(long))
                z.vstream(v64i(src), ref int64(ref dst));
            else
                vstream_f(src, ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vstream_f<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                z.vstream(v32f(src), ref z.float32(ref dst));
            else if(typeof(T) == typeof(double))
                z.vstream(v64f(src), ref z.float64(ref dst));
            else
                throw no<T>();
        }
    }
}