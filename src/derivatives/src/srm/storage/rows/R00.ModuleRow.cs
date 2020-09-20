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
        //  0x00
        [StructLayout(LayoutKind.Sequential)]
        public struct ModuleRow
        {
            public readonly ushort Generation;

            public readonly uint Name;

            public readonly uint MVId;

            public readonly uint EnCId;

            public readonly uint EnCBaseId;
        }
    }
}