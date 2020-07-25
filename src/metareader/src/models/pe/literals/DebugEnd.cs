//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct PeFile
    {
        internal enum DebugEnd
        {
            Passive,
            ActiveTerminate,
            ActiveDetatch,
            EndReentrant,
            EndDisconnect
        }

    }
}