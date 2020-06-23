//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    partial class SpannedBits
    {
        [MethodImpl(Inline), Op]
        public static ref readonly BitSpan fill(byte src, in BitSpan dst)
        {
            var buffer = Stacks.alloc(w64);
            ref var tmp = ref Stacks.head<byte>(ref buffer);
            ref var target = ref Unsafe.As<bit,uint>(ref head(dst.Bits));

            BitPack.unpack(src, ref tmp); 
            distribute(in tmp, 0, ref target);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref readonly BitSpan fill(ushort src, in BitSpan dst)
        {
            var buffer = Stacks.alloc(w128);
            ref var tmp = ref Stacks.head<byte>(ref buffer);
            ref var target = ref Unsafe.As<bit,uint>(ref head(dst.Bits));

            BitPack.unpack(src, ref tmp); 
            distribute(in tmp, 0, ref target);
            distribute(in tmp, 1, ref target);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref readonly BitSpan fill(uint src, in BitSpan dst)
        {
            ref var tmp = ref head(dst.Bits.Slice(24,8).Cast<bit,byte>());
            ref var target = ref Unsafe.As<bit,uint>(ref head(dst.Bits));

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
            var buffer = Stacks.alloc(w512);        
            ref var tmp = ref head(dst.Bits.Slice(56,8).Cast<bit,byte>());
            ref var target = ref Unsafe.As<bit,uint>(ref head(dst.Bits));

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