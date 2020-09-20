//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static Part;

    partial struct ClrStorage
    {
        //  0x14
        [StructLayout(LayoutKind.Sequential)]
        public struct EventRow
        {
            public EventFlags Flags;

            public uint Name;

            public uint EventType;
        }
    }

}