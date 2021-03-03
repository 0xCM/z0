//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Specifies an instruction definition
    /// </summary>
    public readonly struct IntructionVariant
    {
        public AsmOpCode OpCode {get;}

        public AsmSig Sig {get;}

        [MethodImpl(Inline)]
        public IntructionVariant(AsmOpCode oc, AsmSig sig)
        {
            OpCode = oc;
            Sig = sig;
        }
    }
}