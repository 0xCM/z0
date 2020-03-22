//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Asm;

    public abstract class t_asm<U> : UnitTest<U>
        where U : t_asm<U>
    {
        protected new IAsmContext Context;
        
        public t_asm()
        {
            Context =  AsmContext.Create(AsmCompostionRoot.Compose(), AppSettings.Empty, AppMsgExchange.Create(Queue), Random, AsmFormatConfig.New);
        }
    }
}
