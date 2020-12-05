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
        public static ref readonly BitSpan32 fill32(byte src, in BitSpan32 dst)
        {
            var buffer = MemoryStacks.alloc(w64);
            ref var tmp = ref MemoryStacks.head<byte>(ref buffer);
            ref var target = ref Unsafe.As<Bit32,uint>(ref first(dst.Edit));

            Bits.unpack1x8x8(src, ref tmp);
            distribute32(in tmp, 0, ref target);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref readonly BitSpan32 fill32(ushort src, in BitSpan32 dst)
        {
            var buffer = MemoryStacks.alloc(w128);
            ref var tmp = ref MemoryStacks.head<byte>(ref buffer);
            ref var target = ref Unsafe.As<Bit32,uint>(ref first(dst.Edit));

            Bits.unpack1x8x16(src, ref tmp);
            distribute32(in tmp, 0, ref target);
            distribute32(in tmp, 1, ref target);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref readonly BitSpan32 fill32(uint src, in BitSpan32 dst)
        {
            ref var tmp = ref first(dst.Edit.Slice(24,8).Cast<Bit32,byte>());
            ref var target = ref Unsafe.As<Bit32,uint>(ref first(dst.Edit));

            Bits.unpack1x8x32(src, ref tmp);
            distribute32(in tmp, 0, ref target);
            distribute32(in tmp, 1, ref target);
            distribute32(in tmp, 2, ref target);
            distribute32(in tmp, 3, ref target);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref readonly BitSpan32 fill32(ulong src, in BitSpan32 dst)
        {
            var buffer = MemoryStacks.alloc(w512);
            ref var tmp = ref first(dst.Edit.Slice(56,8).Cast<Bit32,byte>());
            ref var target = ref Unsafe.As<Bit32,uint>(ref first(dst.Edit));

            Bits.unpack1x8x32((uint)src, ref tmp);
            distribute32(in tmp, 0, ref target, 0);
            distribute32(in tmp, 1, ref target, 1);
            distribute32(in tmp, 2, ref target, 2);
            distribute32(in tmp, 3, ref target, 3);

            Bits.unpack1x8x32((uint)(src >> 32), ref tmp);
            distribute32(in tmp, 0, ref target, 4);
            distribute32(in tmp, 1, ref target, 5);
            distribute32(in tmp, 2, ref target, 6);
            distribute32(in tmp, 3, ref target, 7);
            return ref dst;
        }
    }
}