//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    public readonly struct AsmFlow
    {
        readonly IceInstructionList[] FxList;

        readonly AsmTriggerSet Triggers;

        readonly AsmFxHandler[] FxHandlers;

        [MethodImpl(Inline)]
        public AsmFlow(IceInstructionList[] fxList, in AsmTriggerSet triggers, params AsmFxHandler[] handlers)
        {
            FxList  = fxList;
            Triggers = triggers;
            FxHandlers = handlers;
        }

        public IceInstructionList[] Push(IAsmPipe pipe)
        {
            var count = FxList.Length;
            var buffer = alloc<IceInstructionList>(count);
            var dst = buffer.ToSpan();
            var src = @readonly(FxList);

            for(var i=0u; i<count; i++)
            {
                ref readonly var item = ref skip(src,i);

                Triggers.FireOnMatch(item);
                seek(dst,i) = pipe.Flow(item);

                for(var j = 0; j<item.Length; j++)
                for(var h = 0; h<FxHandlers.Length; h++)
                    FxHandlers[h](item[j]);
            }
            return buffer;
        }
    }
}