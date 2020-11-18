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
        public static ref readonly BitSpan fill(byte src, in BitSpan dst)
        {
            var buffer = StackStores.alloc(w64);
            ref var tmp = ref StackStores.head<byte>(ref buffer);
            ref var target = ref Unsafe.As<Bit32,uint>(ref first(dst.Edit));

            BitPack.unpack(src, ref tmp);
            distribute(in tmp, 0, ref target);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref readonly BitSpan fill(ushort src, in BitSpan dst)
        {
            var buffer = StackStores.alloc(w128);
            ref var tmp = ref StackStores.head<byte>(ref buffer);
            ref var target = ref Unsafe.As<Bit32,uint>(ref first(dst.Edit));

            BitPack.unpack(src, ref tmp);
            distribute(in tmp, 0, ref target);
            distribute(in tmp, 1, ref target);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref readonly BitSpan fill(uint src, in BitSpan dst)
        {
            ref var tmp = ref first(dst.Edit.Slice(24,8).Cast<Bit32,byte>());
            ref var target = ref Unsafe.As<Bit32,uint>(ref first(dst.Edit));

            BitPack.unpack(src, ref tmp);
            distribute(in tmp, 0, ref target);
            distribute(in tmp, 1, ref target);
            distribute(in tmp, 2, ref target);
            distribute(in tmp, 3, ref target);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref readonly BitSpan fill(ulong src, in BitSpan dst)
        {
            var buffer = StackStores.alloc(w512);
            ref var tmp = ref first(dst.Edit.Slice(56,8).Cast<Bit32,byte>());
            ref var target = ref Unsafe.As<Bit32,uint>(ref first(dst.Edit));

            BitPack.unpack((uint)src, ref tmp);
            distribute(in tmp, 0, ref target, 0);
            distribute(in tmp, 1, ref target, 1);
            distribute(in tmp, 2, ref target, 2);
            distribute(in tmp, 3, ref target, 3);

            BitPack.unpack((uint)(src >> 32), ref tmp);
            distribute(in tmp, 0, ref target, 4);
            distribute(in tmp, 1, ref target, 5);
            distribute(in tmp, 2, ref target, 6);
            distribute(in tmp, 3, ref target, 7);
            return ref dst;
        }
    }
}