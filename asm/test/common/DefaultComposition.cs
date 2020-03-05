//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using static Root;
    using R = Z0.Resolutions;

    public readonly struct DefaultComposition : IAssemblyComposition<DefaultComposition>
    {
        static IEnumerable<IAssemblyResolution> Assemblies => items<IAssemblyResolution>(
                R.Analogs.Resolution,
                R.AsmCore.Resolution,
                R.BitCore.Resolution,
                R.BitGrids.Resolution,
                R.BitSpan.Resolution,
                R.BitFields.Resolution,
                R.BitVectors.Resolution,
                R.CoreFunc.Resolution,
                R.Blocks.Resolution,
                R.Fixed.Resolution,
                R.Math.Resolution,
                R.GMath.Resolution,
                R.GMathSvc.Resolution,
                R.Intrinsics.Resolution,
                R.LibM.Resolution,
                R.Logix.Resolution,
                R.Root.Resolution,
                R.Vectorized.Resolution);

        [MethodImpl(Inline)]
        public static IAssemblyComposition Create()
            => new DefaultComposition(Assemblies);

        [MethodImpl(Inline)]
        DefaultComposition(IEnumerable<IAssemblyResolution> resolutions)
            => Resolved = resolutions.ToArray();

        /// <summary>
        /// The resolved assemblies that comprise the composition
        /// </summary>
        public IAssemblyResolution[] Resolved {get;}

        public string Format()
            => string.Empty;
    }
}