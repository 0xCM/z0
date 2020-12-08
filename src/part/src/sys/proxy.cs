//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    readonly partial struct proxy
    {
        const NumericKind Closure = Integers;

        const string EmptyString = "";

        const MethodImplOptions Options = MethodImplOptions.NoInlining;
    }
}