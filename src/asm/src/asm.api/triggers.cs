//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using FT = Asm.IAsmRoutineTrigger;
    using IT = Asm.IAsmFxTrigger;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmTriggerSet triggers(FT[] rTriggers, IT[] fxTriggers)
            => new AsmTriggerSet(rTriggers, fxTriggers);

        [MethodImpl(Inline), Op]
        public static AsmTriggerSet triggers(params IT[] fxTriggers)
            => new AsmTriggerSet(array<IAsmRoutineTrigger>(), fxTriggers);
    }
}