//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XClrQuery
    {
        /// <summary>
        /// Determines the variance of a parameter
        /// </summary>
        /// <param name="src">The source parameter</param>
        [MethodImpl(Inline), Op]
        public static ClrArgRefKind RefKind(this ParameterInfo src)
            => src.IsIn
            ? Z0.ClrArgRefKind.In  : src.IsOut
            ? Z0.ClrArgRefKind.Out : src.ParameterType.IsByRef
            ? Z0.ClrArgRefKind.Ref : Z0.ClrArgRefKind.None;

        [MethodImpl(Inline), Op]
        public static string Keyword(this ClrArgRefKind src)
            => src switch{
                ClrArgRefKind.In => "in",
                ClrArgRefKind.Out => "out",
                ClrArgRefKind.Ref => "ref",
                _ => ""
            };

        [MethodImpl(Inline), Op]
        public static string Format(this ClrArgRefKind src)
            => src != 0 ? ('~' + src.Keyword()) : string.Empty;
    }
}