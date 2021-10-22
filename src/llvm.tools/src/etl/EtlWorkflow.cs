//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
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

        public Outcome RunEtl()
        {
            var dst = new EtlDatasets();
            var records = LoadSourceRecords(DatasetNames.X86);
            dst.Records = records;
            ImportRecordLines(records, DatasetNames.X86Lined);
            var lists = ImportLists();
            dst.Lists = lists;
            var classes = ImportClassRelations(records);
            dst.ClassRelations = classes;
            var defs = ImportDefRelations(records);
            dst.DefRelations = defs;
            var defFields = LoadFields(records, MapContent(defs, records, DatasetNames.X86Defs));
            dst.Defs = defFields;
            EmitFields(defFields, DatasetNames.X86DefFields);
            var classFields = LoadFields(records, MapContent(classes, records, DatasetNames.X86Classes));
            dst.Classes = classFields;
            EmitFields(classFields, DatasetNames.X86ClassMembers);
            Wf.LlvmGenerator().Run(dst);
            return true;
        }
   }
}