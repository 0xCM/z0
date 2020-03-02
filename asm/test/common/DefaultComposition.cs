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

    public readonly struct DefaultComposition : IAssemblyComposition<DefaultComposition>
    {
        static IEnumerable<IAssemblyResolution> Resolutions => items<IAssemblyResolution>(
                Designators.Analogs.Resolution,
                Designators.AsmCore.Resolution,
                Designators.BitCore.Resolution,
                Designators.BitGrids.Resolution,
                Designators.BitSpan.Resolution,
                Designators.BitFields.Resolution,
                Designators.BitVectors.Resolution,
                Designators.CoreFunc.Resolution,
                Designators.Blocks.Resolution,
                Designators.Fixed.Resolution,
                Designators.GMath.Resolution,
                Designators.GMathSvc.Resolution,
                Designators.Intrinsics.Resolution,
                Designators.LibM.Resolution,
                Designators.Logix.Resolution,
                Designators.Root.Resolution,
                Designators.VFuncs.Resolution);

        [MethodImpl(Inline)]
        public static IAssemblyComposition Create()
            => new DefaultComposition(Resolutions);

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