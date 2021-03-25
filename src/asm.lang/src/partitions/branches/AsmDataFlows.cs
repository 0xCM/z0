//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Part;
    using static AsmInstructions;

    public class AsmDataFlows : WfService<AsmDataFlows>
    {

        public void Submit(in AsmFormExpr src, AsmHexCode code)
        {

        }

        public class MovHandler : AsmHandler<MovHandler, Mov>
        {
            public override void Handle(Mov src)
            {

            }
        }

        public class JmpHandler : AsmHandler<JmpHandler, Jmp>
        {
            public override void Handle(Jmp src)
            {

            }
        }


        public class MovzxHandler : AsmHandler<MovzxHandler, Movzx>
        {
            public override void Handle(Movzx src)
            {

            }
        }

        public class CmpHandler : AsmHandler<CmpHandler, Cmp>
        {
            public override void Handle(Cmp src)
            {

            }
        }

        public class JaHandler : AsmHandler<JaHandler, Ja>
        {
            public override void Handle(Ja src)
            {

            }
        }

        public class JneHandler : AsmHandler<JneHandler, Jne>
        {
            public override void Handle(Jne src)
            {

            }
        }

        public class VmovdquHandler : AsmHandler<VmovdquHandler, Vmovdqu>
        {
            public override void Handle(Vmovdqu src)
            {

            }
        }

    }
}