//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Windows;
    using System.Runtime.InteropServices;

    partial struct Images
    {
        [Record(TableId), StructLayout(LayoutKind.Sequential)]
        public struct MemoryRegion : IRecord<MemoryRegion>
        {
            public const string TableId = "image.memory.regions";

            public const byte FieldCount = 8;

            public Name Identity;

            public MemoryAddress BaseAddress;

            public MemoryAddress EndAddress;

            public ByteSize Size;

            public MemType Type;

            public PageProtection Protection;

            public MemState State;

            public TextBlock FullIdentity;
        }
    }
}