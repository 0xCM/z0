//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Kinds;

    public static class ParamAspectOps
    {
        /// <summary>
        /// Determines the variance of a parameter
        /// </summary>
        /// <param name="src">The source parameter</param>
        public static ParamRefAspect ClassifyVariance(this ParameterInfo src)        
            => src.IsIn 
            ? Z0.ParamRefAspect.In  : src.IsOut 
            ? Z0.ParamRefAspect.Out : src.ParameterType.IsByRef 
            ? Z0.ParamRefAspect.Ref : Z0.ParamRefAspect.None;

        [MethodImpl(Inline)]
        public static bool IsSome(this ParamRefAspect src)        
            => src != ParamRefAspect.None;

        public static string Keyword(this ParamRefAspect src)        
            => src switch{
                ParamRefAspect.In => "in",
                ParamRefAspect.Out => "out",
                ParamRefAspect.Ref => "ref",    
                _ => string.Empty
            };

        public static string Format(this ParamRefAspect src)
            => src.IsSome() ? ('~' + src.Keyword()) : string.Empty;              
    }
}