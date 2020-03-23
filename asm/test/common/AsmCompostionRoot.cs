//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    
    using R = Z0.Parts;

    static class AsmCompostionRoot
    {
        static IEnumerable<IApiPart> DefaultResolutions 
            => new IApiPart[]{
                R.Analogs.Resolution, R.AsmCore.Resolution, R.BitCore.Resolution,
                R.BitGrids.Resolution, R.BitSpan.Resolution, R.BitFields.Resolution,
                R.BitVectors.Resolution, R.VBits.Resolution, R.Permute.Resolution,
                R.Blocks.Resolution, R.Fixed.Resolution, R.Math.Resolution,
                R.GenericNumerics.Resolution, R.MathServices.Resolution, R.Intrinsics.Resolution,
                R.VSvc.Resolution, R.LibM.Resolution, R.Logix.Resolution, 
                R.Root.Resolution,R.Vectorized.Resolution}
                ;

        public static IApiComposition Compose(params IApiPart[] src)
        {
            var resolutions = src.Length != 0 ? src : DefaultResolutions;
            return resolutions.Assemble();
        }
    }
}