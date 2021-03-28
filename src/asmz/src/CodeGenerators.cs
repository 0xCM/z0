//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    public sealed class CodeGenerators : WfService<CodeGenerators>
    {
        public void GenerateAsmModels()
        {
            var catalog = Wf.AsmCatalogEtl();

            Wf.AsmCodeGenerator().GenerateModels(catalog.Mnemonics());
        }

        public void GenerateBitSequences()
        {
            Wf.BitCmd().Run(BitCmdKind.GenBitSequences);
        }
    }

    public static partial class XTend
    {
        public static CodeGenerators CodeGenerators(this IWfShell wf)
            => Z0.CodeGenerators.create(wf);
    }
}