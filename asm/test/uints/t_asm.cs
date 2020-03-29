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
                R.AsmCore.Resolved, R.BitCore.Resolved,
                R.BitGrids.Resolved, R.BitSpan.Resolved, R.BitFields.Resolved,
                R.BitVectors.Resolved, R.VBits.Resolved, R.Permute.Resolved,
                R.Blocks.Resolved, R.Math.Resolved,
                R.GMath.Resolved, R.MathServices.Resolved, R.Intrinsics.Resolved,
                R.VSvc.Resolved, R.LibM.Resolved, R.Logix.Resolved, 
                R.Root.Resolved,R.Vectorized.Resolved}
                ;        
        public t_asm()
        {
            Context =  AsmContext.Create(ApiComposition.Assemble(DefaultResolutions), AppSettings.Empty, AppMsgExchange.Create(Queue), Random, AsmFormatConfig.New);
        }
    }
}
