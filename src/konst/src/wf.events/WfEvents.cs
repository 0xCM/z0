//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    [ApiHost(ApiNames.WfEvents, true)]
    public readonly partial struct WfEvents
    {
        const string HandlerNotFound = "Handler for {0} not found";

        const NumericKind Closure = UnsignedInts;
    }
}