//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static As;

    partial struct Addressable
    {

        [MethodImpl(Inline), Op]
        public static string format(RelAddress<W32,W16,uint,ushort> src)
            => src.Format();

        [MethodImpl(Inline), Op]
        public static string format(RelAddress<W32,W32,uint,uint> src)
            => src.Format();

    }
}