//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Defines the supported capture operations
    /// </summary>
    public interface ICaptureOps
    {               
        CapturedMember Capture(in CaptureExchange exchange, in OpIdentity id, MethodInfo src);            

        CapturedMember Capture(in CaptureExchange exchange, in OpIdentity id, in DynamicDelegate src);
            
        CapturedMember Capture(in CaptureExchange exchange, in OpIdentity id, Delegate src);
            
        Option<CapturedData> Capture(in CaptureExchange exchange, in OpIdentity id, Span<byte> src);
    }
}