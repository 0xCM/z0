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
        protected override void OnInit()
        {
            Asm = AsmServices.context(Wf);
        }

        protected IAsmContext Asm {get; private set;}
    }
}