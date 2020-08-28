//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    
    
    public readonly struct AsmOpCodeDataset
    {                
        public readonly AsmOpCodeTable[] Records;

        public readonly AsmOpCodeId[] OpCodeIdentifiers;

        public AsmOpCodeDataset(AsmOpCodeTable[] records, AsmOpCodeId[] identifiers)
        {
            Records = records;
            OpCodeIdentifiers = identifiers;
        }

        public int OpCodeCount 
            => Records.Length;

        [MethodImpl(Inline), Op]
        public ref readonly AsmOpCodeId opcode(int index)
            => ref OpCodeIdentifiers[index];
    }
}