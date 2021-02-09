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
        ApiCaptureBlocks Capture(ReadOnlySpan<MethodInfo> src);

        ApiCaptureBlocks Capture(in ApiHostCatalog src);

        ApiCaptureBlocks Capture(ReadOnlySpan<IdentifiedMethod> src);

        ApiCaptureBlock Capture(MethodInfo src, OpIdentity id, Span<byte> dst);

        ApiCaptureBlock Capture(MethodInfo src, Span<byte> dst);

        ApiCaptureBlock Capture(IdentifiedMethod src);

        ApiCaptureBlocks Capture(ReadOnlySpan<IdentifiedMethod> src, Span<byte> buffer);

        ApiMemberCapture Capture(in ApiMember src, Span<byte> buffer);

        ApiCaptureBlock Capture(LocatedMethod src, Span<byte> buffer);

        ApiCaptureBlock Capture(IdentifiedMethod src, Span<byte> buffer);

        ApiCaptureBlocks Capture(Type src);
    }
}