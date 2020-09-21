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

    partial struct Table
    {
        [MethodImpl(Inline)]
        public static ClosedInterval<ulong> indices<D,S>(in ClosedInterval<ulong> positions, S min, S max)
            where D : unmanaged, Enum
            where S : unmanaged
        {
            var offset = positions.Min;
            var left = uint64(min) - offset;
            var right = uint64(max) - offset;
            return (left,right);
        }
    }
}