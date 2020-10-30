//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial class XKinds
    {
        [Op]
        public static ScalarRefinementKind ClassifyImmRefinement(this ParameterInfo src)
        {
            if(!src.Tagged<ImmAttribute>())
                return ScalarRefinementKind.None;
            else
                return src.ParameterType.IsEnum ? ScalarRefinementKind.Refined : ScalarRefinementKind.Unrefined;
        }
    }
}