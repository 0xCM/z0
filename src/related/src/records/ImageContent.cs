//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct ImageContent : IRecord<ImageContent>
    {
        public const string TableId = "image.content";

        public const byte RowDataSize = 64;

        public MemoryAddress Address;

        public BinaryCode Data;
    }
}