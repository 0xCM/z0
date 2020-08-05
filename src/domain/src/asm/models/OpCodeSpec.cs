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
    public readonly struct OpCodeSpec
    {                
        public readonly OpCodeExpression Expression;

        public readonly OpCodePart[] Parts;

        [MethodImpl(Inline)]
        public OpCodeSpec(OpCodeExpression expression, params OpCodePart[] parts)
        {
            Expression = expression;
            Parts = parts;
        }        

        public static OpCodeSpec Empty 
        {
            [MethodImpl(Inline)]
            get => new OpCodeSpec (new OpCodeExpression(default));
        }
    }
}