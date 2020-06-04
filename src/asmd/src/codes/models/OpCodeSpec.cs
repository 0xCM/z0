//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
    
    public readonly struct OpCodeSpec
    {        
        public static OpCodeSpec Empty => new OpCodeSpec(OpCodeExpression.Empty);
        
        public OpCodeExpression Source {get;}

        public OpCodePart[] Components {get;}

        [MethodImpl(Inline)]
        public OpCodeSpec(OpCodeExpression expression, params OpCodePart[] components)
        {
            Source = expression;
            Components = components;
        }        
    }
}