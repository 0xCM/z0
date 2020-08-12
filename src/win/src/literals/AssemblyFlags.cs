//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    [Flags]
    public enum AssemblyFlags
    {
        PublicKey = 1,

        Retargetable = 256,

        WindowsRuntime = 512,

        ContentTypeMask = 3584,

        DisableJitCompileOptimizer = 16384,

        EnableJitCompileTracking = 32768,
    }
}