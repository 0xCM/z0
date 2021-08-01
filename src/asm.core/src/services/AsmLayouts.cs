//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    [ApiHost]
    public readonly partial struct AsmLayouts
    {
        [MethodImpl(Inline), Op]
        public static LayoutSpec specify(params Slot[] slots)
        {
            var count = slots.Length;
            var storage = Cells.alloc(w128);
            var buffer = storage.Bytes;
            seek(buffer, LayoutSpec.MaxSlotCount) = (byte)count;
            var dst = recover<Slot>(buffer);
            var src = @readonly(slots);
            for(var i=0; i<count; i++)
                seek(dst,i) = skip(src,i);
            return new LayoutSpec(storage);
        }
    }
}