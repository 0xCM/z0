//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    /// <summary>
    /// Defines a componentized opcode and carries opcode expression from whence they came
    /// </summary>
    public readonly struct AsmOpCodeParts
    {                
        public readonly AsmOpCode Expression;

        public readonly AsmOpCodePart[] Parts;

        [MethodImpl(Inline)]
        public AsmOpCodeParts(AsmOpCode expression, params AsmOpCodePart[] parts)
        {
            Expression = expression;
            Parts = parts;
        }                    
    }
}