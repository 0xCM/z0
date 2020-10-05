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

    partial struct Address
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> read<T>(in Ref src)
            => src.As<T>();


        const int ResLength = 0xA;

    }
}