//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Characterizes a service that extracts identified member operation x86 encodings
    /// </summary>
    public interface ICaptureService : IService
    {               
        /// <summary>
        /// Captures native x86 encoded assembly produced by the jitter for a method
        /// </summary>
        /// <param name="exchange">The selected exchange</param>
        /// <param name="id">The identity to confer to the captured member</param>
        /// <param name="src">The source method</param>
        CapturedOp Capture(in OpExtractExchange exchange, in OpIdentity id, MethodInfo src);            

        /// <summary>
        /// Captures native x86 encoded assembly produced by the jitter by either 
        /// closing an open generic method definition over supplied type arguments or, if
        /// the method is non-generic or closed generic, submits the method directly for capture
        /// </summary>
        /// <param name="exchange">The selected exchange</param>
        /// <param name="src">The source method</param>
        /// <param name="args">The types over which to close the generic method</param>
        CapturedOp Capture(in OpExtractExchange exchange, MethodInfo src, params Type[] args);        

        /// <summary>
        /// Captures native code produced by the JIT for a dynamic delegate
        /// </summary>
        /// <param name="exchange">The selected exchange</param>
        /// <param name="id">The identity to confer to the captured member</param>
        /// <param name="src">The dynamic delegate to capture</param>
        CapturedOp Capture(in OpExtractExchange exchange, in OpIdentity id, in DynamicDelegate src);
            
        /// <summary>
        /// Captures native x86 encoded assembly produced by the jitter for a delegate
        /// </summary>
        /// <param name="exchange">The selected exchange</param>
        /// <param name="id">The identity to confer to the captured member</param>
        /// <param name="src">The delegate to capture</param>
        CapturedOp Capture(in OpExtractExchange exchange, in OpIdentity id, Delegate src);
            
        /// <summary>
        /// Captures encoded data from a caller-supplied source buffer.
        /// </summary>
        /// <param name="exchange">The selected exchange</param>
        /// <param name="id"></param>
        /// <param name="src">The source buffer</param>
        Option<ParsedBuffer> ParseBuffer(in OpExtractExchange exchange, in OpIdentity id, Span<byte> src);
    }
}