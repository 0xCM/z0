//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
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

        void IndexLists(ref EtlDatasets ds)
        {
            var index = dict<Identifier,uint>();
            var count = ds.Lists.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var list = ref skip(ds.Lists,i);
                index[list.ListName] = i;
            }
            ds.ListIndex = index;
        }

        public Outcome RunEtl()
        {
            var dst = new EtlDatasets();
            var records = LoadSourceRecords(EtlDatasetNames.X86);
            dst.Records = records;
            ImportRecordLines(records, EtlDatasetNames.X86Lined);
            var lists = ImportLists();
            dst.Lists = lists;
            var classes = ImportClassRelations(records);
            dst.ClassRelations = classes;
            var defs = ImportDefRelations(records);
            dst.DefRelations = defs;
            var defMap = EmitLineMap(defs, records, EtlDatasetNames.X86Defs);
            dst.DefMap = defMap;
            var defFields = LoadFields(records, defMap);
            dst.Defs = defFields;
            EmitFields(defFields, EtlDatasetNames.X86DefFields);
            var classMap = EmitLineMap(classes, records, EtlDatasetNames.X86Classes);
            dst.ClassMap = classMap;
            var classFields = LoadFields(records, classMap);
            dst.Classes = classFields;
            EmitFields(classFields, EtlDatasetNames.X86ClassMembers);
            IndexLists(ref dst);
            Wf.LlvmGenerator().Run(dst);
            return true;
        }
   }
}