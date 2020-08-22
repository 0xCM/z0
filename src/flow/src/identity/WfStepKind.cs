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

        EmitAsmTables,

        EmitPeImage,
        
        EmitImageContent,

        EmitLiteralDatasets,


        EmitPeHeaders,

        AnalyzeCalls,

        ExtractMembers,

        MatchEmissions,


        MatchAddresses,

        ManagePartCapture,

        EmitDatasets,

        CaptureHosts,

        ClearCaptureArchives,

        ExtractHostMembers,

        DecodeParsed,

        CaptureHostMembers,

        RunProcessors,

        ParseAsmFiles,

        SpecializeImmediates,

        EmitHostArtifacts,       

        EmitImageSummaries,

        IndexEncodedParts,

        ListFormatPatterns
    }
}