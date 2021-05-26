//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static core;

    partial struct gcpu
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstorent<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
                => vstorent_u(src, ref dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstorent<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
                => vstorent_u(src, ref dst);

        [MethodImpl(Inline)]
        static unsafe void vstorent_u<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                cpu.vstorent(v8u(src), ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                cpu.vstorent(v16u(src), ref uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                cpu.vstorent(v32u(src), ref uint32(ref dst));
            else if(typeof(T) == typeof(ulong))
                cpu.vstorent(v64u(src), ref uint64(ref dst));
            else
                 vstorent_i(src,ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vstorent_i<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                cpu.vstorent(v8i(src), ref int8(ref dst));
            else if(typeof(T) == typeof(short))
                cpu.vstorent(v16i(src), ref int16(ref dst));
            else if(typeof(T) == typeof(int))
                cpu.vstorent(v32i(src), ref int32(ref dst));
            else if(typeof(T) == typeof(long))
                cpu.vstorent(v64i(src), ref int64(ref dst));
            else
                vstorent_f(src, ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vstorent_f<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                cpu.vstorent(v32f(src), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                cpu.vntstore(v64f(src), ref float64(ref dst));
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void vstorent_u<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                cpu.vstorent(v8u(src), ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                cpu.vstorent(v16u(src), ref uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                cpu.vstorent(v32u(src), ref uint32(ref dst));
            else if(typeof(T) == typeof(ulong))
                cpu.vstorent(v64u(src), ref uint64(ref dst));
            else
                 vstorent_i(src,ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vstorent_i<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                cpu.vstorent(v8i(src), ref int8(ref dst));
            else if(typeof(T) == typeof(short))
                cpu.vstorent(v16i(src), ref int16(ref dst));
            else if(typeof(T) == typeof(int))
                cpu.vstorent(v32i(src), ref int32(ref dst));
            else if(typeof(T) == typeof(long))
                cpu.vstorent(v64i(src), ref int64(ref dst));
            else
                vstorent_f(src, ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vstorent_f<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                cpu.vstorent(v32f(src), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                cpu.vstorent(v64f(src), ref float64(ref dst));
            else
                throw no<T>();
        }
    }
}