//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Part;

    readonly struct CaptureAltService : ICaptureAlt
    {
        public ReadOnlySpan<ApiCaptureBlock> Capture(ReadOnlySpan<MethodInfo> src)
            => CaptureAlt.capture(src.Map(m =>  new IdentifiedMethod(m.Identify(),m)));

        public ReadOnlySpan<ApiCaptureBlock> Capture(ApiHostCatalog src)
            => CaptureAlt.capture(src);

        public ReadOnlySpan<ApiCaptureBlock> Capture(ReadOnlySpan<IdentifiedMethod> src)
            => CaptureAlt.capture(src);

        public ApiCaptureBlock Capture(MethodInfo src, OpIdentity id, Span<byte> buffer)
            => CaptureAlt.capture(src,id,buffer);

        public ApiCaptureBlock Capture(MethodInfo src, Span<byte> dst)
            => CaptureAlt.capture(src, dst);

        public ApiCaptureBlock Capture(IdentifiedMethod src)
            => CaptureAlt.capture(src);

        public ReadOnlySpan<ApiCaptureBlock> Capture(ReadOnlySpan<IdentifiedMethod> src, Span<byte> buffer)
            => CaptureAlt.capture(src, buffer);

        public ApiMemberCapture Capture(in ApiMember src, Span<byte> dst)
            => CaptureAlt.capture(src, dst);

        public ApiCaptureBlock Capture(LocatedMethod src, Span<byte> dst)
            => CaptureAlt.capture(src, dst);

        public ApiCaptureBlock Capture(IdentifiedMethod src, Span<byte> dst)
            => CaptureAlt.capture(src, dst);
    }
}