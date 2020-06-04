//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

    public class OpCodeAttribute : Attribute
    {
        public string Expression {get;}

        public string Instruction {get;}

        public string Description {get;}

        public OpCodeAttribute(string expression, string instruction, string description)
        {
            Expression = expression;
            Instruction = instruction;
            Description = description;
        }       
    }
}