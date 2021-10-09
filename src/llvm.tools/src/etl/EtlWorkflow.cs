//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Collections.Generic;

    using static core;

    public readonly struct DatasetNames
    {
        public const string X86 = "X86.records";

        public const string X86Lined = "x86.records.lined";

        public const string X86Defs = "X86.records.defs";

        public const string X86DefFields = "X86.records.defs.fields";

        public const string X86Classes = "X86.records.classes";

        public const string X86ClassMembers = "X86.records.classes.members";

    }

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
            var records = LoadSourceRecords(DatasetNames.X86);
            var result = Outcome.Success;
            ImportRecordLines(records, DatasetNames.X86Lined);
            ImportLists();
            GenerateCode();
            var classes = ImportClassRelations(records);
            var defs = ImportDefRelations(records);
            var defFields = LoadFields(records, MapContent(defs, records, DatasetNames.X86Defs));
            EmitFields(defFields, DatasetNames.X86DefFields);
            var classFields = LoadFields(records, MapContent(classes, records, DatasetNames.X86Classes));
            EmitFields(classFields, DatasetNames.X86ClassMembers);
            return true;
        }
   }
}