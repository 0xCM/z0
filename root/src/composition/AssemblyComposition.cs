//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
        
    /// <summary>
    /// Defines a collection of resolved assemblies
    /// </summary>
    public readonly struct AssemblyComposition : IAssemblyComposition
    {
        public static IAssemblyComposition Empty => Assemble();

        public static AssemblyComposition Assemble(params IAssemblyResolution[] resolved)
            => new AssemblyComposition(resolved);

        AssemblyComposition(IAssemblyResolution[] resolved)
            => Resolved = resolved;

        /// <summary>
        /// The members of the compostion
        /// </summary>
        public IAssemblyResolution[] Resolved {get;}   

        public bool IsEmpty
            => Resolved.Length == 0;
    }

    partial class RootX
    {
        /// <summary>
        /// Covers the source resolutions with an assembly composition
        /// </summary>
        /// <param name="resolutions"></param>
        /// <returns></returns>
        public static AssemblyComposition Assemble(this IEnumerable<IAssemblyResolution> resolutions)
            => AssemblyComposition.Assemble(resolutions.ToArray());
    }

}