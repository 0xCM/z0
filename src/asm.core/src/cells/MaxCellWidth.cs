//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmCells
    {
        public enum MaxCellWidth : ushort
        {
            None = 0,

            Sequence = 12,

            GlobalOffset = 16,

            BlockAddress = 16,

            IP = 16,

            BlockOffset = 16,

            Statement = 64,

            EncodedBytes = 32,

            FormSig = 64,

            OpCode = 32,

            Bitstring = 180,

            OpUri = 180,
        }
    }
}