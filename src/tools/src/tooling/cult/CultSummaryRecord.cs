//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    public struct CultSummaryRecord : IRecord<CultSummaryRecord>
    {
        public uint LineNumber;

        public string Mnemonic;

        public string Instruction;

        public TextBlock Content;
    }
}