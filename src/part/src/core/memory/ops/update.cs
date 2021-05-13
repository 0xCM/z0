//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct memory
    {
        public static void update<E,T>(ReadOnlySpan<BinaryCode> src, MemorySlots<E> slots, T dst)
            where E : unmanaged
        {
            var count = slots.Length;
            ref readonly var lead = ref slots.Lookup(default(E));
            for(var i=0u; i<count; i++)
            {
                ref readonly var code = ref skip(src,i);
                ref readonly var source = ref code[0];
                ref readonly var slot = ref skip(lead, i);
                ref var target = ref slot.BaseAddress.Ref<byte>();
                for(var j=0u; j<slot.Length; j++)
                    seek(target,j) = skip(source,j);
            }
        }
    }
}