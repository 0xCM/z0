//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    partial class AsmCmdService
    {
        ReadOnlySpan<AsmHostRoutines> CaptureParts(params PartId[] parts)
        {
            var dst = Db.CaptureRoot();
            dst.Clear();
            return Wf.CaptureRunner().Capture(parts, dst);
        }
    }
}