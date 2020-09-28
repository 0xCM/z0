//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Asm;

    [WfHost]
    public sealed class CaptureControlHost : WfHost<CaptureControlHost>
    {
        public static CaptureControl create(WfCaptureState state)
            => new CaptureControl(state, new CaptureControlHost());
    }
}