//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;     
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Control;
    using static Typed;

    partial class AsciCodes
    {
        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode2 define(N2 n, in ushort src)
            => ref view<ushort,AsciCode2>(src);

        [MethodImpl(Inline), Op]
        public static AsciCode2 define(N2 n, ReadOnlySpan<byte> src)
            => define(n,head(cast<byte,ushort>(src)));

        [MethodImpl(Inline), Op]
        public static AsciCode4 define(N4 n, ReadOnlySpan<byte> src)
            => define(n,head(cast<byte,uint>(src)));

        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode4 define(N4 n, in uint src)
            => ref view<uint,AsciCode4>(src);

        [MethodImpl(Inline), Op]
        public static AsciCode5 define(N5 n, ReadOnlySpan<byte> src)
            => define(n, head(cast<byte,ulong>(src)));

        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode5 define(N5 n, in ulong src)
            => ref view<ulong,AsciCode5>(src);

        [MethodImpl(Inline), Op]
        public static AsciCode8 define(N8 n, ReadOnlySpan<byte> src)
            => define(n, head(cast<byte,uint>(src)));

        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode8 define(N8 n, in ulong src)
            => ref view<ulong,AsciCode8>(src);

        [MethodImpl(Inline), Op]
        public static AsciCode16 define(N16 n, ulong lo, ulong hi)
            => new AsciCode16(Vector128.Create(lo,hi).AsByte());

    }
}