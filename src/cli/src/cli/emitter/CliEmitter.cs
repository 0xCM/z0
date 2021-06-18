//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public sealed partial class CliEmitter : AppService<CliEmitter>
    {
        public void EmitMetadataSets(CliEmissionOptions options)
        {
            if(options.EmitAssemblyRefs)
                EmitAssemblyRefs();

            if(options.EmitFieldMetadata)
            {
                EmitFieldMetadata();
                EmitFieldDefs(Wf.ApiCatalog.Components, Db.IndexTable<FieldDefInfo>());
            }

            if(options.EmitApiMetadata)
                EmitApiMetadump();

            if(options.EmitSectionHeaders)
                EmitSectionHeaders();

            if(options.EmitMsilMetadata)
                EmitMsilMetadata();

            if(options.EmitCliStrings)
            {
                EmitUserStrings();
                EmitSystemStringInfo();
            }

            if(options.EmitCliConstants)
                EmitConstants();

            if(options.EmitCliBlobs)
                EmitBlobs();

            if(options.EmitImageContent)
                EmitImageContent();

            if(options.EmitRowStats)
                EmitRowStats(Wf.ApiCatalog.Components, Db.IndexTable<CliRowStats>());

            if(options.EmitMethodDefs)
                EmitMethodDefs(Wf.ApiCatalog.Components, Db.IndexTable<MethodDefInfo>());
        }

        public void EmitMetadaSets(WorkflowOptions options)
        {
            if(options.EmitAssemblyRefs)
                EmitAssemblyRefs();

            if(options.EmitFieldMetadata)
                EmitFieldMetadata();

            if(options.EmitApiMetadata)
                EmitApiMetadump();

            if(options.EmitSectionHeaders)
                EmitSectionHeaders();

            if(options.EmitMsilMetadata)
                EmitMsilMetadata();

            if(options.EmitCliStrings)
            {
                EmitUserStrings();
                EmitSystemStringInfo();
            }

            if(options.EmitCliConstants)
                EmitConstants();

            if(options.EmitCliBlobs)
                EmitBlobs();

            if(options.EmitImageContent)
                EmitImageContent();
        }
    }
}