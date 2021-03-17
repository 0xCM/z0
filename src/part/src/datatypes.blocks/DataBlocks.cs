//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly partial struct DataBlocks
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block02<T> alloc<T>(N2 n, out Block02<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block03<T> alloc<T>(N3 n, out Block03<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block04<T> alloc<T>(N4 n, out Block04<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block05<T> alloc<T>(N5 n, out Block05<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block06<T> alloc<T>(N6 n, out Block06<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block07<T> alloc<T>(N7 n, out Block07<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block08<T> alloc<T>(N8 n, out Block08<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block12<T> alloc<T>(N2 n, out Block12<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block16<T> alloc<T>(N16 n, out Block16<T> dst)
            where T : unmanaged
        {
            dst = default;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block02<T> load<T>(ReadOnlySpan<T> src, ref Block02<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,Block02<T>>(src));
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
        public static ref Block04<T> load<T>(ReadOnlySpan<T> src, ref Block04<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,Block04<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block05<T> load<T>(ReadOnlySpan<T> src, ref Block05<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,Block05<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block06<T> load<T>(ReadOnlySpan<T> src, ref Block06<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,Block06<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block07<T> load<T>(ReadOnlySpan<T> src, ref Block07<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,Block07<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block08<T> load<T>(ReadOnlySpan<T> src, ref Block08<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,Block08<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block12<T> load<T>(ReadOnlySpan<T> src, ref Block12<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,Block12<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block16<T> load<T>(ReadOnlySpan<T> src, ref Block16<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,Block16<T>>(src));
            return ref dst;
        }


        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Block02<T> store<T>(in Block02<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,Block02<T>>(dst)) = src;
            return ref src;
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

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Block05<T> store<T>(in Block05<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,Block05<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Block06<T> store<T>(in Block06<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,Block06<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Block07<T> store<T>(in Block07<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,Block07<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Block08<T> store<T>(in Block08<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,Block08<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Block12<T> store<T>(in Block12<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,Block12<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Block16<T> store<T>(in Block16<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,Block16<T>>(dst)) = src;
            return ref src;
        }

        public struct Block01<T>
            where T : unmanaged
        {
            T Data;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block02<T>
            where T : unmanaged
        {
            Block01<T> Block0;

            Block01<T> Block1;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block03<T>
            where T : unmanaged
        {
            Block01<T> Block0;

            Block02<T> Block1;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block04<T>
            where T : unmanaged
        {
            Block02<T> Cell0;

            Block02<T> Cell1;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block05<T>
            where T : unmanaged
        {
            Block04<T> Cell0;

            Block01<T> Cell1;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block06<T>
            where T : unmanaged
        {
            Block03<T> Cell0;

            Block03<T> Cell1;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block07<T>
            where T : unmanaged
        {
            Block06<T> Cell0;

            Block01<T> Cell1;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block08<T>
            where T : unmanaged
        {
            Block04<T> Cell0;

            Block04<T> Cell1;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block12<T>
            where T : unmanaged
        {
            Block06<T> Cell0;

            Block06<T> Cell1;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block16<T>
            where T : unmanaged
        {
            Block08<T> Cell0;

            Block08<T> Cell1;
        }

    }
}