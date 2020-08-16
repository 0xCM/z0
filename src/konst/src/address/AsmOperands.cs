//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines an operand index
    /// </summary>
    public readonly struct AsmOperands : IAsmOperands
    {
        public IAsmOperand[] Args {get;}

        [MethodImpl(Inline)]
        public AsmOperands(params IAsmOperand[] args)
            => Args = args;
    }
}