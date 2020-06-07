//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed;

    partial class XTend
    {
        /// <summary>
        /// Determines the variance of a parameter
        /// </summary>
        /// <param name="src">The source parameter</param>
        [MethodImpl(Inline)]
        public static ParamRefKind ReferenceKind(this ParameterInfo src)        
            => Extend.refkind(src);

        [MethodImpl(Inline)]
        public static string Keyword(this ParamRefKind src)        
            => Extend.keyword(src);

        [MethodImpl(Inline)]
        public static string Format(this ParamRefKind src)
            => src != 0 ? ('~' + src.Keyword()) : string.Empty;
    }
}