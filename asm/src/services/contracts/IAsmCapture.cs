//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;

    using static zfunc;

    using AsmSpecs;

    public interface INativeExtract : IAsmService
    {
        /// <summary>
        /// Runs the jitter on a reflected method and captures the emitted binary assembly data
        /// </summary>
        /// <param name="src">The method to read</param>
        /// <param name="dst">The target buffer</param>
        CapturedMember ExtractBits(OpIdentity id, MethodInfo src);

        /// <summary>
        /// Captures the native x86 encoded assembly produced by the jitter by either 
        /// closing an open generic method definition over supplied type arguments or, if
        ///  the method is non-generic or closed generic, submits the method directly for capture
        /// </summary>
        /// <param name="src">The generic method definition, obtained by MethodInfo.GetGenericMethodDefinition</param>
        /// <param name="args">The types over which to close the generic method</param>
        /// <param name="dst">The target buffer</param>
        CapturedMember ExtractBits(MethodInfo src, params Type[] args);

        /// <summary>
        /// Runs the jitter on a delegate and captures the emitted binary assembly data
        /// </summary>
        /// <param name="m">The method to read</param>
        /// <param name="dst">The target buffer</param>
        CapturedMember ExtractBits(OpIdentity id, Delegate src);

        /// <summary>
        /// Runs the jitter on a delegate and captures the emitted binary assembly data
        /// </summary>
        /// <param name="m">The source method</param>
        /// <param name="dst">The target buffer</param>
        CapturedMember ExtractBits(Delegate src);

        /// <summary>
        /// Captures native code produced by the JIT for a dynamic delegate
        /// </summary>
        /// <param name="m">The source delegate</param>
        /// <param name="dst">The target buffer</param>
        CapturedMember ExtractBits(OpIdentity id, DynamicDelegate src);        
    }

    public interface IAsmExtract : IAsmService
    {
        AsmFunction ExtractAsm(Delegate src);

        AsmFunction ExtractAsm(MethodInfo src);

        AsmFunction ExtractAsm(MethodInfo src, params Type[] args);                        

        AsmFunction[] ExtractAsm(MethodInfo[] src, params Type[] args);
    }

    public interface INativeCapture : IAsmService
    {
        /// <summary>
        /// Emits x86 encoded assembly that reifies a stream of methods to a caller-supplied writer
        /// </summary>
        /// <param name="src">The methods to capture</param>
        /// <param name="dst">The capture target</param>
        void SaveBits(MethodInfo src, IAsmHexWriter dst);

        /// <summary>
        /// Emits x86 encoded assembly that reifies a stream of methods to a caller-supplied writer
        /// </summary>
        /// <param name="src">The methods to capture</param>
        /// <param name="dst">The capture target</param>
        void SaveBits(MethodInfo[] src, IAsmHexWriter dst);
        
        /// <summary>
        /// Closes a generic method definition over supplied type arguments and captures the native x86 encoded assembly produced by the jitter
        /// </summary>
        /// <param name="src">The generic method definition, obtained by MethodInfo.GetGenericMethodDefinition</param>
        /// <param name="args">The types over which to close the generic method</param>
        /// <param name="dst">The target buffer</param>
        void SaveBits(MethodInfo src, Type[] args, IAsmHexWriter dst);

        /// <summary>
        /// Captures the native x86 encoded assembly produced by the jitterCaptures and sends the content to a target writer
        /// </summary>
        /// <param name="m">The source method</param>
        /// <param name="dst">The target writer</param>
        void SaveBits(Delegate src, IAsmHexWriter dst);
    }
        
    public interface IAsmCapture : IAsmService
    {
        void SaveAsm(Delegate src, IAsmFunctionWriter dst);

        void SaveAsm(MethodInfo src, IAsmFunctionWriter dst);

        void SaveAsm(MethodInfo src, Type[] args, IAsmFunctionWriter dst);

        void SaveAsm(MethodInfo[] src, Type[] args, IAsmFunctionWriter dst);  

        void SaveAsm(MethodInfo[] src, IAsmFunctionWriter dst);      
    }

    public interface IAsmCaptureService : INativeCapture, IAsmCapture, IAsmExtract, INativeExtract
    {

    } 

}