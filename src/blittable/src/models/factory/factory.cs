//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Blit
    {
        partial struct Factory
        {
            [MethodImpl(Inline), Op, Closures(Closure)]
            public static v1<T> v1<T>(T a0 = default)
                where T : unmanaged
                    => a0;

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static v2<T> v2<T>(T a0 = default, T a1 = default)
                where T : unmanaged
            {
                var v = new v2<T>();
                ref var dst = ref Operate.cell(n0, ref v);
                seek(dst,0) = a0;
                seek(dst,1) = a1;
                return v;
            }

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static v3<T> v3<T>(T a0 = default, T a1 = default, T a2 = default)
                where T : unmanaged
            {
                var v = new v3<T>();
                ref var dst = ref Operate.cell(n0, ref v);
                seek(dst,0) = a0;
                seek(dst,1) = a1;
                seek(dst,2) = a2;
                return v;
            }

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static v4<T> v4<T>(T a0 = default, T a1 = default, T a2 = default, T a3 = default)
                where T : unmanaged
            {
                var v = new v4<T>();
                ref var dst = ref Operate.cell(n0, ref v);
                seek(dst,0) = a0;
                seek(dst,1) = a1;
                seek(dst,2) = a2;
                seek(dst,3) = a3;
                return v;
            }

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static v8<T> v8<T>(T a0 = default, T a1 = default, T a2 = default, T a3 = default, T a4 = default, T a5 = default, T a6 = default, T a7 = default)
                where T : unmanaged
            {
                var v = new v8<T>();
                ref var dst = ref Operate.cell(n0, ref v);
                seek(dst,0) = a0;
                seek(dst,1) = a1;
                seek(dst,2) = a2;
                seek(dst,3) = a3;
                seek(dst,4) = a4;
                seek(dst,5) = a5;
                seek(dst,6) = a6;
                seek(dst,7) = a7;
                return v;
            }

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static v16<T> v16<T>(v8<T> a0 = default, v8<T> a1 = default)
                where T : unmanaged
            {
                var v = new v16<T>();
                ref var dst = ref @as<T,v8<T>>(Operate.cell(n0, ref v));
                seek(dst,0) = a0;
                seek(dst,1) = a1;
                return v;
            }

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static v32<T> v32<T>(v16<T> a0 = default, v16<T> a1 = default)
                where T : unmanaged
            {
                var v = new v32<T>();
                ref var dst = ref @as<T,v16<T>>(Operate.cell(n0, ref v));
                seek(dst,0) = a0;
                seek(dst,1) = a1;
                return v;
            }

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static v64<T> v64<T>(v32<T> a0 = default, v32<T> a1 = default)
                where T : unmanaged
            {
                var v = new v64<T>();
                ref var dst = ref @as<T,v32<T>>(Operate.cell(n0, ref v));
                seek(dst,0) = a0;
                seek(dst,1) = a1;
                return v;
            }

            [MethodImpl(Inline), Op]
            public static vNx1<bit> v1(bit[] src)
                => new vNx1<bit>(src);

            [MethodImpl(Inline), Op]
            public static vNx1<byte> v1(byte[] src)
                => new vNx1<byte>(src);

            [MethodImpl(Inline), Op]
            public static vNx8<byte> v8(byte[] src)
                => new vNx8<byte>(src);

            [MethodImpl(Inline), Op]
            public static vNx16<ushort> v16(ushort[] src)
                => new vNx16<ushort>(src);

            [MethodImpl(Inline), Op]
            public static vNx32<uint> v32(uint[] src)
                => new vNx32<uint>(src);

            [MethodImpl(Inline), Op]
            public static vNx64<ulong> v64(ulong[] src)
                => new vNx64<ulong>(src);

            [MethodImpl(Inline), Op]
            public static vNx64<MemoryAddress> v64(MemoryAddress[] src)
                => new vNx64<MemoryAddress>(src);

            [MethodImpl(Inline)]
            public static vector<N,T> vector<N,T>(N n, T[] src)
                where N : unmanaged, ITypeNat
                where T : unmanaged
            {
                if(Typed.nat32i<N>() != src.Length)
                    return Blit.vector<N,T>.Empty;
                else
                    return new vector<N, T>(src);
            }
        }
    }
}