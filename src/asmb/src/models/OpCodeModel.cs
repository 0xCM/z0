//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct OpCodeModel : IIdentified<OpCodeIdentifier>
    {
        public OpCodeIdentifier Id {get;}
        
        public OpCodeExpression Expression {get;}

        public InstructionExpression Instruction {get;}

        public OpCodeDescription Description {get;}

        [MethodImpl(Inline)]
        public static implicit operator OpCodeModel((string id, string ocx, string ix, string description) src)
            => new OpCodeModel(src.id, src.ocx, src.ix, src.description);

        [MethodImpl(Inline)]
        public OpCodeModel(string id, string ocx, string ix, string dx)
        {
            Id = id;
            Expression = ocx;
            Instruction = ix;
            Description = dx;
        }    

        [MethodImpl(Inline)]
        public OpCodeModel(OpCodeIdentifier id, OpCodeExpression cx, InstructionExpression ix, OpCodeDescription dx)
        {
            Id = id;
            Expression = cx;
            Instruction = ix;
            Description = dx;
        }    
    }
}