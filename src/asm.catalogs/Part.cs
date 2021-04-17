//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.AsmCatalogs)]
namespace Z0.Parts
{
    public sealed partial class AsmCatalogs : Part<AsmCatalogs>
    {
        public static PartAssets Assets = new PartAssets();

        public static IAssets AssetSet
            => Assets;

        public AsmCatalogs()
        {
        }

        public sealed class PartAssets : Assets<PartAssets>
        {
            public ResDescriptor StanfordAsmCatalog() => Asset("stanford-asm-catalog.csv");

            public ResDescriptor InstrinsicXml() => Asset("intel-intrinsics.xml");

            public ResDescriptor AsmDbInstructions() => Asset("asmdb.instructions.csv");

            public ResDescriptor AsmDbOperands() => Asset("asmdb.operands.csv");

            public ResDescriptor XedTables() => Asset("xed-tables.txt");

            public ResDescriptor XedInstructionSummary() => Asset("xed-idata.txt");

            public ResDescriptor XedChipData() => Asset("xed-cdata.txt");

            public ResDescriptor NasmInstructions() => Asset("nasm-instructions.txt");

            public ResDescriptor NasmCodes() => Asset("nasm-codes.txt");

            public ResDescriptor NasmFlags() => Asset("nasm-flags.txt");

        }
    }
}

namespace Z0
{
    [ApiHost]
    public static partial class XTend
    {

    }

}