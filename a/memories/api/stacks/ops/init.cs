//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Core;
    using static As;
    using static AsIn;
    using static refs;
    using static Stacked;

    partial class Stacks
    {
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.U8 | NumericKind.U16 | NumericKind.U32)]
        public static MemStack32 init<T>(W32 w, in T src)
            where T : unmanaged
        {
            var dst = alloc(w);
            head32(ref dst) = uint32(in src);
            return dst;
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static MemStack64 init<T>(W64 w, in T src)
            where T : unmanaged
        {
            var dst = alloc(w);
            head64(ref dst) = uint64(in src);
            return dst;
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static MemStack128 init<T>(W128 w, in T src)
            where T : unmanaged
        {
            var dst = alloc(w);
            ref var dst64 = ref head64(ref dst);
            ref readonly var src64 = ref uint64(in src);
            
            seek(ref dst64, 0) = skip(in src64, 0);
            seek(ref dst64, 1) = skip(in src64, 1);
            return dst;
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static MemStack256 init<T>(W256 w, in T src)
            where T : unmanaged
        {
            var dst = alloc(w);
            ref var dst64 = ref head64(ref dst);
            ref readonly var src64 = ref uint64(in src);

            seek(ref dst64, 0) = skip(in src64, 0);
            seek(ref dst64, 1) = skip(in src64, 1);
            seek(ref dst64, 2) = skip(in src64, 2);
            seek(ref dst64, 3) = skip(in src64, 3);
            return dst;
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static MemStack512 init<T>(W512 w, in T src)
            where T : unmanaged
        {
            var dst = alloc(w);
            var cells = 64/size<T>();
            Cells.copy(in src, ref head<T>(ref dst), cells);
            return dst;
        }
    }
}