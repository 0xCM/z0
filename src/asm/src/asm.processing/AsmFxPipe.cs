//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmPipe : IAsmPipe
    {
        readonly Func<IceInstructionList,IceInstructionList> F;

        [MethodImpl(Inline)]
        public AsmPipe(Func<IceInstructionList,IceInstructionList> f)
            => F = f;

        [MethodImpl(Inline)]
        public IceInstructionList Flow(in IceInstructionList fxList)
            => F(fxList);
    }
}