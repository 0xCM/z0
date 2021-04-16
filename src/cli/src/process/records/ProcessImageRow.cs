//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct ProcessImageRow : IRecord<ProcessImageRow>
    {
        public const string TableId = "process.images";

        public MemoryAddress BaseAddress;

        public MemoryAddress EndAddress;

        public ByteSize Size;

        public ByteSize Gap;

        public Name ImageName;
    }
}