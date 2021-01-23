//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    partial class MemoryStacks
    {
        [MethodImpl(Inline), Op]
        public static StackBlock32 init(Vector256<ushort> lo, Vector256<ushort> hi)
        {
            var src = new Seg512(lo,hi);
            var dst = alloc(w8, n32);
            copy(z.bytes(src), ref dst);
            return dst;
        }

        readonly struct Seg512
        {
            readonly Vector256<ushort> Lo;

            readonly Vector256<ushort> Hi;

            [MethodImpl(Inline), Op]
            public Seg512(Vector256<ushort> lo, Vector256<ushort> hi)
            {
                Lo = lo;
                Hi = hi;
            }
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitBlock32 init<T>(in T src, W32 w)
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

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitBlock64 init<T>(in T src, W64 w)
            where T : unmanaged
        {
            var x = cpu.vbroadcast(w128, uint8(src));
            cpu.vstore(x, ref alloc(out BitBlock128 dst));
            return @as<BitBlock128,BitBlock64>(dst);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitBlock128 init<T>(in T src, W128 w)
            where T : unmanaged
        {
            var x = cpu.vbroadcast(w, uint8(src));
            cpu.vstore(x, ref alloc(out BitBlock128 dst));
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitBlock256 init<T>(in T src, W256 w)
            where T : unmanaged
        {
            var x = cpu.vbroadcast(w, uint8(src));
            cpu.vstore(x, ref alloc(out BitBlock256 dst));
            return dst;
        }
    }
}