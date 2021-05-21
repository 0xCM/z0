//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public sealed partial class CliPipe : AppService<CliPipe>
    {
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
                Emitted(EmitUserStringInfo());
                EmitSystemStringInfo();
            }

            if(options.EmitCliConstants)
                EmitConstants();

            if(options.EmitCliBlobs)
                EmitBlobs();

            if(options.EmitImageContent)
                EmitImageContent();
        }

        void Emitted<T>(ReadOnlySpan<T> src)
        {

        }
    }
}