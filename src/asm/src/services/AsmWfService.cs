//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    public abstract class AsmWfService<H> : WfService<H>
        where H : AsmWfService<H>, new()
    {
        protected override void OnInit()
        {
            OnContextCreated();
        }


        protected virtual void OnContextCreated()
        {

        }
    }
}