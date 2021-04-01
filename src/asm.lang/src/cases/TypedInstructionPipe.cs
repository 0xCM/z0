//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public class TypedInstructionPipe : WfService<TypedInstructionPipe>
    {
        AsmStatementBuilder Builder;

        Index<IAsmInstruction> UntypedModels;

        public TypedInstructionPipe()
        {
            Builder = new();

        }

        protected override void OnInit()
        {
            var src = Builder.GetType();
            var factories = src.InstanceMethods().WithArity(1);
        }




        //public Aaa aaa(AsmHexCode encoded) => new Aaa(encoded);
    }
}