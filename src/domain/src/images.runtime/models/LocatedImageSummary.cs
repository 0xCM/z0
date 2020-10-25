//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct LocatedImageSummary
    {
        public enum Fields : ushort
        {
            ImageName = 60,

            PartId = 12,

            EntryAddress = 16,

            BaseAddress = 16,

            EndAddress = 16,

            Size = 10,

            Gap = 10
        }

        public StringRef ImageId;

        public PartId PartId;

        public MemoryAddress EntryAddress;

        public MemoryAddress BaseAddress;

        public MemoryAddress EndAddress;

        public ByteSize Size;

        public ByteSize Gap;
    }
}