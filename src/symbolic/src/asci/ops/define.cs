//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
     
    using static Seed;
    using static Control;

    partial class AsciCodes
    {
        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode2 define(in ushort src, N2 n)
            => ref view<ushort,AsciCode2>(src);

        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode4 define(in uint src, N4 n)
            => ref view<uint,AsciCode4>(src);

        [MethodImpl(Inline), Op]
        public static AsciCode2 define(ReadOnlySpan<byte> src, N2 n)
            => define(head(cast<byte,ushort>(src)), n);

        [MethodImpl(Inline), Op]
        public static AsciCode4 define(ReadOnlySpan<byte> src, N4 n)
            => define(head(cast<byte,uint>(src)), n);
    }
}