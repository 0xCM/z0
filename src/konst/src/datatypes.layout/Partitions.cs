//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct Partitions
    {
        const NumericKind Closure = UnsignedInts;

        [Op, Closures(Closure)]
        public static string format<T>(PartitionRange<T> src)
            where T : unmanaged
                => RenderPart<T>().Format(src.Min, src.Max);

        [MethodImpl(Inline)]
        static RenderPattern<T,T> RenderPart<T>()
            where T : unmanaged
                => "[{0},{1})";
    }
}