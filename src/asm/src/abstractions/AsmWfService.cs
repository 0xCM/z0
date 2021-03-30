//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public abstract class AsmWfService<H> : WfService<H>
        where H : AsmWfService<H>, new()
    {
        protected override void OnInit()
        {
            Asm = Wf.AsmContext();
            _Etl = root.lazy(Wf.AsmRowEtl);
            OnContextCreated();
        }

        protected IAsmContext Asm {get; private set;}

        Lazy<AsmEtl> _Etl;

        protected AsmEtl Etl => _Etl.Value;

        protected virtual void OnContextCreated()
        {

        }
    }
}