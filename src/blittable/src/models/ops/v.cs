//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Blit
    {
        partial struct Factory
        {
            [MethodImpl(Inline), Op]
            public static v1<bit> v1(bit[] src)
                => new v1<bit>(src);

            [MethodImpl(Inline), Op]
            public static v1<byte> v1(byte[] src)
                => new v1<byte>(src);

            [MethodImpl(Inline), Op]
            public static v8<byte> v8(byte[] src)
                => new v8<byte>(src);

            [MethodImpl(Inline), Op]
            public static v16<ushort> v16(ushort[] src)
                => new v16<ushort>(src);

            [MethodImpl(Inline), Op]
            public static v32<uint> v32(uint[] src)
                => new v32<uint>(src);

            [MethodImpl(Inline), Op]
            public static v64<ulong> v64(ulong[] src)
                => new v64<ulong>(src);

            [MethodImpl(Inline), Op]
            public static v64<MemoryAddress> v64(MemoryAddress[] src)
                => new v64<MemoryAddress>(src);

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