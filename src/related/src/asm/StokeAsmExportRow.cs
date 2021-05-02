//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.InteropServices;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct StokeAsmExportRow : IRecord<StokeAsmExportRow>
    {
        public const string TableId = "stoke.export";

        public ushort Sequence;

        public string OpCode;

        public string Instruction;

        public bool Mode64;

        public string LegacyMode;

        public string EncodingKind;

        public string Properties;

        public string ImplicitRead;

        public string ImplicitWrite;

        public string ImplicitUndef;

        public string Protected;

        public string Cpuid;

        public string AttMnemonic;

        public string Description;
    }
}