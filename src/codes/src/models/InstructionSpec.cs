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
    
    public readonly struct InstructionSpec
    {        
        public static InstructionSpec Empty => new InstructionSpec(InstructionExpression.Empty);        
        
        readonly InstructionExpression Source;

        [MethodImpl(Inline)]
        public InstructionSpec(InstructionExpression src)
        {
            Source = src;
        }
    }
}