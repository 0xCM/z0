//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static zfunc;

    /// <summary>
    /// Defines most basic service contract for capturing x86 *encoded* assembly data produced by the jitter
    /// </summary>
    public interface ICaptureService : IAsmService
    {
        /// <summary>
        /// Captures native x86 encoded assembly produced by the jitter for a method
        /// </summary>
        /// <param name="exchange">The selected exchange</param>
        /// <param name="id">The identity to confer to the captured member</param>
        /// <param name="src">The source method</param>
        CapturedMember Capture(in CaptureExchange exchange, OpIdentity id, MethodInfo src);

        /// <summary>
        /// Captures native x86 encoded assembly produced by the jitter by either 
        /// closing an open generic method definition over supplied type arguments or, if
        /// the method is non-generic or closed generic, submits the method directly for capture
        /// </summary>
        /// <param name="exchange">The selected exchange</param>
        /// <param name="src">The source method</param>
        /// <param name="args">The types over which to close the generic method</param>
        CapturedMember Capture(in CaptureExchange exchange, MethodInfo src, params Type[] args);

        /// <summary>
        /// Captures native x86 encoded assembly produced by the jitter for a delegate
        /// </summary>
        /// <param name="exchange">The selected exchange</param>
        /// <param name="id">The identity to confer to the captured member</param>
        /// <param name="src">The delegate to capture</param>
        CapturedMember Capture(in CaptureExchange exchange, OpIdentity id, Delegate src);

        /// <summary>
        /// Captures native code produced by the JIT for a dynamic delegate
        /// </summary>
        /// <param name="exchange">The selected exchange</param>
        /// <param name="id">The identity to confer to the captured member</param>
        /// <param name="src">The dynamic delegate to capture</param>
        CapturedMember Capture(in CaptureExchange exchange, OpIdentity id, DynamicDelegate src);        
    }
}