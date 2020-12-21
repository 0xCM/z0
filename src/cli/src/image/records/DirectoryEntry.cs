//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Images
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential), Record]
    public struct ImageDirectoryEntry : IRecord<ImageDirectoryEntry>
    {
        public Address32 Rva;

        public uint Size;
    }
}