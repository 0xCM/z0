//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using Z0.Asm;

    using static Konst;
    using static z;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static DataFlow<Vector128<byte>,EncodedFx> flow(Vector128<byte> src, out EncodedFx dst)
        {
            dst = asm.encoded(src);
            return new DataFlow<Vector128<byte>, EncodedFx>(src, dst);
        }

        [MethodImpl(Inline), Op]
        public static AsmFxFlow flow(AsmFxList[] fxList, in AsmTriggerSet triggers, params AsmFxHandler[] handlers)
            => new AsmFxFlow(fxList, triggers, handlers);
    }
}