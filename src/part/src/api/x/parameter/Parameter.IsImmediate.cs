//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial class XApi
    {
        /// <summary>
        /// Determines whether a parameters is an immediate
        /// </summary>
        /// <param name="src">The source parameter</param>
        [Op]
        public static bool IsImmediate(this ParameterInfo param, RefinementClass refinement)
        {
            if(param.Tagged<ImmAttribute>())
            {
                var refined = param.ParameterType.IsEnum;
                if(refined)
                {
                    if(refinement == RefinementClass.Refined || refinement == RefinementClass.All)
                        return true;
                }
                else
                {
                    if(refinement == RefinementClass.Unrefined)
                        return true;
                }

            }
            return false;
        }
    }
}