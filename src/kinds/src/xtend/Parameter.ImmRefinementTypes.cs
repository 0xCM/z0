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
        /// <summary>
        /// Determines the imm refinement type, if any
        /// </summary>
        /// <param name="src">The source parameter</param>
        public static Option<Type> ImmRefinementType(this ParameterInfo src)
            => src.IsRefinedImmediate() ? Option.some(src.ParameterType) : Option.none<Type>();
    }
}