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
        IWfShell Wf {get;}

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

        ReadOnlySpan<IdentifiedMethod> Identify(ReadOnlySpan<MethodInfo> src);

        Span<LocatedMethod> Locate(ReadOnlySpan<MethodInfo> src);

        Span<LocatedMethod> Locate(ReadOnlySpan<IdentifiedMethod> src);

        ReadOnlySpan<ApiCaptureBlock> Capture(ReadOnlySpan<MethodInfo> src);

        ReadOnlySpan<ApiCaptureBlock> Capture(Type src);

        ReadOnlySpan<ApiCaptureBlock> Capture(ReadOnlySpan<IdentifiedMethod> src);

        ApiCaptureBlock Capture(MethodInfo src, OpIdentity id, Span<byte> buffer);

        ApiCaptureBlock Capture(MethodInfo src);

        ApiCaptureBlock Capture(IdentifiedMethod src);

        ReadOnlySpan<ApiCaptureBlock> Capture(ReadOnlySpan<IdentifiedMethod> src, Span<byte> buffer);

        ApiMemberCapture Capture(in ApiMember src, Span<byte> buffer);

        ApiCaptureBlock Capture(LocatedMethod src, Span<byte> buffer);

        ApiCaptureBlock Capture(IdentifiedMethod src, Span<byte> buffer);

        ReadOnlySpan<AsmRoutineCode> Decode(ReadOnlySpan<MethodInfo> src, FS.FilePath target);

        void Decode(ReadOnlySpan<ApiCaptureBlock> src, Span<AsmRoutineCode> dst);

        ReadOnlySpan<AsmRoutineCode> Decode(ReadOnlySpan<ApiCaptureBlock> src, FS.FilePath target);
    }
}