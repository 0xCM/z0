//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmPipe : IAsmPipe
    {
        readonly Func<AsmFxList,AsmFxList> F;

        [MethodImpl(Inline)]
        public AsmPipe(Func<AsmFxList,AsmFxList> f)
            => F = f;

        [MethodImpl(Inline)]
        public AsmFxList Flow(in AsmFxList fxList)
            => F(fxList);
    }
}