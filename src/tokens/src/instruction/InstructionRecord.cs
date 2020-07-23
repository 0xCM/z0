//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.DataModels
{            

    using Z0.Asm;

    public readonly struct InstructionRecord
    {
        public readonly OffsetSequence Offset;

        public readonly OpCodeId OpCode;
    }

}