//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    [ApiHost]
    public readonly partial struct AsmData
    {
        public static AssetData Assets => AssetData.create();

        public sealed class AssetData : Assets<AssetData>
        {
            public Asset AsmDbInstructions() => Asset("asmdb.instructions.csv");

            public Asset AsmDbOperands() => Asset("asmdb.operands.csv");

            public Asset CpuidBits() => Asset("cpuid-bits.csv");

            public Asset FeatureMnemonics() => Asset("feature-mnemonics.csv");

            public Asset IntelIntrinsicsXml() => Asset("intel-intrinsics.xml");

            public Asset LlvmMnemonics() => Asset("llvm-mnemonics.txt");

            public Asset NasmInstructions() => Asset("nasm-instructions.txt");

            public Asset NasmCodes() => Asset("nasm-codes.txt");

            public Asset NasmFlags() => Asset("nasm-flags.txt");

            public Asset StanfordAsmCatalog() => Asset("stanford-asm-catalog.csv");

            public Asset XedInstructionSummary() => Asset("xed-idata.txt");

            public Asset XedChipData() => Asset("xed-cdata.txt");

            public Asset XedTables() => Asset("xed-tables.txt");
        }
    }
}