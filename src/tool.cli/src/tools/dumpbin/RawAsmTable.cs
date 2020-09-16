//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = RawAsmField;

    public enum RawAsmField : ushort
    {
        Sequence = 8,

        Address = 17,

        Mnemonic = 13,

        Instruction = 60
    }

    public readonly struct RawAsmTable : ITable<RawAsmField,RawAsmTable>
    {
        public static RawAsmTable Empty
            => new RawAsmTable(0, 0, EmptyString, EmptyString);

        public readonly uint Sequence;

        public readonly MemoryAddress Address;

        public readonly string Mnemonic;

        public readonly string Instruction;

        [MethodImpl(Inline)]
        public RawAsmTable(uint sequence, MemoryAddress address, string mnemonic, string instruction)
        {
            Sequence = sequence;
            Address = address;
            Mnemonic = mnemonic;
            Instruction = instruction;
        }
    }

    partial class XTend
    {
        public static string Format(this RawAsmTable src)
        {
            var dst = Table.formatter<RawAsmField>();
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.Address, src.Address);
            dst.Delimit(F.Mnemonic, src.Mnemonic);
            dst.Delimit(F.Instruction, src.Instruction);
            return dst.Format();
        }

        public static string FormatHeader(this RawAsmTable src)
            => Table.formatter<RawAsmField>().FormatHeader();
    }
}