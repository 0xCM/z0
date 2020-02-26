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
    using static Refs;
    using static P2K;

    partial class Stacks
    {
        [MethodImpl(Inline)]
        public static MemStack64 init<T>(P2x6 p2, in T src)
            where T : unmanaged
        {
            var dst = alloc(p2);
            head64(ref dst) = uint64(in src);
            return dst;
        }

        [MethodImpl(Inline)]
        public static MemStack128 init<T>(P2x7 p2, in T src)
            where T : unmanaged
        {
            var dst = alloc(p2);
            ref var dst64 = ref head64(ref dst);
            ref readonly var src64 = ref uint64(in src);
            
            seek(ref dst64, 0) = skip(in src64, 0);
            seek(ref dst64, 1) = skip(in src64, 1);
            return dst;
        }

        [MethodImpl(Inline)]
        public static MemStack256 init<T>(P2x8 p2, in T src)
            where T : unmanaged
        {
            var dst = alloc(p2);
            ref var dst64 = ref head64(ref dst);
            ref readonly var src64 = ref uint64(in src);

            seek(ref dst64, 0) = skip(in src64, 0);
            seek(ref dst64, 1) = skip(in src64, 1);
            seek(ref dst64, 2) = skip(in src64, 2);
            seek(ref dst64, 3) = skip(in src64, 3);
            return dst;
        }


        [MethodImpl(Inline)]
        public static MemStack512 init<T>(P2x9 p2, in T src)
            where T : unmanaged
        {
            var dst = alloc(p2);
            PolyData.copy(in src, ref head<T>(ref dst), count<T>(p2));
            return dst;
        }

        [MethodImpl(Inline)]
        public static MemStack1024 init<T>(P2x10 p2, in T src)
            where T : unmanaged
        {
            var dst = alloc(p2);
            PolyData.copy(in src, ref head<T>(ref dst), count<T>(p2));
            return dst;
        }        


    }

}