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

    [ApiHost]
    public readonly struct HashBlocks
    {
        [Op]
        public static HashBlock32 alloc(W32 w, N64 n)
            => new HashBlock32(alloc<Hash32>(n));

        [Op]
        public static HashBlock32 alloc(W32 w, N128 n)
            => new HashBlock32(alloc<Hash32>(n));

        [Op]
        public static HashBlock32 alloc(W32 w, N256 n)
            => new HashBlock32(alloc<Hash32>(n));

        [Op]
        public static HashBlock32 alloc(W32 w, N512 n)
            => new HashBlock32(alloc<Hash32>(n));

        [Op]
        public static HashBlock32 alloc(W32 w, N1024 n)
            => new HashBlock32(alloc<Hash32>(n));

        [Op]
        public static HashBlock32 alloc(W32 w, N2048 n)
            => new HashBlock32(alloc<Hash32>(n));

        [Op]
        public static HashBlock32 alloc(W32 w, N4096 n)
            => new HashBlock32(alloc<Hash32>(n));

        [Op]
        public static HashBlock32 alloc(W32 w, N8192 n)
            => new HashBlock32(alloc<Hash32>(n));

        [Op]
        public static HashBlock32 alloc(W32 w, N16384 n)
            => new HashBlock32(alloc<Hash32>(n));

        [Op]
        public static HashBlock32 alloc(W32 w, N32768 n)
            => new HashBlock32(alloc<Hash32>(n));
    }
}