//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static Stacked;
    using static AsIn;

    partial class Stacks
    {
        [MethodImpl(Inline)]
        public static MemStack64 init<T>(N64 n, in T src)
            where T : unmanaged
        {
            var dst = alloc(n);
            head64(ref dst) = uint64(in src);
            return dst;
        }

        [MethodImpl(Inline)]
        public static MemStack128 init<T>(N128 n, in T src)
            where T : unmanaged
        {
            var dst = alloc(n);
            ref var dst64 = ref head64(ref dst);
            ref readonly var src64 = ref uint64(in src);
            
            seek(ref dst64, 0) = skip(in src64, 0);
            seek(ref dst64, 1) = skip(in src64, 1);
            return dst;
        }

        [MethodImpl(Inline)]
        public static MemStack256 init<T>(N256 n, in T src)
            where T : unmanaged
        {
            var dst = alloc(n);
            ref var dst64 = ref head64(ref dst);
            ref readonly var src64 = ref uint64(in src);

            seek(ref dst64, 0) = skip(in src64, 0);
            seek(ref dst64, 1) = skip(in src64, 1);
            seek(ref dst64, 2) = skip(in src64, 2);
            seek(ref dst64, 3) = skip(in src64, 3);
            return dst;
        }

        [MethodImpl(Inline)]
        public static MemStack512 init<T>(N512 n, in T src)
            where T : unmanaged
        {
            var dst = alloc(n);
            Cells.copy(in src, ref head<T>(ref dst), count<T>(n));
            return dst;
        }

        [MethodImpl(Inline)]
        public static MemStack1024 init<T>(N1024 n, in T src)
            where T : unmanaged
        {
            var dst = alloc(n);
            Cells.copy(in src, ref head<T>(ref dst), count<T>(n));
            return dst;
        }
    }
}