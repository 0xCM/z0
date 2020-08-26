//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Defines supported x86-encoding capture operations
    /// </summary>
    public interface ICaptureCore
    {
        /// <summary>
        /// Captures an api member that has already been jitted
        /// </summary>
        /// <param name="exchange">The selected exchange</param>
        /// <param name="src">The api member</param>
        Option<CapturedMember> Capture(in CaptureExchange exchange, in ApiMember src);

        /// <summary>
        /// Captures jitted x86 encoded assembly for nongeneric methods
        /// </summary>
        /// <param name="exchange">The selected exchange</param>
        /// <param name="id">The identity to confer to the captured member</param>
        /// <param name="src">The source method</param>
        Option<CapturedCode> Capture(in CaptureExchange exchange, OpIdentity id, MethodInfo src);

        /// <summary>
        /// Captures jitted x86 encoded assembly for generic or nongeneric methods
        /// </summary>
        /// <param name="exchange">The selected exchange</param>
        /// <param name="src">The source method</param>
        /// <param name="args">The types over which to close open generic methods, if applicable</param>
        /// <remarks>
        /// If the method is open generic, it is closed over supplied type arguments or
        /// If the method is nongeneric or closed-generic, the method is captured as-is
        /// </remarks>
        Option<CapturedCode> Capture(in CaptureExchange exchange, MethodInfo src, params Type[] args);

        /// <summary>
        /// Captures jitted x86 encoded assembly for a dynamic delegate
        /// </summary>
        /// <param name="exchange">The selected exchange</param>
        /// <param name="id">The operation identity to confer</param>
        /// <param name="src">The dynamic delegate to capture</param>
        Option<CapturedCode> Capture(in CaptureExchange exchange, OpIdentity id, in DynamicDelegate src);

        /// <summary>
        /// Captures jitted x86 encoded assembly for a delegate
        /// </summary>
        /// <param name="exchange">The selected exchange</param>
        /// <param name="id">The operation identity to confer</param>
        /// <param name="src">The delegate to capture</param>
        Option<CapturedCode> Capture(in CaptureExchange exchange, OpIdentity id, Delegate src);

        /// <summary>
        /// Captures encoded data from a caller-supplied source buffer.
        /// </summary>
        /// <param name="exchange">The selected exchange</param>
        /// <param name="id">The operation identity to confer</param>
        /// <param name="src">The source buffer</param>
        Option<ParsedBuffer> ParseBuffer(in CaptureExchange exchange, OpIdentity id, Span<byte> src);

        /// <summary>
        /// Captures jitted x86 encoded assembly for a dynamic delegate
        /// </summary>
        /// <param name="exchange">The selected exchange</param>
        /// <param name="id">The operation identity to confer</param>
        /// <param name="src">The dynamic delegate to capture</param>
        Option<CapturedCode> Capture<D>(in CaptureExchange exchange, OpIdentity id, DynamicDelegate<D> src)
            where D : Delegate => Capture(exchange,id, src.Untyped);
    }
}