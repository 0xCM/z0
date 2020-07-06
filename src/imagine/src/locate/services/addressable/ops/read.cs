//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Addressable
    {
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static Span<T> read<T>(in Ref src)
            => src.As<T>();
    }
}