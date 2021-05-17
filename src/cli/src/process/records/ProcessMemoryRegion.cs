//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Windows;
    using System.Runtime.InteropServices;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct ProcessMemoryRegion : IRecord<ProcessMemoryRegion>
    {
        public const string TableId = "image.memory.regions";

        public const byte FieldCount = 9;

        public uint Index;

        public Name Identity;

        public MemoryAddress StartAddress;

        public MemoryAddress EndAddress;

        public ByteSize Size;

        public MemType Type;

        public PageProtection Protection;

        public MemState State;

        public TextBlock FullIdentity;
    }
}