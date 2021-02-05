//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;

    public interface IAsmWf
    {
        /// <summary>
        /// The workflow context in use
        /// </summary>
        IWfShell Wf {get;}

        /// <summary>
        /// The asm context in use
        /// </summary>
        IAsmContext Asm {get;}

        /// <summary>
        /// The default asm formatting configuration
        /// </summary>
        AsmFormatConfig FormatConfig {get;}

        /// <summary>
        /// The context formatter
        /// </summary>
        IAsmFormatter Formatter {get;}

        /// <summary>
        /// The context decoder
        /// </summary>
        IAsmDecoder Decoder {get;}

        ICaptureAlt CaptureService {get;}


        ReadOnlySpan<AsmRoutineCode> Decode(ReadOnlySpan<MethodInfo> src, FS.FilePath target);

        void Decode(ReadOnlySpan<ApiCaptureBlock> src, Span<AsmRoutineCode> dst);

        ReadOnlySpan<AsmRoutineCode> Decode(ReadOnlySpan<ApiCaptureBlock> src, FS.FilePath target);
    }
}