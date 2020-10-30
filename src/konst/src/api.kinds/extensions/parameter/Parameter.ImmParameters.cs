//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;

    partial class XKinds
    {
        /// <summary>
        /// Selects parameters from a method, if any, that acceptrequire an immediate value
        /// </summary>
        /// <param name="m">The method to examine</param>
        [Op]
        public static ParameterInfo[] ImmParameters(this MethodInfo src, ScalarRefinementKind refinement)
        {
            var refined = src.GetParameters().Where(p => p.IsRefinedImmediate());
            var unrefined = src.GetParameters().Where(p => p.IsUnrefinedImmediate());
            if(refinement == ScalarRefinementKind.All)
                return refined.Concat(unrefined).Array();
            else if(refinement == ScalarRefinementKind.Refined)
                return refined;
            else
                return unrefined;
        }
    }
}