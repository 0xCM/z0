//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface ICaptureAlt
    {
        ReadOnlySpan<ApiCaptureBlock> Capture(ReadOnlySpan<MethodInfo> src);

        ReadOnlySpan<ApiCaptureBlock> Capture(ApiHostCatalog src);

        ReadOnlySpan<ApiCaptureBlock> Capture(ReadOnlySpan<IdentifiedMethod> src);

        ApiCaptureBlock Capture(MethodInfo src, OpIdentity id, Span<byte> dst);

        ApiCaptureBlock Capture(MethodInfo src, Span<byte> dst);

        ApiCaptureBlock Capture(IdentifiedMethod src);

        ReadOnlySpan<ApiCaptureBlock> Capture(ReadOnlySpan<IdentifiedMethod> src, Span<byte> buffer);

        ApiMemberCapture Capture(in ApiMember src, Span<byte> buffer);

        ApiCaptureBlock Capture(LocatedMethod src, Span<byte> buffer);

        ApiCaptureBlock Capture(IdentifiedMethod src, Span<byte> buffer);
    }
}