//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using System;
    using System.Runtime.InteropServices;

    using static Part;

    [StructLayout(LayoutKind.Sequential)]
    public struct DirectoryEntry
    {
        public uint RelativeVirtualAddress;

        public uint Size;
    }

}