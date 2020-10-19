//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Bytes
    {
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> cells<T>(N2 n)
            where T : unmanaged
                => z.recover<byte,T>(slice(Bytes.B256x8u,0,2));

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> cells<T>(N4 n)
            where T : unmanaged
                => z.recover<byte,T>(slice(Bytes.B256x8u,0,4));

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> cells<T>(N8 n)
            where T : unmanaged
                => z.recover<byte,T>(slice(Bytes.B256x8u,0,8));

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> cells<T>(N16 n)
            where T : unmanaged
                => z.recover<byte,T>(slice(Bytes.B256x8u,0,16));

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> cells<T>(N32 n)
            where T : unmanaged
                => z.recover<byte,T>(slice(Bytes.B256x8u,0,32));

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> cells<T>(N64 n)
            where T : unmanaged
                => z.recover<byte,T>(slice(Bytes.B256x8u,0,64));

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> cells<T>(N128 n)
            where T : unmanaged
                => z.recover<byte,T>(slice(Bytes.B256x8u,0,128));

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> cells<T>(N256 n)
            where T : unmanaged
                => z.recover<byte,T>(Bytes.B256x8u);
    }
}