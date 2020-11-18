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

    partial struct DataLayouts
    {
        [MethodImpl(Inline), Op]
        public static LayoutRange range(ulong left, ulong right)
            => new LayoutRange(left,right);

        [MethodImpl(Inline), Op]
        public static LayoutRange<T> range<T>(T left, T right)
            where T : unmanaged
                => new LayoutRange<T>(left,right);
    }
}