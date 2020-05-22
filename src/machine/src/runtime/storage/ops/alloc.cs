//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class CpuStorage
    {
        [MethodImpl(Inline), Alloc]
        public static Bank8 alloc(W8 w, N16 n)
            => new Bank8(new byte[n]);

        [MethodImpl(Inline), Alloc]
        public static Bank8 alloc(W8 w, N32 n)
            => new Bank8(new byte[n]);

        [MethodImpl(Inline), Alloc]
        public static Bank16 alloc(W16 w, N16 n)
            => new Bank16(new ushort[n]);

        [MethodImpl(Inline), Alloc]
        public static Bank16 alloc(W16 w, N32 n)
            => new Bank16(new ushort[n]);

        [MethodImpl(Inline), Alloc]
        public static Bank32 alloc(W32 w, N16 n)
            => new Bank32(new uint[n]);

        [MethodImpl(Inline), Alloc]
        public static Bank32 alloc(W32 w, N32 n)
            => new Bank32(new uint[n]);

        [MethodImpl(Inline), Alloc]
        public static Bank64 alloc(W64 w, N16 n)
            => new Bank64(new ulong[n]);

        [MethodImpl(Inline), Alloc]
        public static Bank64 alloc(W64 w, N32 n)
            => new Bank64(new ulong[n]);

        [MethodImpl(Inline), Alloc]
        public static Bank128 alloc(W128 w, N16 n)
            => new Bank128(new Fixed128[n]);

        [MethodImpl(Inline), Alloc]
        public static Bank128 alloc(W128 w, N32 n)
            => new Bank128(new Fixed128[n]);

        [MethodImpl(Inline), Alloc]
        public static Bank256 alloc(W256 w, N16 n)
            => new Bank256(new Fixed256[n]);

        [MethodImpl(Inline), Alloc]
        public static Bank256 alloc(W256 w, N32 n)
            => new Bank256(new Fixed256[n]);

        [MethodImpl(Inline), Alloc]
        public static Bank512 alloc(W512 w, N16 n)
            => new Bank512(new Fixed512[n]);

        [MethodImpl(Inline), Alloc]
        public static Bank512 alloc(W512 w, N32 n)
            => new Bank512(new Fixed512[n]);
    }
}