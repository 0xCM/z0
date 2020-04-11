//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;

    using R = Z0.Parts;

    public abstract class t_asm<U> : UnitTest<U>
        where U : t_asm<U>
    {
        protected new IAsmContext Context;
        
        public static IPart[] DefaultResolutions 
            => new IPart[]{
                R.Blocks.Resolved, 
                R.Math.Resolved,
                R.Vectors.Resolved,
                R.GMath.Resolved,
                R.Cast.Resolved
                }
                ;        
        public t_asm()
        {
            Context = AsmContext.Create(
                ApiComposition.Assemble(DefaultResolutions), 
                AppSettings.Empty, 
                AppMessages.exchange(Queue), 
                Random, 
                AsmFormatConfig.New,
                Context.AsmFormatter(),
                Context.AsmFunctionDecoder(),
                Context.AsmWriterFactory()
                );
        }
    }
}
