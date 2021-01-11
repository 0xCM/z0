//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly partial struct DataBlocks
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block04<T> load<T>(ReadOnlySpan<T> src, ref Block04<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,Block04<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block03<T> load<T>(ReadOnlySpan<T> src, ref Block03<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,Block03<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Block03<T> store<T>(in Block03<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,Block03<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Block04<T> store<T>(in Block04<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,Block04<T>>(dst)) = src;
            return ref src;
        }
    }
}