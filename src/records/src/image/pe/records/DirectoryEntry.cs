//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    partial struct Pe
    {
        [Record, StructLayout(LayoutKind.Sequential)]
        public struct DirectoryEntry
        {
            public Address32 Rva;

            public uint Size;
        }
    }
}