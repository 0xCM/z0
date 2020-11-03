//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XClrQuery
    {
        /// <summary>
        /// Determines the variance of a parameter
        /// </summary>
        /// <param name="src">The source parameter</param>
        [MethodImpl(Inline), Op]
        public static ArgRefKind RefKind(this ParameterInfo src)
            => src.IsIn
            ? Z0.ArgRefKind.In  : src.IsOut
            ? Z0.ArgRefKind.Out : src.ParameterType.IsByRef
            ? Z0.ArgRefKind.Ref : Z0.ArgRefKind.None;

        [MethodImpl(Inline), Op]
        public static string Keyword(this ArgRefKind src)
            => src switch{
                ArgRefKind.In => "in",
                ArgRefKind.Out => "out",
                ArgRefKind.Ref => "ref",
                _ => ""
            };

        [MethodImpl(Inline), Op]
        public static string Format(this ArgRefKind src)
            => src != 0 ? ('~' + src.Keyword()) : string.Empty;
    }
}