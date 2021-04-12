//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.AsmLang)]
namespace Z0.Parts
{
    public sealed class AsmLang : Part<AsmLang>
    {
        public static PartAssets Assets => new PartAssets();


        public sealed class PartAssets : Assets<PartAssets>
        {
            public ResDescriptor AsmCatalog() => Asset("AsmCatalog.csv");

            public ResDescriptor AsmMnemonicInfo() => Asset("AsmMnemonicInfo.csv");

            public ResDescriptor InstrinsicXml() => Asset("intel-intrinsics.xml");

            public ResDescriptor AsmDbInstructions() => Asset("asmdb.instructions.csv");

            public ResDescriptor AsmDbOperands() => Asset("asmdb.operands.csv");


            public ResDescriptor NasmInstructions() => Asset("nasm-instructions.txt");
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