//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using llvm;

    using static Root;

    public readonly struct AsmForm
    {
        public AsmSig Sig {get;}

        public AsmOpCode OpCode {get;}

        [MethodImpl(Inline)]
        public AsmForm(in AsmSig sig, in AsmOpCode oc)
        {
            Sig = sig;
            OpCode = oc;
        }

        public McAsmId AsmId
        {
            [MethodImpl(Inline)]
            get => OpCode.AsmId;
        }

        public string Format()
            => string.Format("{0} = {1}", Sig, OpCode);

        public override string ToString()
            => Format();
    }
}