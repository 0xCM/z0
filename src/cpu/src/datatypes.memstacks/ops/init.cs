//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static memory;

    partial class MemBlocks
    {
        [MethodImpl(Inline), Op]
        public static MemBlock32 init(Vector256<ushort> lo, Vector256<ushort> hi)
        {
            var src = new Seg512(lo,hi);
            var dst = alloc(n32);
            copy(bytes(src), ref dst);
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
        public static MemBlock4 init<T>(in T src, W32 w)
            where T : unmanaged
        {
            ref var dst8 = ref alloc(out MemBlock4 dst);
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
        public static MemBlock8 init<T>(in T src, W64 w)
            where T : unmanaged
        {
            var x = vbroadcast(w128, uint8(src));
            vstore(x, ref alloc(out MemBlock16 dst));
            return @as<MemBlock16,MemBlock8>(dst);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static MemBlock16 init<T>(in T src, W128 w)
            where T : unmanaged
        {
            var x = vbroadcast(w, uint8(src));
            vstore(x, ref alloc(out MemBlock16 dst));
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static MemBlock32 init<T>(in T src, W256 w)
            where T : unmanaged
        {
            var x = vbroadcast(w, uint8(src));
            vstore(x, ref alloc(out MemBlock32 dst));
            return dst;
        }
    }
}