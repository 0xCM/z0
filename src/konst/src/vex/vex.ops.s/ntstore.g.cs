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

    partial struct gcpu
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void ntstore<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
                => ntstore_u(src, ref dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void ntstore<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
                => ntstore_u(src, ref dst);

        [MethodImpl(Inline)]
        static unsafe void ntstore_u<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                cpu.ntstore(v8u(src), ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                cpu.ntstore(v16u(src), ref uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                cpu.ntstore(v32u(src), ref uint32(ref dst));
            else if(typeof(T) == typeof(ulong))
                cpu.ntstore(v64u(src), ref uint64(ref dst));
            else
                 ntstore_i(src,ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void ntstore_i<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                cpu.ntstore(v8i(src), ref int8(ref dst));
            else if(typeof(T) == typeof(short))
                cpu.ntstore(v16i(src), ref int16(ref dst));
            else if(typeof(T) == typeof(int))
                cpu.ntstore(v32i(src), ref int32(ref dst));
            else if(typeof(T) == typeof(long))
                cpu.ntstore(v64i(src), ref int64(ref dst));
            else
                ntstore_f(src, ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void ntstore_f<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                cpu.ntstore(v32f(src), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                cpu.ntstore(v64f(src), ref float64(ref dst));
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void ntstore_u<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                cpu.ntstore(v8u(src), ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                cpu.ntstore(v16u(src), ref uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                cpu.ntstore(v32u(src), ref uint32(ref dst));
            else if(typeof(T) == typeof(ulong))
                cpu.ntstore(v64u(src), ref uint64(ref dst));
            else
                 ntstore_i(src,ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void ntstore_i<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                cpu.ntstore(v8i(src), ref int8(ref dst));
            else if(typeof(T) == typeof(short))
                cpu.ntstore(v16i(src), ref int16(ref dst));
            else if(typeof(T) == typeof(int))
                cpu.ntstore(v32i(src), ref int32(ref dst));
            else if(typeof(T) == typeof(long))
                cpu.ntstore(v64i(src), ref int64(ref dst));
            else
                ntstore_f(src, ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void ntstore_f<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                cpu.ntstore(v32f(src), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                cpu.ntstore(v64f(src), ref float64(ref dst));
            else
                throw no<T>();
        }
    }
}