//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System.Runtime.InteropServices;

    partial struct Pe
    {
        [StructLayout(LayoutKind.Sequential), Record]
        public struct DirectoryEntry : IRecord<DirectoryEntry>
        {
            public Address32 Rva;

            public uint Size;
        }
    }
}