//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public struct MachineOptions : ISettingsSet<MachineOptions>
    {
        public Setting<bool> EmitAssetIndex;

        public Setting<bool> CollectApiDocs;

        public Setting<bool> EmitImageContent;

        public Setting<bool> EmitSectionHeaders;

        public Setting<bool> EmitMsilRecords;

        public Setting<bool> EmitCliStrings;

        public Setting<bool> EmitCliBlobs;

        public Setting<bool> EmitCliConstants;

        public Setting<bool> EmitApiMetadata;

        public Setting<bool> EmitFieldLiterals;

        public Setting<bool> EmitSymbolicLiterals;

        public Setting<bool> EmitAsmCatalogs;

        public Setting<bool> EmitAsmRows;

        public Setting<bool> EmitResBytes;

        public Setting<bool> EmitAsmAnalysis;

        public Setting<bool> EmitIntrinsicsInfo;

        public Setting<bool> EmitStatements;

        public Setting<bool> CorrelateMembers;

        public Setting<bool> EmitAsmBitstrings;

        public Setting<bool> EmitAssetContent;

        public Setting<bool> EmitApiBitMasks;

        public static MachineOptions @default()
        {
            var dst = new MachineOptions();
            dst.CollectApiDocs = true;
            dst.EmitImageContent = true;
            dst.EmitSectionHeaders = true;
            dst.EmitMsilRecords = true;
            dst.EmitCliStrings = true;
            dst.EmitCliBlobs = true;
            dst.EmitCliConstants = true;
            dst.EmitFieldLiterals = true;
            dst.EmitAsmCatalogs = true;
            dst.EmitAsmRows = true;
            dst.EmitResBytes = true;
            dst.EmitAsmAnalysis = true;
            dst.EmitIntrinsicsInfo = true;
            dst.EmitStatements = true;
            dst.EmitApiMetadata = true;
            dst.CorrelateMembers = true;
            dst.EmitAsmBitstrings = true;
            dst.EmitAssetIndex = true;
            dst.EmitAssetContent = true;
            dst.EmitSymbolicLiterals = true;
            dst.EmitApiBitMasks = true;
            return dst;
        }

        public override string ToString()
            => (this as ISettingsSet).Format();
    }
}