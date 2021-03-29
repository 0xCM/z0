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

    partial class MemBlocks
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block02<T> load<T>(ReadOnlySpan<T> src, ref Block02<T> dst)
            where T : unmanaged
        {
            dst = memory.first(recover<T,Block02<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block03<T> load<T>(ReadOnlySpan<T> src, ref Block03<T> dst)
            where T : unmanaged
        {
            dst = memory.first(recover<T,Block03<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block04<T> load<T>(ReadOnlySpan<T> src, ref Block04<T> dst)
            where T : unmanaged
        {
            dst = memory.first(recover<T,Block04<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block05<T> load<T>(ReadOnlySpan<T> src, ref Block05<T> dst)
            where T : unmanaged
        {
            dst = memory.first(recover<T,Block05<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block06<T> load<T>(ReadOnlySpan<T> src, ref Block06<T> dst)
            where T : unmanaged
        {
            dst = memory.first(recover<T,Block06<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block07<T> load<T>(ReadOnlySpan<T> src, ref Block07<T> dst)
            where T : unmanaged
        {
            dst = memory.first(recover<T,Block07<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block08<T> load<T>(ReadOnlySpan<T> src, ref Block08<T> dst)
            where T : unmanaged
        {
            dst = memory.first(recover<T,Block08<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block12<T> load<T>(ReadOnlySpan<T> src, ref Block12<T> dst)
            where T : unmanaged
        {
            dst = memory.first(recover<T,Block12<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block16<T> load<T>(ReadOnlySpan<T> src, ref Block16<T> dst)
            where T : unmanaged
        {
            dst = memory.first(recover<T,Block16<T>>(src));
            return ref dst;
        }
    }
}