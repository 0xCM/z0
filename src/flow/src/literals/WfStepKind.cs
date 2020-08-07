//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum WfStepKind : ulong
    {
        None,

        EmitResBytes,

        EmitProjectDocs,

        EmitMetadataSets,
        
        EmitEnumCatalog,

        EmitFieldLiterals,

        EmitResCatalog,

        EmitBitMasks,

        EmitParsedReport,

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

        ExtractMembers,

        MatchEmissions,

        ManagePartCapture,

        EmitDatasets,

        CaptureHosts,

        ClearCaptureArchives,

        ExtractHostMembers,

        DecodeParsed,

        CaptureHostApi,

        RunProcessors,

        ParseAsmFiles,

        SpecializeImmediates,

        EmitHostArtifacts,       

        EmitImageSummaries,
    }
}