//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class ApiCompostions
    {
        /// <summary>
        /// Covers the source resolutions with an assembly composition
        /// </summary>
        /// <param name="resolutions">The resolutions</param>
        public static ApiComposition Assemble(this IEnumerable<IApiAssembly> resolutions)
            => ApiComposition.Assemble(resolutions.Where(r => r.Id != 0).ToArray());
    }
}