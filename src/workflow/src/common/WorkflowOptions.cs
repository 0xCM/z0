//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public struct WorkflowOptions : ISettingsSet<WorkflowOptions>
    {
        public Setting<bool> EmitAssetIndex;

        public Setting<bool> CollectApiDocs;

        public Setting<bool> EmitImageContent;

        public Setting<bool> EmitSectionHeaders;

        public Setting<bool> EmitMsilMetadata;

        public Setting<bool> EmitCliStrings;

        public Setting<bool> EmitCliBlobs;

        public Setting<bool> EmitAssemblyRefs;

        public Setting<bool> EmitCliConstants;

        public Setting<bool> EmitApiMetadump;

        public Setting<bool> EmitApiClasses;

        public Setting<bool> EmitFieldMetadata;

        public Setting<bool> EmitSymbolicLiterals;

        public Setting<bool> EmitXedCatalogs;

        public Setting<bool> EmitAsmRows;

        public Setting<bool> EmitResBytes;

        public Setting<bool> EmitAsmAnalysis;

        public Setting<bool> EmitIntrinsicsInfo;

        public Setting<bool> EmitAsmStatements;

        public Setting<bool> CorrelateMembers;

        public Setting<bool> EmitAssetContent;

        public Setting<bool> EmitApiBitMasks;

        public Setting<bool> EmitHexIndex;

        public Setting<bool> EmitCallData;

        public Setting<bool> EmitJmpData;

        public Setting<bool> EmitHexPack;

        public Setting<bool> ProcessCultFiles;

        public static WorkflowOptions @default()
        {
            var dst = new WorkflowOptions();
            dst.CollectApiDocs = true;
            dst.EmitImageContent = true;
            dst.EmitSectionHeaders = true;
            dst.EmitMsilMetadata = true;
            dst.EmitCliStrings = true;
            dst.EmitCliBlobs = true;
            dst.EmitCliConstants = true;
            dst.EmitFieldMetadata = true;
            dst.EmitXedCatalogs = true;
            dst.EmitAsmRows = true;
            dst.EmitResBytes = true;
            dst.EmitAsmAnalysis = true;
            dst.EmitIntrinsicsInfo = true;
            dst.EmitAsmStatements = true;
            dst.EmitApiMetadump = true;
            dst.CorrelateMembers = true;
            dst.EmitAssetIndex = true;
            dst.EmitAssetContent = false;
            dst.EmitSymbolicLiterals = true;
            dst.EmitApiBitMasks = true;
            dst.EmitHexIndex = true;
            dst.EmitCallData = false;
            dst.EmitJmpData = false;
            dst.EmitHexPack = true;
            dst.ProcessCultFiles = false;
            dst.EmitAssemblyRefs = true;
            dst.EmitApiClasses = true;
            return dst;
        }

        public override string ToString()
            => (this as ISettingsSet).Format();
    }
}