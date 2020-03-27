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
        
        public static IApiPart[] DefaultResolutions 
            => new IApiPart[]{
                R.Analogs.Resolution, R.AsmCore.Resolution, R.BitCore.Resolution,
                R.BitGrids.Resolution, R.BitSpan.Resolution, R.BitFields.Resolution,
                R.BitVectors.Resolution, R.VBits.Resolution, R.Permute.Resolution,
                R.Blocks.Resolution, R.Math.Resolution,
                R.GenericNumerics.Resolution, R.MathServices.Resolution, R.Intrinsics.Resolution,
                R.VSvc.Resolution, R.LibM.Resolution, R.Logix.Resolution, 
                R.Root.Resolution,R.Vectorized.Resolution}
                ;        
        public t_asm()
        {
            Context =  AsmContext.Create(ApiComposition.Assemble(DefaultResolutions), AppSettings.Empty, AppMsgExchange.Create(Queue), Random, AsmFormatConfig.New);
        }
    }
}
