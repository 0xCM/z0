//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    [Record(TableId)]
    public struct NasmEncoding : IRecord<NasmEncoding>
    {
        public const string TableId = "nasm.encoding";

        public uint LineNumber;

        public MemoryAddress Offset;

        public TextBlock SourceText;

        public BinaryCode Encoded;
    }
}