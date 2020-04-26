//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Exposes capture services without the hassle of passing a ref struct about hither thither and yon
    /// </summary>
    public interface ICaptureServiceProxy : IService
    {
        /// <summary>
        /// The capture exchange
        /// </summary>
        ICaptureExchange CaptureExchange {get;}

        /// <summary>
        /// The exchange service
        /// </summary>
        ICaptureService CaptureService {get;}

        /// <summary>
        /// Captures jitted x86 encoded assembly for nongeneric methods
        /// </summary>
        /// <param name="id">The identity to confer to the captured member</param>
        /// <param name="src">The source method</param>
        [MethodImpl(Inline)]
        Option<ApiMemberCapture> Capture(OpIdentity id, MethodInfo src)
            => CaptureService.Capture(CaptureExchange.Context, id, src);

        /// <summary>
        /// Captures jitted x86 encoded assembly for generic or nongeneric methods
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="args">The types over which to close open generic methods, if applicable</param>
        /// <remarks>
        /// If the method is open generic, it is closed over supplied type arguments or
        /// If the method is nongeneric or closed-generic, the method is captured as-is
        /// </remarks>
        [MethodImpl(Inline)]
        Option<ApiMemberCapture> Capture(MethodInfo src, params Type[] args)
            => CaptureService.Capture(CaptureExchange.Context, src, args);

        /// <summary>
        /// Captures jitted x86 encoded assembly for a dynamic delegate
        /// </summary>
        /// <param name="id">The identity to confer to the captured member</param>
        /// <param name="src">The dynamic delegate to capture</param>
        [MethodImpl(Inline)]
        Option<ApiMemberCapture> Capture(OpIdentity id, in DynamicDelegate src)
            => CaptureService.Capture(CaptureExchange.Context, id, src);

        /// <summary>
        /// Captures jitted x86 encoded assembly for a delegate
        /// </summary>
        /// <param name="id">The identity to confer to the captured member</param>
        /// <param name="src">The delegate to capture</param>
        [MethodImpl(Inline)]
        Option<ApiMemberCapture> Capture(OpIdentity id, Delegate src)
            => CaptureService.Capture(CaptureExchange.Context, id, src);

        /// <summary>
        /// Captures encoded data from a caller-supplied source buffer.
        /// </summary>
        /// <param name="id">The identity to confer to the parsed buffer</param>
        /// <param name="src">The source buffer</param>
        [MethodImpl(Inline)]
        Option<ParsedBuffer> ParseBuffer(OpIdentity id, Span<byte> src)
            => CaptureService.ParseBuffer(CaptureExchange.Context, id, src);         

        /// <summary>
        /// Captures jitted x86 encoded assembly for a dynamic delegate
        /// </summary>
        /// <param name="id">The identity to confer to the captured member</param>
        /// <param name="src">The dynamic delegate to capture</param>
        [MethodImpl(Inline)]
        Option<ApiMemberCapture> Capture<D>(OpIdentity id, DynamicDelegate<D> src)
            where D : Delegate => Capture(id, src.Untyped);            
    }
}