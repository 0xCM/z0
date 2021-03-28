//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    [Record(TableId)]
    public struct NasmListEntry : IRecord<NasmListEntry>
    {
        public const string TableId = "nasm.listing";

        public uint LineNumber;

        public Identifier Label;

        public MemoryAddress Offset;

        public BinaryCode Encoding;

        public TextBlock SourceText;
    }
}