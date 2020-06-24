//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
     public abstract class AsmShell<S> : Shell<S,IAsmContext>
        where S : AsmShell<S>, new()
    {
        protected AsmShell()
            : base(AsmContext.Create(AppMsgExchange.Create()))
        {

        }
    }   
}