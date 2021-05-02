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
    public readonly struct DataBlocks
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock02<T> init<T>(N2 n, out DataBlock02<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock03<T> init<T>(N3 n, out DataBlock03<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock04<T> init<T>(N4 n, out DataBlock04<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock05<T> init<T>(N5 n, out DataBlock05<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock06<T> init<T>(N6 n, out DataBlock06<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock07<T> init<T>(N7 n, out DataBlock07<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock08<T> init<T>(N8 n, out DataBlock08<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock12<T> init<T>(N12 n, out DataBlock12<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock16<T> init<T>(N16 n, out DataBlock16<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock02<T> load<T>(ReadOnlySpan<T> src, ref DataBlock02<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,DataBlock02<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock03<T> load<T>(ReadOnlySpan<T> src, ref DataBlock03<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,DataBlock03<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock04<T> load<T>(ReadOnlySpan<T> src, ref DataBlock04<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,DataBlock04<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock05<T> load<T>(ReadOnlySpan<T> src, ref DataBlock05<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,DataBlock05<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock06<T> load<T>(ReadOnlySpan<T> src, ref DataBlock06<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,DataBlock06<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock07<T> load<T>(ReadOnlySpan<T> src, ref DataBlock07<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,DataBlock07<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock08<T> load<T>(ReadOnlySpan<T> src, ref DataBlock08<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,DataBlock08<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock12<T> load<T>(ReadOnlySpan<T> src, ref DataBlock12<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,DataBlock12<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock16<T> load<T>(ReadOnlySpan<T> src, ref DataBlock16<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,DataBlock16<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly DataBlock02<T> store<T>(in DataBlock02<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,DataBlock02<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly DataBlock03<T> store<T>(in DataBlock03<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,DataBlock03<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly DataBlock04<T> store<T>(in DataBlock04<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,DataBlock04<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly DataBlock05<T> store<T>(in DataBlock05<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,DataBlock05<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly DataBlock06<T> store<T>(in DataBlock06<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,DataBlock06<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly DataBlock07<T> store<T>(in DataBlock07<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,DataBlock07<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly DataBlock08<T> store<T>(in DataBlock08<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,DataBlock08<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly DataBlock12<T> store<T>(in DataBlock12<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,DataBlock12<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly DataBlock16<T> store<T>(in DataBlock16<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,DataBlock16<T>>(dst)) = src;
            return ref src;
        }
    }
}