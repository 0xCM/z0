//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;


    public static partial class XTend
    {
        const NumericKind Closure = Integers;

        const MethodImplOptions Options = MethodImplOptions.AggressiveInlining;
    }

    [ApiHost]
    public readonly partial struct sys
    {
        const NumericKind Closure = Integers;

        public static Type ProxyType => typeof(proxy);

        const string EmptyString = "";

        internal const MethodImplOptions Options = MethodImplOptions.AggressiveInlining;
    }
}