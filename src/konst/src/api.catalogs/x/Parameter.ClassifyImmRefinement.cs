//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial class ClrQuery
    {
        [Op]
        public static RefinementClass ClassifyImmRefinement(this ParameterInfo src)
        {
            if(!src.Tagged<ImmAttribute>())
                return RefinementClass.None;
            else
                return src.ParameterType.IsEnum ? RefinementClass.Refined : RefinementClass.Unrefined;
        }
    }
}