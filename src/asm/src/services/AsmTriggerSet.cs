//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using FT = IAsmFunctionTrigger;
    using IT = IInstructionTrigger;

    public readonly struct AsmTriggerSet : IAsmTriggerSet, INullary<AsmTriggerSet>
    {
        readonly IT[] ITriggers;

        readonly FT[] FTriggers;

        public static AsmTriggerSet Empty 
            => Define(array<FT>(), array<IT>());
                    
        [MethodImpl(Inline)]
        public static AsmTriggerSet Define(FT[] fTriggers, IT[] iTriggers)
            => new AsmTriggerSet(fTriggers, iTriggers);

        [MethodImpl(Inline)]
        public static AsmTriggerSet Define(params IT[] iTriggers)
            => new AsmTriggerSet(array<IAsmFunctionTrigger>(), iTriggers);

        [MethodImpl(Inline)]
        AsmTriggerSet(FT[] fTriggers, IT[] iTriggers)
        {
            FTriggers = fTriggers;
            ITriggers = iTriggers;
        }
        
        public bool IsEmpty 
            => ITriggers.Length == 0 && FTriggers.Length == 0;
        
        AsmTriggerSet INullary<AsmTriggerSet>.Zero 
            => Empty;

        [MethodImpl(Inline)]
        void FireOnMatch(IT trigger, in AsmInstructionList list)
        {
            var src = span(list.Data);
            for(var i=0; i<src.Length; i++)
                trigger.FireOnMatch(skip(src,i));
        }

        [MethodImpl(Inline)]
        void FireOnMatch(FT trigger, in AsmFunction function)
            => trigger.FireOnMatch(function);

        [MethodImpl(Inline)]
        public void FireOnMatch(in AsmInstructionList list)
        {
            var src = span(ITriggers);
            for(var i=0; i<src.Length; i++)
                FireOnMatch(skip(src,i), list);
        }

        [MethodImpl(Inline)]
        public void FireOnMatch(in AsmFunction f)
        {
            var src = span(FTriggers);
            var count = src.Length;
            for(var i=0; i<count; i++)
                FireOnMatch(skip(src,i), f);                                
        }
    }
}