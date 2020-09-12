//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    public readonly struct AsmFxFlow : IAsmFxFlow
    {
        readonly AsmFxList[] FxList;

        readonly AsmTriggerSet Triggers;

        readonly AsmFxHandler[] FxHandlers;

        [MethodImpl(Inline)]
        public AsmFxFlow(AsmFxList[] fxList, in AsmTriggerSet triggers, params AsmFxHandler[] handlers)
        {
            FxList  = fxList;
            Triggers = triggers;
            FxHandlers = handlers;
        }

        public AsmFxList[] Push(IAsmFxPipe pipe)
        {
            var count = FxList.Length;
            var buffer = alloc<AsmFxList>(count);
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