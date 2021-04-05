//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [Record(TableId)]
    public struct CultSummaryRecord : IRecord<CultSummaryRecord>
    {
        public const string TableId = "cult.summary";

        public uint LineNumber;

        public Identifier Id;

        public AsmMnemonic Mnemonic;

        public string Instruction;

        public TextBlock Content;
    }
}