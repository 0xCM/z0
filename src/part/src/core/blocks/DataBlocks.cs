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
        public static ref DataBlock2<T> init<T>(N2 n, out DataBlock2<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock3<T> init<T>(N3 n, out DataBlock3<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock4<T> init<T>(N4 n, out DataBlock4<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock5<T> init<T>(N5 n, out DataBlock5<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock6<T> init<T>(N6 n, out DataBlock6<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock7<T> init<T>(N7 n, out DataBlock7<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock8<T> init<T>(N8 n, out DataBlock8<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock9<T> init<T>(N9 n, out DataBlock9<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock10<T> init<T>(N10 n, out DataBlock10<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock11<T> init<T>(N11 n, out DataBlock11<T> dst)
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
        public static ref DataBlock2<T> load<T>(ReadOnlySpan<T> src, ref DataBlock2<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,DataBlock2<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock3<T> load<T>(ReadOnlySpan<T> src, ref DataBlock3<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,DataBlock3<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock4<T> load<T>(ReadOnlySpan<T> src, ref DataBlock4<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,DataBlock4<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock5<T> load<T>(ReadOnlySpan<T> src, ref DataBlock5<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,DataBlock5<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock6<T> load<T>(ReadOnlySpan<T> src, ref DataBlock6<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,DataBlock6<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock7<T> load<T>(ReadOnlySpan<T> src, ref DataBlock7<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,DataBlock7<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DataBlock8<T> load<T>(ReadOnlySpan<T> src, ref DataBlock8<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,DataBlock8<T>>(src));
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
        public static ref readonly DataBlock2<T> store<T>(in DataBlock2<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,DataBlock2<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly DataBlock3<T> store<T>(in DataBlock3<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,DataBlock3<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly DataBlock4<T> store<T>(in DataBlock4<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,DataBlock4<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly DataBlock5<T> store<T>(in DataBlock5<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,DataBlock5<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly DataBlock6<T> store<T>(in DataBlock6<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,DataBlock6<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly DataBlock7<T> store<T>(in DataBlock7<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,DataBlock7<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly DataBlock8<T> store<T>(in DataBlock8<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,DataBlock8<T>>(dst)) = src;
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