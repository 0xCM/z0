//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Root;

    public enum ParamVarianceClass
    {
        None = 0, 

        In = 1,

        Out = 2,

        Ref = 3
    }

    partial class ReflectedClass
    {
        /// <summary>
        /// Determines the variance of a parameter
        /// </summary>
        /// <param name="src">The source parameter</param>
        public static ParamVarianceClass ClassifyVariance(this ParameterInfo src)        
            => src.IsIn 
            ? Z0.ParamVarianceClass.In  : src.IsOut 
            ? Z0.ParamVarianceClass.Out : src.ParameterType.IsByRef 
            ? Z0.ParamVarianceClass.Ref : Z0.ParamVarianceClass.None;

        [MethodImpl(Inline)]
        public static bool IsSome(this ParamVarianceClass src)        
            => src != ParamVarianceClass.None;

        public static string Keyword(this ParamVarianceClass src)        
            => src switch{
                ParamVarianceClass.In => "in",
                ParamVarianceClass.Out => "out",
                ParamVarianceClass.Ref => "ref",    
                _ => string.Empty
            };

        public static string Format(this ParamVarianceClass src)
            => src.IsSome() ? ('~' + src.Keyword()) : string.Empty;      
    }
}