//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Asm;

    using static Part;
    using static memory;

    public class AsmTraversers : WfService<AsmTraversers>
    {

        public void Run()
        {
            var blocks = Wf.ApiHex().ApiBlocks();
            var r1 = R1.create(Wf);
            var traverser = Wf.ApiCodeBlockTraverser();
            traverser.Traverse(blocks,r1);
        }


        class R1 : WfService<R1>,  IReceiver<ApiCodeBlock,AsmInstructionBlock>
        {
            public void Deposit(in ApiCodeBlock a, in AsmInstructionBlock b)
            {
                var instructions = b.Instructions;
                var icount = instructions.Length;
                for(var i=0; i<icount; i++)
                {
                    ref readonly var fx = ref skip(instructions,i);

                }
            }

        }


    }

}