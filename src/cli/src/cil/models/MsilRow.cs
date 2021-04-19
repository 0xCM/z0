//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record(TableId)]
    public struct MsilRow : IRecord<MsilRow>
    {
        public const string TableId = "image.msil";

        public FS.FileName ImageName;

        public Address32 MethodRva;

        public ByteSize BodySize;

        public ByteSize MaxStack;

        public string MethodName;

        public BinaryCode Code;
    }
}