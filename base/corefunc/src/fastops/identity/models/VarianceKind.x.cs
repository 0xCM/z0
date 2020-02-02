//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class FastOpX
    {
        public static ParamVariance Variance(this ParameterInfo src)        
            => src.IsIn ? Z0.ParamVariance.In  : src.IsOut ? Z0.ParamVariance.Out  : src.ParameterType.IsByRef ? Z0.ParamVariance.Ref : Z0.ParamVariance.None;

        public static string Keyword(this ParamVariance src)        
            => src switch{
                ParamVariance.In => "in",
                ParamVariance.Out => "out",
                ParamVariance.Ref => "ref",    
                _ => string.Empty
            };

        public static string Format(this ParamVariance src)
            => src != ParamVariance.None ? parenthetical(src.Keyword()) : string.Empty;    
    }

}