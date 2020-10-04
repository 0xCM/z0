//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    partial class XTend
    {
        public static ScalarRefinementKind ClassifyImmRefinement(this ParameterInfo src)
        {
            if(!src.Tagged<ImmAttribute>())
                return ScalarRefinementKind.None;
            else
                return src.ParameterType.IsEnum ? ScalarRefinementKind.Refined : ScalarRefinementKind.Unrefined;
        }
    }
}