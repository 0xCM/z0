//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

     public abstract class AsmShell<S> : Shell<S,IAsmContext>
        where S : AsmShell<S>, new()
    {
        static IAsmContext CreateContext()
        {
            var settings = AppSettings.Load(AppPaths.AppConfigPath);
            var exchange = AppMessages.exchange();
            var resolved = ApiComposition.Assemble(KnownParts.Where(r => r.Id != 0));

            var context = AsmContext.Create(settings, exchange, resolved, Env.Current.LogDir);
            return context;
        }

        protected AsmShell()
            : base(CreateContext())
        {

        }
    }   
}