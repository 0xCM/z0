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

        EmitClrMetadataSets,
        
        EmitEnumDatasets,

        EmitLiteralDatasets,

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

        EmitFieldLiterals,


        EmitPeHeaders,
    }
}