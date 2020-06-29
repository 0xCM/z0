//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    /// <summary>
    /// Defines a componentized opcode and carries opcode expression from whence they came
    /// </summary>
    public readonly struct OpCodeSpec
    {                
        public readonly OpCodeExpression Source;

        public readonly OpCodePart[] Components;

        [MethodImpl(Inline)]
        public OpCodeSpec(OpCodeExpression expression, params OpCodePart[] components)
        {
            Source = expression;
            Components = components;
        }        

        public static OpCodeSpec Empty 
            => new OpCodeSpec(OpCodeExpression.Empty);
    }
}