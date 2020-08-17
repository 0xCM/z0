//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmFxPipe : IAsmFxPipe
    {
        readonly Func<AsmFxList,AsmFxList> F;

        [MethodImpl(Inline)]
        public AsmFxPipe(Func<AsmFxList,AsmFxList> f)
            => F = f;

        [MethodImpl(Inline)]
        public AsmFxList Flow(in AsmFxList fxList)
            => F(fxList);
    }
}