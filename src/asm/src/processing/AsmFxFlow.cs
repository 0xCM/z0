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

        int SourceCount
        {
            [MethodImpl(Inline)]
            get => FxList.Length;
        }
        
        public IEnumerable<AsmFxList> Flow(IAsmFxPipe pipe)
        {
            for(var i=0; i<SourceCount; i++)
            {
                Triggers.FireOnMatch(FxList[i]);
                yield return pipe.Flow(FxList[i]);
            }
        }    

        public AsmFxList[] Push(IAsmFxPipe pipe)   
        {
            var buffer = alloc<AsmFxList>(SourceCount);
            var dst = buffer.ToSpan();
            var src = FxList.ToReadOnlySpan();
            
            for(var i=0u; i<SourceCount; i++)
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