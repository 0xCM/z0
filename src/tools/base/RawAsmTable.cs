//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [Table]
    public readonly struct RawAsmTable : ITable<RawAsmTable>
    {        
        public readonly uint Sequence;
        
        public readonly MemoryAddress Address;

        public readonly string Mnemonic;

        public readonly string Instruction;

        public RawAsmTable(uint sequence, MemoryAddress address, string mnemonic, string instruction)
        {
            Sequence = sequence;
            Address = address;
            Mnemonic = mnemonic;
            Instruction = instruction;
        }
    }
}
