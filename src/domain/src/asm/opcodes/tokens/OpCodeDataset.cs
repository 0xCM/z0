//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;    
    
    public readonly struct OpCodeDataset
    {                
        public readonly OpCodeRecord[] Records;

        public readonly OpCodeIdentifier[] OpCodeIdentifiers;

        public OpCodeDataset(OpCodeRecord[] records, OpCodeIdentifier[] identifiers)
        {
            Records = records;
            OpCodeIdentifiers = identifiers;
        }

        public int OpCodeCount 
            => Records.Length;

        [MethodImpl(Inline), Op]
        public ref readonly OpCodeIdentifier opcode(int index)
            => ref OpCodeIdentifiers[index];
    }
}