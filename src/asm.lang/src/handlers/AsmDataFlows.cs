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
    using static AsmExpr;

    public class AsmDataFlows : WfService<AsmDataFlows>
    {
        public void Submit(in AsmForm src)
        {

        }
        public class MovHandler : AsmHandler<MovHandler, Mov>
        {
            public override void Handle(Mov instruction)
            {

            }
        }

        public class MovzxHandler : AsmHandler<MovzxHandler, Movzx>
        {
            public override void Handle(Movzx instruction)
            {

            }
        }

        public class CmpHandler : AsmHandler<CmpHandler, Cmp>
        {
            public override void Handle(Cmp instruction)
            {

            }
        }

        public class JaHandler : AsmHandler<JaHandler, Ja>
        {
            public override void Handle(Ja instruction)
            {

            }
        }
    }
}