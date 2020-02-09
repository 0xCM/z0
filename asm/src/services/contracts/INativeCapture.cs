//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static zfunc;

    using AsmSpecs;

    /// <summary>
    /// Defines service contract for capturing native x86 *encoded* assembly produced by the jitter.
    /// Capturing, by definition, first requires extraction, which is delegated to an extraction service
    /// </summary>
    public interface INativeCapture : IAsmService
    {
        /// <summary>
        /// Emits x86 encoded assembly that reifies a stream of methods to a caller-supplied writer
        /// </summary>
        /// <param name="src">The methods to capture</param>
        /// <param name="dst">The capture target</param>
        void CaptureBits(in CaptureExchange exchange, MethodInfo src, IAsmCodeWriter dst);

        /// <summary>
        /// Emits x86 encoded assembly that reifies a stream of methods to a caller-supplied writer
        /// </summary>
        /// <param name="src">The methods to capture</param>
        /// <param name="dst">The capture target</param>
        void CaptureBits(in CaptureExchange exchange, MethodInfo[] src, IAsmCodeWriter dst);
        
        /// <summary>
        /// Closes a generic method definition over supplied type arguments and captures the native x86 encoded assembly produced by the jitter
        /// </summary>
        /// <param name="src">The generic method definition, obtained by MethodInfo.GetGenericMethodDefinition</param>
        /// <param name="args">The types over which to close the generic method</param>
        /// <param name="dst">The target buffer</param>
        void CaptureBits(in CaptureExchange exchange, MethodInfo src, Type[] args, IAsmCodeWriter dst);

        /// <summary>
        /// Captures the native x86 encoded assembly produced by the jitterCaptures and sends the content to a target writer
        /// </summary>
        /// <param name="m">The source method</param>
        /// <param name="dst">The target writer</param>
        void CaptureBits(in CaptureExchange exchange, Delegate src, IAsmCodeWriter dst);
    }


}