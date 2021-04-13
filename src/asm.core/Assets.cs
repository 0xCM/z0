//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Parts
{
    partial class AsmCore
    {
        public static PartAssets Assets = new PartAssets();

        public static IAssets AssetSet
            => Assets;

        public sealed class PartAssets : Assets<PartAssets>
        {
            public ResDescriptor StanfordAsmCatalog() => Asset("stanford_asm_catalog.csv");

            public ResDescriptor InstrinsicXml() => Asset("intel-intrinsics.xml");

            public ResDescriptor AsmDbInstructions() => Asset("asmdb.instructions.csv");

            public ResDescriptor AsmDbOperands() => Asset("asmdb.operands.csv");

            public ResDescriptor XedTables() => Asset("xed-tables.txt");

            public ResDescriptor XedInstructionData() => Asset("xed-idata.txt");

            public ResDescriptor XedChipData() => Asset("xed-cdata.txt");

            public ResDescriptor NasmInstructions() => Asset("nasm-instructions.txt");

            public ResDescriptor NasmCodes() => Asset("nasm-codes.txt");

            public ResDescriptor NasmFlags() => Asset("nasm-flags.txt");
        }
    }
}