//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;

     public abstract class AsmShell<S> : Shell<S,IAsmContext>
        where S : AsmShell<S>, new()
    {
        static IAsmContext CreateContext()
        {
            var settings = AppSettings.Load(AppPaths.AppConfigPath);
            var exchange = AppMsgExchange.Create();
            var composed = ApiComposition.Assemble(KnownParts.Where(r => r.Id != 0));
            return AsmContext.Create(settings, exchange, composed, Env.Current.LogDir);
        }

        protected AsmShell()
            : base(CreateContext())
        {

        }
    }   
}