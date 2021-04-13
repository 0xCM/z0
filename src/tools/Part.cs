//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Tools)]

namespace Z0.Parts
{
    public sealed class Tools : Part<Tools>
    {
        public static PartAssets Assets => new PartAssets();

        public sealed class PartAssets : Assets<PartAssets>
        {
            public ResDescriptor NasmInstructions() => Asset("nasm-instructions.txt");

            public ResDescriptor XedInstructionData() => Asset("xed-idata.txt");

            public ResDescriptor XedChipData() => Asset("xed-cdata.txt");
        }
    }
}