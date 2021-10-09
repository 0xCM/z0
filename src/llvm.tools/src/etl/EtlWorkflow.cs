//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Collections.Generic;

    using static core;

    public partial class EtlWorkflow : AppService<EtlWorkflow>
    {
        LlvmPaths LlvmPaths;

        OmniScript OmniScript;

        HashSet<string> ClassExclusions {get;}
            = hashset<string>("Hexagon", "Neon", "PowerPC", "RISCV", "SystemZ", "Hexagom", "AMDGPU");

        public EtlWorkflow()
        {
        }

        protected override void Initialized()
        {
            LlvmPaths = Wf.LlvmPaths();
            OmniScript = Wf.OmniScript();
        }

        void GenerateCode()
        {
            LlvmPaths.CodeGenRoot().Clear();
            GenStringTables();
        }

        public Outcome RunEtl()
        {
            var records = LoadSourceRecords();
            var result = Outcome.Success;
            ImportRecordLines(records,"x86.records.lined");
            ImportLists();
            GenerateCode();
            var classes = ImportClassRelations(records);
            var defs = ImportDefRelations(records);
            var defFields = LoadFields(records, MapContent(defs, records, "X86.records.defs"));
            EmitFields(defFields, "llvm.defs.fields");
            var classFields = LoadFields(records, MapContent(classes, records, "X86.records.classes"));
            EmitFields(classFields, "llvm.classes.fields");
            return true;
        }
   }
}