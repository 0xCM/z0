//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Pe
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential), Record(TableId)]
    public struct ImageDirectoryEntry : IRecord<ImageDirectoryEntry>
    {
        public const string TableId = "pe.directory-entry";

        public Address32 Rva;

        public uint Size;
    }
}