//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static memory;

    partial struct gcpu
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vntstore<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
                => vntstore_u(src, ref dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vntstore<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
                => vntstore_u(src, ref dst);

        [MethodImpl(Inline)]
        static unsafe void vntstore_u<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                cpu.vntstore(v8u(src), ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                cpu.vntstore(v16u(src), ref uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                cpu.vntstore(v32u(src), ref uint32(ref dst));
            else if(typeof(T) == typeof(ulong))
                cpu.vntstore(v64u(src), ref uint64(ref dst));
            else
                 vntstore_i(src,ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vntstore_i<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                cpu.vntstore(v8i(src), ref int8(ref dst));
            else if(typeof(T) == typeof(short))
                cpu.vntstore(v16i(src), ref int16(ref dst));
            else if(typeof(T) == typeof(int))
                cpu.vntstore(v32i(src), ref int32(ref dst));
            else if(typeof(T) == typeof(long))
                cpu.vntstore(v64i(src), ref int64(ref dst));
            else
                vntstore_f(src, ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vntstore_f<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                cpu.vntstore(v32f(src), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                cpu.vntstore(v64f(src), ref float64(ref dst));
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void vntstore_u<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                cpu.vntstore(v8u(src), ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                cpu.vntstore(v16u(src), ref uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                cpu.ntstore(v32u(src), ref uint32(ref dst));
            else if(typeof(T) == typeof(ulong))
                cpu.vntstore(v64u(src), ref uint64(ref dst));
            else
                 vntstore_i(src,ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vntstore_i<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                cpu.vntstore(v8i(src), ref int8(ref dst));
            else if(typeof(T) == typeof(short))
                cpu.vntstore(v16i(src), ref int16(ref dst));
            else if(typeof(T) == typeof(int))
                cpu.vntstore(v32i(src), ref int32(ref dst));
            else if(typeof(T) == typeof(long))
                cpu.vntstore(v64i(src), ref int64(ref dst));
            else
                vntstore_f(src, ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vntstore_f<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                cpu.vntstore(v32f(src), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                cpu.vntstore(v64f(src), ref float64(ref dst));
            else
                throw no<T>();
        }
    }
}