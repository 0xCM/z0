//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using XF = ExprFormats;

    partial struct lang
    {
        internal static string format<T>(in Production<T> src)
            where T : IExpr
                => string.Format("<{0}> -> {1}", src.Name, src.Term.Format());

        internal static string format(in StringLiteral src)
            => string.Format(XF.Definition, src.Name, RP.enquote(src.Value));

    }
}