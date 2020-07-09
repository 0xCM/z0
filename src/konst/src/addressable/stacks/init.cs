//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Stacked;
    using static In;

    partial class Stacks
    {
        [MethodImpl(Inline), Op, Closures(Numeric8x16x32k)]
        public static MemStack32 init<T>(W32 w, in T src)
            where T : unmanaged
        {
            var dst = alloc(w);
            head32(ref dst) = uint32(src);
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static MemStack64 init<T>(W64 w, in T src)
            where T : unmanaged
        {
            var dst = alloc(w);
            head64(ref dst) = uint64(src);
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static MemStack128 init<T>(W128 w, in T src)
            where T : unmanaged
        {
            var dst = alloc(w);
            ref var dst64 = ref head64(ref dst);
            ref readonly var src64 = ref uint64(src);
            
            core.seek(dst64, 0) = core.skip(src64, 0);
            core.seek(dst64, 1) = core.skip(src64, 1);
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static MemStack256 init<T>(W256 w, in T src)
            where T : unmanaged
        {
            var dst = alloc(w);
            ref var dst64 = ref head64(ref dst);
            ref readonly var src64 = ref uint64(src);

            core.seek(dst64, 0) = core.skip(src64, 0);
            core.seek(dst64, 1) = core.skip(src64, 1);
            core.seek(dst64, 2) = core.skip(src64, 2);
            core.seek(dst64, 3) = core.skip(src64, 3);
            return dst;
        }
    }
}