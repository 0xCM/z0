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
    /// Delegate contract for capture event receipt
    /// </summary>
    /// <param name="data">The event data</param>
    public delegate void AsmCaptureEventObserver(in AsmCaptureEvent data);

    /// <summary>
    /// Delegate contract for emission event receipt
    /// </summary>
    /// <param name="data">The event data</param>
    public delegate void AsmCaptureEmissionObserver(in CaptureTokenGroup data);

    /// <summary>
    /// Defines a source for events that originate within a capture exchange context. This
    /// device is used as a means to compensate for the fact that the exchange itself, which is a
    /// ref struct, cannot be contracted.
    /// </summary>
    public interface IAsmCaptureJunction
    {
        /// <summary>
        /// Invoked by the exchange to relay a capture state change
        /// </summary>
        /// <param name="src">The source exchange</param>
        /// <param name="state">The new state</param>
        void OnCaptureStep(in AsmCaptureExchange src, in CaptureState state);   

        /// <summary>
        /// Invoked by the exchange to relay a capture completion event
        /// </summary>
        /// <param name="src">The source exchange</param>
        /// <param name="state">The final state</param>
        /// <param name="captured">The captured member</param>
        void OnCaptureComplete(in AsmCaptureExchange src, in CaptureState state, in AsmMemberCapture captured);        
    }

    /// <summary>
    /// Defines the supported capture operations
    /// </summary>
    public interface IAsmCaptureOps : IAsmService
    {               
        AsmMemberCapture Capture(in AsmCaptureExchange exchange, in OpIdentity id, MethodInfo src);            

        AsmMemberCapture Capture(in AsmCaptureExchange exchange, in OpIdentity id, in DynamicDelegate src);
            
        AsmMemberCapture Capture(in AsmCaptureExchange exchange, in OpIdentity id, Delegate src);
            
        Option<CapturedData> Capture(in AsmCaptureExchange exchange, in OpIdentity id, Span<byte> src);
    }

    public interface IAsmCaptureControl : IAsmCaptureOps, IAsmCaptureJunction
    {

    }
}