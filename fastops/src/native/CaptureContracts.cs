//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public partial interface IMemberCapture
    {        
        CapturedMember Capture(OpIdentity id, MethodInfo src, in CaptureExchange exchange);

        CapturedMember Capture(OpIdentity id, DynamicDelegate src, in CaptureExchange exchange);

        CapturedMember Capture(OpIdentity id, Delegate src, in CaptureExchange exchange);

    }
}