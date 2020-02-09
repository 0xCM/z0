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
    /// Defines service contract for capturing native x86 *decoded* assembly produced by the jitter.
    /// Capturing, by definition, first requires extraction, which is delegated to an extraction service
    /// </summary>
    public interface IAsmCapture : IAsmService
    {
        void CaptureAsm(in CaptureExchange exchange, Delegate src, IAsmFunctionWriter dst);

        void CaptureAsm(in CaptureExchange exchange, MethodInfo src, IAsmFunctionWriter dst);

        void CaptureAsm(in CaptureExchange exchange, MethodInfo src, Type[] args, IAsmFunctionWriter dst);

        void CaptureAsm(in CaptureExchange exchange, MethodInfo[] src, IAsmFunctionWriter dst);      
    }
}