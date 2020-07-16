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
        public static BitSpan from(byte src)
        {
            var buffer = Stacks.alloc(w64);
            ref var tmp = ref Stacks.head<byte>(ref buffer);
            
            var storage = Stacks.alloc(w256);
            ref var target = ref Stacks.head<uint>(ref storage);

            BitPack.unpack(src, ref tmp); 
            distribute(tmp, 0, ref target);
            return BitSpans.load(Stacks.span<uint>(ref storage).Cast<bit>());
        }

        [MethodImpl(Inline), Op]
        public static BitSpan from(ushort src)
        {
            var buffer = Stacks.alloc(w128);
            ref var tmp = ref Stacks.head<byte>(ref buffer);

            var storage = Stacks.alloc(w512);
            ref var target = ref Stacks.head<uint>(ref storage);            
            
            BitPack.unpack(src, ref tmp); 
            distribute(tmp, 0, ref target);
            distribute(tmp, 1, ref target);
            return BitSpans.load(Stacks.span<uint>(ref storage).Cast<bit>());
        }

        [MethodImpl(Inline), Op]
        public static BitSpan from(uint src)
        {
            var buffer = Stacks.alloc(w256);
            ref var tmp = ref Stacks.head<byte>(ref buffer);

            var storage = Stacks.alloc(w1024);
            ref var target = ref Stacks.head<uint>(ref storage);            
            
            BitPack.unpack(src, ref tmp); 
            distribute(tmp, 0, ref target);
            distribute(tmp, 1, ref target);
            distribute(tmp, 2, ref target);
            distribute(tmp, 3, ref target);
            return BitSpans.load(Stacks.span<uint>(ref storage).Cast<bit>());
        }

        [MethodImpl(Inline), Op]
        public static BitSpan from(ulong src)
        {
            var buffer = Stacks.alloc(w512);
            ref var tmp = ref Stacks.head<byte>(ref buffer);

            Span<uint> storage = new uint[64];
            ref var target = ref first(storage);

            BitPack.unpack(src, ref tmp); 
            distribute(tmp, 0, ref target);
            distribute(tmp, 1, ref target);
            distribute(tmp, 2, ref target);
            distribute(tmp, 3, ref target);
            distribute(tmp, 4, ref target);
            distribute(tmp, 5, ref target);
            distribute(tmp, 6, ref target);
            distribute(tmp, 7, ref target);
            return BitSpans.load(storage.Cast<bit>());
        }             
    }
}