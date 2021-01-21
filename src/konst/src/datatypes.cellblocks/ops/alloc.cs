//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct CellBlocks
    {
        [MethodImpl(Inline), Op]
        public static CellBlock1 alloc(N1 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock2 alloc(N2 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock16 alloc(N16 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock32 alloc(N32 n)
            => default;
    }
}