//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    partial class Extend 
    {
        [MethodImpl(Inline), Op]
        public static string keyword(ParamRefKind src)        
            => src switch{
                ParamRefKind.In => "in",
                ParamRefKind.Out => "out",
                ParamRefKind.Ref => "ref",    
                _ => ""
            };

        /// <summary>
        /// Determines the variance of a parameter
        /// </summary>
        /// <param name="src">The source parameter</param>
        [MethodImpl(Inline), Op]
        public static ParamRefKind refkind(ParameterInfo src)        
            => src.IsIn 
            ? Z0.ParamRefKind.In  : src.IsOut 
            ? Z0.ParamRefKind.Out : src.ParameterType.IsByRef 
            ? Z0.ParamRefKind.Ref : Z0.ParamRefKind.None;
    }
}