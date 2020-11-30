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

    partial class SpannedBits
    {
        [MethodImpl(Inline), Op]
        public static BitSpan32 from32(byte src)
        {
            var buffer = StackStores.alloc(w64);
            ref var tmp = ref StackStores.head<byte>(ref buffer);

            var storage = StackStores.alloc(w256);
            ref var target = ref StackStores.head<uint>(ref storage);

            Bits.unpack1x8x8(src, ref tmp);
            distribute32(tmp, 0, ref target);
            return BitSpans.load32(StackStores.span<uint>(ref storage).Cast<Bit32>());
        }

        [MethodImpl(Inline), Op]
        public static BitSpan32 from32(ushort src)
        {
            var buffer = StackStores.alloc(w128);
            ref var tmp = ref StackStores.head<byte>(ref buffer);

            var storage = StackStores.alloc(w512);
            ref var target = ref StackStores.head<uint>(ref storage);

            Bits.unpack1x8x16(src, ref tmp);
            distribute32(tmp, 0, ref target);
            distribute32(tmp, 1, ref target);
            return BitSpans.load32(StackStores.span<uint>(ref storage).Cast<Bit32>());
        }

        [MethodImpl(Inline), Op]
        public static BitSpan32 from32(uint src)
        {
            var buffer = StackStores.alloc(w256);
            ref var tmp = ref StackStores.head<byte>(ref buffer);

            var storage = StackStores.alloc(w1024);
            ref var target = ref StackStores.head<uint>(ref storage);

            Bits.unpack1x8x32(src, ref tmp);
            distribute32(tmp, 0, ref target);
            distribute32(tmp, 1, ref target);
            distribute32(tmp, 2, ref target);
            distribute32(tmp, 3, ref target);
            return BitSpans.load32(StackStores.span<uint>(ref storage).Cast<Bit32>());
        }

        [MethodImpl(Inline), Op]
        public static BitSpan32 from32(ulong src)
        {
            var buffer = StackStores.alloc(w512);
            ref var tmp = ref StackStores.head<byte>(ref buffer);

            Span<uint> storage = new uint[64];
            ref var target = ref first(storage);

            Bits.unpack1x8x64(src, ref tmp);
            distribute32(tmp, 0, ref target);
            distribute32(tmp, 1, ref target);
            distribute32(tmp, 2, ref target);
            distribute32(tmp, 3, ref target);
            distribute32(tmp, 4, ref target);
            distribute32(tmp, 5, ref target);
            distribute32(tmp, 6, ref target);
            distribute32(tmp, 7, ref target);
            return BitSpans.load32(storage.Cast<Bit32>());
        }
    }
}