//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct Images
    {
        [Record(TableId), StructLayout(LayoutKind.Sequential)]
        public struct ResourceDirectory : IRecord<ResourceDirectory>
        {
            public const string TableId = "resources-directory";

            public uint Characteristics;

            public uint Timestamp;

            public ushort MajorVersion;

            public ushort MinorVersion;

            public ushort NumberOfNamedEntries;

            public ushort NumberOfIdEntries;
        }
    }
}
