//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Compostions
    {
        /// <summary>
        /// Covers the source resolutions with an assembly composition
        /// </summary>
        /// <param name="resolutions">The resolutions</param>
        public static AssemblyComposition Assemble(this IEnumerable<IAssemblyResolution> resolutions)
            => AssemblyComposition.Assemble(resolutions.ToArray());
    }
}