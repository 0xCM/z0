//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    
    using static Root;
    using R = Z0.Resolutions;

    static class AsmCompostionRoot
    {
        static IEnumerable<IAssemblyResolution> DefaultResolutions 
            => new IAssemblyResolution[]{
                R.Analogs.Resolution, R.AsmCore.Resolution, R.BitCore.Resolution,
                R.BitGrids.Resolution, R.BitSpan.Resolution, R.BitFields.Resolution,
                R.BitVectors.Resolution, R.VBits.Resolution, R.Permute.Resolution,
                R.Blocks.Resolution, R.Fixed.Resolution, R.Math.Resolution,
                R.GMath.Resolution, R.MathServices.Resolution, R.Intrinsics.Resolution,
                R.IntrinsicsSvc.Resolution, R.LibM.Resolution, R.Logix.Resolution, 
                R.Root.Resolution,R.Vectorized.Resolution}
                ;

        public static IAssemblyComposition Compose(params IAssemblyResolution[] src)
        {
            var resolutions = src.Length != 0 ? src : DefaultResolutions;
            return resolutions.Assemble();
        }

        public static IAsmContext RootedComposition(this IAsmContext context, params IAssemblyResolution[] resolutions)
            => AsmContext.Rooted(context, Compose(resolutions));
    }
}