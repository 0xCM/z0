//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using Z0.Asm;

    using static Part;

    readonly struct CaptureAltService : ICaptureAlt
    {
        public static ICaptureAlt create(IWfShell wf, IAsmContext asm)
            => default(CaptureAltService);

        public ReadOnlySpan<IdentifiedMethod> Identify(ReadOnlySpan<MethodInfo> src)
            => CaptureAlt.identify(src);

        public Span<LocatedMethod> Locate(ReadOnlySpan<IdentifiedMethod> src)
            => CaptureAlt.locate(src);

        public ReadOnlySpan<ApiCaptureBlock> Capture(ReadOnlySpan<MethodInfo> src)
            => CaptureAlt.capture(src.Map(m =>  new IdentifiedMethod(m.Identify(),m)));

        public ReadOnlySpan<ApiCaptureBlock> Capture(Type src)
            => CaptureAlt.capture(src);

        public ReadOnlySpan<ApiCaptureBlock> Capture(ReadOnlySpan<IdentifiedMethod> src)
            => CaptureAlt.capture(src);

        public ApiCaptureBlock Capture(MethodInfo src, OpIdentity id, Span<byte> buffer)
            => CaptureAlt.capture(src,id,buffer);

        public ApiCaptureBlock Capture(MethodInfo src)
            => CaptureAlt.capture(src);

        public ApiCaptureBlock Capture(IdentifiedMethod src)
            => CaptureAlt.capture(src);

        public ReadOnlySpan<ApiCaptureBlock> Capture(ReadOnlySpan<IdentifiedMethod> src, Span<byte> buffer)
            => CaptureAlt.capture(src, buffer);

        public ApiMemberCapture Capture(in ApiMember src, Span<byte> buffer)
            => CaptureAlt.capture(src, buffer);

        public ApiCaptureBlock Capture(LocatedMethod src, Span<byte> buffer)
            => CaptureAlt.capture(src, buffer);

        public ApiCaptureBlock Capture(IdentifiedMethod src, Span<byte> buffer)
            => CaptureAlt.capture(src,buffer);
    }
}