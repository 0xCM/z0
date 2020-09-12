//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using FT = IAsmRoutineTrigger;
    using IT = IAsmFxTrigger;

    public readonly struct AsmTriggerSet : INullary<AsmTriggerSet>
    {
        readonly IT[] ITriggers;

        readonly FT[] FTriggers;

        [MethodImpl(Inline)]
        public AsmTriggerSet(FT[] fTriggers, IT[] iTriggers)
        {
            FTriggers = fTriggers;
            ITriggers = iTriggers;
        }

        public bool IsEmpty
            => ITriggers.Length == 0 && FTriggers.Length == 0;

        public AsmTriggerSet Zero
            => Empty;

        [MethodImpl(Inline)]
        void FireOnMatch(IT trigger, in AsmFxList list)
        {
            var src = span(list.Data);
            for(var i=0; i<src.Length; i++)
                trigger.FireOnMatch(skip(src,i));
        }

        [MethodImpl(Inline)]
        void FireOnMatch(FT trigger, in AsmRoutine function)
            => trigger.FireOnMatch(function);

        [MethodImpl(Inline)]
        public void FireOnMatch(in AsmFxList list)
        {
            var src = span(ITriggers);
            for(var i=0; i<src.Length; i++)
                FireOnMatch(skip(src,i), list);
        }

        [MethodImpl(Inline)]
        public void FireOnMatch(in AsmRoutine f)
        {
            var src = span(FTriggers);
            var count = src.Length;
            for(var i=0; i<count; i++)
                FireOnMatch(skip(src,i), f);
        }

        public static AsmTriggerSet Empty
            => asm.triggers(array<FT>(), array<IT>());
    }
}