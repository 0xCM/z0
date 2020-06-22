//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public readonly struct Capture
    {
        public static ICaptureServices Services 
            => default(AsmWorkflows);

        public static ICaptureCore Core 
            => CaptureCore.Service;
    }
}