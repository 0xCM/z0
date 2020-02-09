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
    /// Defines most basic service contract for capturing x86 *decoded* assembly data produced by the jitter
    /// </summary>
    public interface IAsmExtractor : IAsmService
    {
        /// <summary>
        /// Extracts the source content as an assembly function
        /// </summary>
        /// <param name="src">The source operation</param>
        AsmFunction ExtractAsm(in CaptureExchange exchange, Delegate src);

        /// <summary>
        /// Extracts the source content as an assembly function
        /// </summary>
        /// <param name="src">The source operation</param>
        AsmFunction ExtractAsm(in CaptureExchange exchange, MethodInfo src);

        /// <summary>
        /// Extracts the source content as an assembly function
        /// </summary>
        /// <param name="src">The source operation</param>
        /// <param name="args">The type arguments required, if any, to reify a generic method</param>
        AsmFunction ExtractAsm(in CaptureExchange exchange, MethodInfo src, params Type[] args);
    }
}