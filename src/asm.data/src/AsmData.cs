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
        public static AsmDataSources Assets => AsmDataSources.create();

        public sealed class AsmDataSources : Assets<AsmDataSources>
        {
            public Asset AsmDbInstructions() => Asset("asmdb.instructions.csv");

            public Asset AsmDbOperands() => Asset("asmdb.operands.csv");

            public Asset FeatureMnemonics() => Asset("feature-mnemonics.csv");

            public Asset IntelIntrinsicsXml() => Asset("intel-intrinsics.xml");

            public Asset StanfordAsmCatalog() => Asset("stanford-asm-catalog.csv");
        }
    }
}