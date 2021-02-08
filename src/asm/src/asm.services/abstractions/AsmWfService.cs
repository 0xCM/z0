//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public abstract class AsmWfService<H> : WfService<H,H>
        where H : AsmWfService<H>, new()
    {
        protected IAsmWf AsmWf {get; private set;}

        protected AsmServices Services {get; private set;}

        protected override void OnInit()
        {
            AsmWf = AsmWorkflows.create(Wf);
            Services = AsmServices.init(Wf, AsmWf.Asm);
        }

        protected IAsmContext Asm => AsmWf.Asm;

        protected IAsmDecoder Decoder => Asm.RoutineDecoder;
    }
}