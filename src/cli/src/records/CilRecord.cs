//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record(TableId)]
    public struct CilRecord : IRecord<CilRecord>
    {
        public const string TableId = "cli.cil";

        public BinaryCode MethodSig;

        public string MethodName;

        public Address32 Rva;

        public BinaryCode Cil;

        public ByteSize Size;
    }
}