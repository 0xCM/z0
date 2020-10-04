//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class Stacks
    {
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static DataBlock<T> init<T>(in T lo, in T hi)
            where T : unmanaged
                => pair(lo, hi);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitBlock32 init<T>(W32 w, in T src)
            where T : unmanaged
        {
            ref var dst8 = ref alloc(out BitBlock32 dst);
            if(typeof(T) == typeof(byte))
            {
                ref var x = ref dst8;
                ref readonly var y = ref u8(src);
                seek(x,0) = y;
                seek(x,1) = y;
                seek(x,2) = y;
                seek(x,3) = y;
                return dst;
            }
            else if(typeof(T) == typeof(ushort))
            {
                ref var x = ref u16(dst8);
                ref readonly var y = ref u16(src);
                seek(x,0) = y;
                seek(x,1) = y;
                return dst;
            }
            else if(typeof(T) == typeof(uint))
            {
                ref var x = ref u32(dst8);
                ref readonly var y = ref u32(src);
                seek(x,0) = y;
                return dst;
            }
            else if(typeof(T) == typeof(ulong))
            {
                ref var x = ref u32(dst8);
                ref readonly var y = ref u64(src);
                seek(x,0) = (uint)y;
                return dst;
            }
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitBlock64 init<T>(W64 w, in T src)
            where T : unmanaged
        {
            var x = z.vbroadcast(w128, uint8(src));
            vstore(x, ref alloc(out BitBlock128 dst));
            return @as<BitBlock128,BitBlock64>(dst);
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitBlock128 init<T>(W128 w, in T src)
            where T : unmanaged
        {
            var x = z.vbroadcast(w, uint8(src));
            vstore(x, ref alloc(out BitBlock128 dst));
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitBlock256 init<T>(W256 w, in T src)
            where T : unmanaged
        {
            var x = z.vbroadcast(w, uint8(src));
            vstore(x, ref alloc(out BitBlock256 dst));
            return dst;
        }
    }
}