//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    public enum LocatedImageFields : byte
    {
        BaseAddress = 16,

        EndAddress = 16,

        MemorySize = 16,

        PartId = 12,

        ImageName = 60,

        Gap = 10,

        ImageSize = 10,
    }


    [StructLayout(LayoutKind.Sequential), Record(TableId)]
    public struct LocatedImageRow : IRecord<LocatedImageRow>
    {
        public const string TableId = "images.located";

        public MemoryAddress BaseAddress;

        public MemoryAddress EndAddress;

        public ByteSize MemorySize;

        public PartId PartId;

        public ByteSize Gap;

        public Name ImageName;
    }
}