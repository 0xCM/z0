//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;
    using static memory;

    public interface IApiHostCapture
    {
        ApiHostCaptureSet EmitCaptureSet(Type host);
    }
}