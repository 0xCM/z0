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

    partial class XTend
    {
        /// <summary>
        /// Determines the variance of a parameter
        /// </summary>
        /// <param name="src">The source parameter</param>
        [MethodImpl(Inline)]
        public static ParamRefKind ReferenceKind(this ParameterInfo src)        
            => src.IsIn 
            ? Z0.ParamRefKind.In  : src.IsOut 
            ? Z0.ParamRefKind.Out : src.ParameterType.IsByRef 
            ? Z0.ParamRefKind.Ref : Z0.ParamRefKind.None;

        [MethodImpl(Inline)]
        public static string Keyword(this ParamRefKind src)        
            => src switch{
                ParamRefKind.In => "in",
                ParamRefKind.Out => "out",
                ParamRefKind.Ref => "ref",    
                _ => ""
            };

        [MethodImpl(Inline)]
        public static string Format(this ParamRefKind src)
            => src != 0 ? ('~' + src.Keyword()) : string.Empty;
    }
}