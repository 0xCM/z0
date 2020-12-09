//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System.Runtime.InteropServices;

    partial struct Pe
    {
        [Record, StructLayout(LayoutKind.Sequential)]
        public struct DirectoryEntry : IRecord<DirectoryEntry>
        {
            public Address32 Rva;

            public uint Size;
        }
    }
}