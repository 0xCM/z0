//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using Strings;

    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".test-strings")]
        Outcome TestStrings(CmdArgs args)
        {
            var result = Outcome.Success;
            var count = 256u;
            var length = 8u;
            using var buffer = strings.buffer(count*length);
            var labels = core.alloc<Label>(count);
            for(uint i=0,j=0; i<256; i++,j+=length)
            {
                var s = BitRender.format8((byte)i);
                seek(labels,i) = buffer.StoreLabel(s,j);
            }

            for(var i=0; i<count; i++)
            {
                ref readonly var label = ref skip(labels,i);
                Write(label.Format());
            }
            return result;
        }

        [CmdOp(".test-alloc")]
        Outcome TestAllocator(CmdArgs args)
        {
            var result = Outcome.Success;
            var count = 256u;
            var length = 8u;
            using var buffer = strings.buffer(count*length);
            var allocator = LabelAllocator.create(buffer);
            var labels = core.alloc<Label>(count);
            for(uint i=0; i<256; i++)
            {
                var s = BitRender.format8((byte)i);
                if(!allocator.Dispense(s, out seek(labels,i)))
                {
                    Error("eh?");
                }
            }

            for(var i=0; i<count; i++)
            {
                ref readonly var label = ref skip(labels,i);
                Write(label.Format());
            }

            return result;
        }

   }
}