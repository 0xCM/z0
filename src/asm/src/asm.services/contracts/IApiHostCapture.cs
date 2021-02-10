//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IApiHostCapture
    {
        ApiCaptureBlocks CaptureHost(in ApiHostCatalog src);

        ApiHostCaptureSet EmitCaptureSet(Type host);
    }
}