//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost(ApiNames.WfEvents, true)]
    public readonly partial struct WfEvents
    {
        const string HandlerNotFound = "Handler for {0} not found";

        const string CallerPattern = "An error was trapped by {0} on line {1} in {2}";

        const NumericKind Closure = UnsignedInts;
    }
}