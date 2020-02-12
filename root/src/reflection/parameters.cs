//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static RootShare;
    using static ReflectionFlags;
    
    partial class RootReflections
    {
        public static bool IsParametric(this ParameterInfo src)
            => src.ParameterType.IsGenericParameter 
            || src.ParameterType.IsGenericMethodParameter 
            || src.ParameterType.IsGenericTypeParameter;

        /// <summary>
        /// Determines whether a parameters is an immediate
        /// </summary>
        /// <param name="src">The source parameter</param>
        public static bool IsImmediate(this ParameterInfo param)
            => param.Attributed<ImmAttribute>();

        /// <summary>
        /// Determines the variance of a parameter
        /// </summary>
        /// <param name="src">The source parameter</param>
        public static ParamVariance Variance(this ParameterInfo src)        
            => src.IsIn 
            ? Z0.ParamVariance.In  : src.IsOut 
            ? Z0.ParamVariance.Out : src.ParameterType.IsByRef 
            ? Z0.ParamVariance.Ref : Z0.ParamVariance.None;
    }
}