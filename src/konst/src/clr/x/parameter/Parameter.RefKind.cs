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
        public static CliArgRefKind RefKind(this ParameterInfo src)
            => src.IsIn
            ? Z0.CliArgRefKind.In  : src.IsOut
            ? Z0.CliArgRefKind.Out : src.ParameterType.IsByRef
            ? Z0.CliArgRefKind.Ref : Z0.CliArgRefKind.None;

        [MethodImpl(Inline), Op]
        public static string Keyword(this CliArgRefKind src)
            => src switch{
                CliArgRefKind.In => "in",
                CliArgRefKind.Out => "out",
                CliArgRefKind.Ref => "ref",
                _ => ""
            };

        [MethodImpl(Inline), Op]
        public static string Format(this CliArgRefKind src)
            => src != 0 ? ('~' + src.Keyword()) : string.Empty;
    }
}