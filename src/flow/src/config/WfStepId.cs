//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum WfStepId : ulong
    {
        None,

        EmitResBytes,

        EmitProjectDocs,

        EmitMetadataSets,
        
        EmitEnumCatalog,

        EmitFieldLiterals,

        EmitResCatalog,

        EmitBitMasks,

        EmitFieldMetadata,

        EmitBlobs,

        EmitCilDatasets,

        EmitConstantDatasets,

        EmitContentCatalog,

        EmitPartStrings,


        EmitPeImage,
        
        EmitImageContent,

        EmitLiteralDatasets,


        EmitPeHeaders,

        AnalyzeCalls,

        MatchEmissions,

        EmitDatasets,

        CaptureHosts,

        ClearCaptureArchives,

        ParseMembers,

        DecodeParsed,

        CaptureHostApi,
    }
}