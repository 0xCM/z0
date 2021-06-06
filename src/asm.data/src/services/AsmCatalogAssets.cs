//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public sealed class AsmCatalogAssets : Assets<AsmCatalogAssets>
    {
        public Asset StanfordAsmCatalog() => Asset("stanford-asm-catalog.csv");

        public Asset InstrinsicXml() => Asset("intel-intrinsics.xml");

        public Asset AsmDbInstructions() => Asset("asmdb.instructions.csv");

        public Asset AsmDbOperands() => Asset("asmdb.operands.csv");

        public Asset XedTables() => Asset("xed-tables.txt");

        public Asset XedInstructionSummary() => Asset("xed-idata.txt");

        public Asset XedChipData() => Asset("xed-cdata.txt");

        public Asset NasmInstructions() => Asset("nasm-instructions.txt");

        public Asset NasmCodes() => Asset("nasm-codes.txt");

        public Asset NasmFlags() => Asset("nasm-flags.txt");

        public Asset CpuidBits() => Asset("cpuid-bits.csv");

        public Asset FeatureMnemonics() => Asset("feature-mnemonics.csv");
    }
}