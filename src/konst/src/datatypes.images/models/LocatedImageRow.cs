//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;


    [StructLayout(LayoutKind.Sequential), Record(TableId)]
    public struct LocatedImageRow : IRecord<LocatedImageRow>
    {
        public const string TableId = "images.located";

        public enum Widths : byte
        {
            ImageName = 60,

            PartId = 12,

            EntryAddress = 16,

            BaseAddress = 16,

            EndAddress = 16,

            Size = 10,

            Gap = 10
        }

        public Name ImageName;

        public PartId PartId;

        public MemoryAddress EntryAddress;

        public MemoryAddress BaseAddress;

        public MemoryAddress EndAddress;

        public ByteSize Size;

        public ByteSize Gap;
    }
}