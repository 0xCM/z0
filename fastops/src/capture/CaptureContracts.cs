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

    public interface IAsmEmissionToken : IEquatable<AsmEmissionToken>, IComparable<AsmEmissionToken>
    {

    }

    public interface IAsmEmissionSink : IPointSink<AsmEmissionGroup>
    {
        
    }

    public delegate void OnCaptureReceipt(in CaptureEventData data);

    /// <summary>
    /// Defines contract for external observation of the capture workflow
    /// </summary>
    public interface ICaptureEventSink : ISink
    {
        void Accept(in CaptureEventData data);

        void Complete(in CaptureEventData data);
    }

    /// <summary>
    /// Defines a source for events that originate within a capture exchange context. This
    /// device is used as a means to compensate that the exchange itself, which is a
    /// ref struct, cannot be contracted.
    /// </summary>
    public interface ICaptureJunction
    {
        /// <summary>
        /// Invoked by the exchange to relay a capture state change
        /// </summary>
        /// <param name="src">The source exchange</param>
        /// <param name="state">The new state</param>
        void Accept(in CaptureExchange src, in CaptureState state);   

        /// <summary>
        /// Invoked by the exchange to relay a capture completion event
        /// </summary>
        /// <param name="src">The source exchange</param>
        /// <param name="state">The final state</param>
        /// <param name="captured">The captured member</param>
        void Complete(in CaptureExchange src, in CaptureState state, in CapturedMember captured);        
    }

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

    public interface ICaptureClient : ICaptureEventSink
    {
        ICaptureControl Control {get;}
    }

    public interface ICaptureControl : ICaptureOps, ICaptureJunction, ICaptureEventSink
    {

    }

}