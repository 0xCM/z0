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
    using static z;

    partial class Cells
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Cell128 init<T>(Vector128<T> src)
            where T : unmanaged
                => new Cell128(v64u(src));

        [MethodImpl(Inline), Op]
        public static Cell128 init((ulong x0, ulong x1) x)
            => new Cell128(x.x0, x.x1);

        [MethodImpl(Inline), Op]
        public static Cell128 init(in ConstPair<ulong> x)
            => new Cell128(x.Left,x.Right);
    }
}