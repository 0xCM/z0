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
    using static Root;

    public readonly struct AsmInstructionFlow : IAsmInstructionFlow
    {        
        readonly AsmInstructionList[] DataSource;

        readonly AsmTriggerSet Triggers;

        readonly InstructionHandler[] Handlers;                

        [MethodImpl(Inline)]
        public static IAsmInstructionFlow Create(AsmInstructionList[] inxs, in AsmTriggerSet triggers, params InstructionHandler[] handlers)
            => new AsmInstructionFlow(inxs, triggers, handlers);

        [MethodImpl(Inline)]
        AsmInstructionFlow(AsmInstructionList[] inxs, in AsmTriggerSet triggers, params InstructionHandler[] handlers)
        {
            DataSource  = inxs;
            Triggers = triggers;
            Handlers = handlers;
        }

        int SourceCount
        {
            [MethodImpl(Inline)]
            get => DataSource.Length;
        }
        
        public IEnumerable<AsmInstructionList> Flow(IInstructionPipe pipe)
        {
            for(var i=0; i<SourceCount; i++)
            {
                Triggers.FireOnMatch(DataSource[i]);
                yield return pipe.Flow(DataSource[i]);
            }
        }    

        public AsmInstructionList[] Push(IInstructionPipe pipe)   
        {
            var buffer = alloc<AsmInstructionList>(SourceCount);
            var dst = buffer.ToSpan();
            var src = DataSource.ToReadOnlySpan();
            
            for(var i=0; i<SourceCount; i++)
            {
                ref readonly var item = ref skip(src,i);
                
                Triggers.FireOnMatch(item);
                seek(dst,i) = pipe.Flow(item);

                for(var j = 0; j<item.Length; j++)
                for(var h = 0; h<Handlers.Length; h++)
                    Handlers[h](item[j]);
            }
            return buffer;
        }
    }
}