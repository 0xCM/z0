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

        public Setting<bool> EmitCliConstants;

        public Setting<bool> EmitApiMetadata;

        public Setting<bool> EmitApiClasses;

        public Setting<bool> EmitFieldMetadata;

        public Setting<bool> EmitSymbolicLiterals;

        public Setting<bool> EmitAsmCatalogs;

        public Setting<bool> EmitAsmRows;

        public Setting<bool> EmitResBytes;

        public Setting<bool> EmitAsmAnalysis;

        public Setting<bool> EmitIntrinsicsInfo;

        public Setting<bool> EmitStatements;

        public Setting<bool> CorrelateMembers;

        public Setting<bool> EmitAssetContent;

        public Setting<bool> EmitApiBitMasks;

        public Setting<bool> EmitHexIndex;

        public Setting<bool> EmitCallData;

        public Setting<bool> EmitJmpData;

        public Setting<bool> EmitHexPack;

        public Setting<bool> ProcessCultFiles;

        public Setting<bool> EmitAssemblyRefs;

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
            dst.EmitAsmCatalogs = true;
            dst.EmitAsmRows = true;
            dst.EmitResBytes = true;
            dst.EmitAsmAnalysis = true;
            dst.EmitIntrinsicsInfo = true;
            dst.EmitStatements = true;
            dst.EmitApiMetadata = true;
            dst.CorrelateMembers = true;
            dst.EmitAssetIndex = true;
            dst.EmitAssetContent = false;
            dst.EmitSymbolicLiterals = true;
            dst.EmitApiBitMasks = true;
            dst.EmitHexIndex = true;
            dst.EmitCallData = true;
            dst.EmitJmpData = true;
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