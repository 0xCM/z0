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
    using static Control;

    partial struct asci
    {
        [MethodImpl(Inline), Op]
        public static ref readonly asci2 define(N2 n, in ushort src)
            => ref view<ushort,asci2>(src);

        [MethodImpl(Inline), Op]
        public static asci2 define(N2 n, ReadOnlySpan<byte> src)
            => define(n,head(cast<byte,ushort>(src)));

        [MethodImpl(Inline), Op]
        public static asci4 define(N4 n, ReadOnlySpan<byte> src)
            => define(n,head(cast<byte,uint>(src)));

        [MethodImpl(Inline), Op]
        public static ref readonly asci4 define(N4 n, in uint src)
            => ref view<uint,asci4>(src);

        [MethodImpl(Inline), Op]
        public static asci5 define(N5 n, ReadOnlySpan<byte> src)
            => define(n, head(cast<byte,ulong>(src)));

        [MethodImpl(Inline), Op]
        public static ref readonly asci5 define(N5 n, in ulong src)
            => ref view<ulong,asci5>(src);

        [MethodImpl(Inline), Op]
        public static asci8 define(N8 n, ReadOnlySpan<byte> src)
            => define(n, head(cast<byte,uint>(src)));

        [MethodImpl(Inline), Op]
        public static ref readonly asci8 define(N8 n, in ulong src)
            => ref view<ulong,asci8>(src);

        [MethodImpl(Inline), Op]
        public static asci16 define(N16 n, ulong lo, ulong hi)
            => new asci16(Vector128.Create(lo,hi).AsByte());
    }
}