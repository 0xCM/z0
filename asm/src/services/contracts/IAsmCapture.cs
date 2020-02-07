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

    public interface INativeExtractor : IAsmService
    {
        /// <summary>
        /// Runs the jitter on a reflected method and captures the emitted binary assembly data
        /// </summary>
        /// <param name="src">The method to read</param>
        /// <param name="dst">The target buffer</param>
        CapturedMember ExtractBits(in CaptureExchange exchange, OpIdentity id, MethodInfo src);

        /// <summary>
        /// Captures the native x86 encoded assembly produced by the jitter by either 
        /// closing an open generic method definition over supplied type arguments or, if
        ///  the method is non-generic or closed generic, submits the method directly for capture
        /// </summary>
        /// <param name="src">The generic method definition, obtained by MethodInfo.GetGenericMethodDefinition</param>
        /// <param name="args">The types over which to close the generic method</param>
        /// <param name="dst">The target buffer</param>
        CapturedMember ExtractBits(in CaptureExchange exchange, MethodInfo src, params Type[] args);

        /// <summary>
        /// Runs the jitter on a delegate and captures the emitted binary assembly data
        /// </summary>
        /// <param name="m">The method to read</param>
        /// <param name="dst">The target buffer</param>
        CapturedMember ExtractBits(in CaptureExchange exchange, OpIdentity id, Delegate src);

        /// <summary>
        /// Runs the jitter on a delegate and captures the emitted binary assembly data
        /// </summary>
        /// <param name="m">The source method</param>
        /// <param name="dst">The target buffer</param>
        CapturedMember ExtractBits(in CaptureExchange exchange, Delegate src);

        /// <summary>
        /// Captures native code produced by the JIT for a dynamic delegate
        /// </summary>
        /// <param name="m">The source delegate</param>
        /// <param name="dst">The target buffer</param>
        CapturedMember ExtractBits(in CaptureExchange exchange, OpIdentity id, DynamicDelegate src);        
    }

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

    public interface INativeCapture : IAsmService
    {
        /// <summary>
        /// Emits x86 encoded assembly that reifies a stream of methods to a caller-supplied writer
        /// </summary>
        /// <param name="src">The methods to capture</param>
        /// <param name="dst">The capture target</param>
        void SaveBits(in CaptureExchange exchange, MethodInfo src, IAsmHexWriter dst);

        /// <summary>
        /// Emits x86 encoded assembly that reifies a stream of methods to a caller-supplied writer
        /// </summary>
        /// <param name="src">The methods to capture</param>
        /// <param name="dst">The capture target</param>
        void SaveBits(in CaptureExchange exchange, MethodInfo[] src, IAsmHexWriter dst);
        
        /// <summary>
        /// Closes a generic method definition over supplied type arguments and captures the native x86 encoded assembly produced by the jitter
        /// </summary>
        /// <param name="src">The generic method definition, obtained by MethodInfo.GetGenericMethodDefinition</param>
        /// <param name="args">The types over which to close the generic method</param>
        /// <param name="dst">The target buffer</param>
        void SaveBits(in CaptureExchange exchange, MethodInfo src, Type[] args, IAsmHexWriter dst);

        /// <summary>
        /// Captures the native x86 encoded assembly produced by the jitterCaptures and sends the content to a target writer
        /// </summary>
        /// <param name="m">The source method</param>
        /// <param name="dst">The target writer</param>
        void SaveBits(in CaptureExchange exchange, Delegate src, IAsmHexWriter dst);
    }
        
    public interface IAsmCapture : IAsmService
    {
        void SaveAsm(in CaptureExchange exchange, Delegate src, IAsmFunctionWriter dst);

        void SaveAsm(in CaptureExchange exchange, MethodInfo src, IAsmFunctionWriter dst);

        void SaveAsm(in CaptureExchange exchange, MethodInfo src, Type[] args, IAsmFunctionWriter dst);

        void SaveAsm(in CaptureExchange exchange, MethodInfo[] src, IAsmFunctionWriter dst);      
    }

    public interface IAsmCaptureService : INativeCapture, IAsmCapture, IAsmExtractor, INativeExtractor
    {

    } 

}