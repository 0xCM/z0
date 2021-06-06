//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Typed;
    using static core;

    [ApiHost]
    public struct AsmLayouts
    {
        [MethodImpl(Inline), Op]
        public static AsmLayout define(params AsmLayoutSlot[] slots)
        {
            var count = slots.Length;
            var storage = Cells.alloc(w128);
            var buffer = storage.Bytes;
            seek(buffer, AsmLayout.MaxSlotCount) = (byte)count;
            var dst = recover<AsmLayoutSlot>(buffer);
            var src = @readonly(slots);
            for(var i=0; i<count; i++)
                seek(dst,i) = skip(src,i);
            return new AsmLayout(storage);
        }

        [MethodImpl(Inline), Op]
        public static AsmLayout init()
            => new AsmLayout(Cell128.Empty);
    }
}