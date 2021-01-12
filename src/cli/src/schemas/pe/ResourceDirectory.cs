//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Pe
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct ResourceDirectory : IRecord<ResourceDirectory>
    {
        public const string TableId = "pe.resdir";

        public uint Characteristics;

        public uint Timestamp;

        public ushort MajorVersion;

        public ushort MinorVersion;

        public ushort NumberOfNamedEntries;

        public ushort NumberOfIdEntries;
    }
}
