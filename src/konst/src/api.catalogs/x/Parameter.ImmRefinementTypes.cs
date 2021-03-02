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
        /// <summary>
        /// Determines the imm refinement type, if any
        /// </summary>
        /// <param name="src">The source parameter</param>
        [Op]
        public static Option<Type> ImmRefinementType(this ParameterInfo src)
            => src.IsRefinedImmediate() ? root.some(src.ParameterType) : root.none<Type>();
    }
}