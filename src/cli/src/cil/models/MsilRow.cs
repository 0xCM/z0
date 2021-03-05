//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record(TableId)]
    public struct MsilRow : IRecord<MsilRow>
    {
        public const string TableId = "msil";

        public BinaryCode MethodSig;

        public string MethodName;

        public Address32 Rva;

        public BinaryCode Code;

        public ByteSize Size;
    }
}