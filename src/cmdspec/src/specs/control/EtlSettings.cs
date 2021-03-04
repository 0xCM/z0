//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public struct EtlSettings : ISettingsSet<EtlSettings>
    {
        public Setting<bool> RunXed;

        public Setting<bool> EmitResourceData;

        public Setting<bool> CollectApiDocs;

        public Setting<bool> EmitImageContent;

        public Setting<bool> EmitSectionHeaders;

        public Setting<bool> EmitCilRecords;

        public Setting<bool> EmitCliStrings;

        public Setting<bool> EmitCliBlobs;

        public Setting<bool> EmitCliConstants;

        public Setting<bool> EmitLiteralCatalogs;

        public Setting<bool> EmitAsmCatalogs;

        public Setting<bool> EmitAsmRows;

        public Setting<bool> EmitResBytes;

        public Setting<bool> EmitAsmAnalysis;

        public Setting<bool> EmitIntrinsicsInfo;

        public static EtlSettings @default()
        {
            var dst = new EtlSettings();
            dst.RunXed = false;
            dst.EmitResourceData = false;
            dst.CollectApiDocs = false;
            dst.EmitImageContent = true;
            dst.EmitSectionHeaders = true;
            dst.EmitCilRecords = true;
            dst.EmitCliStrings = true;
            dst.EmitCliBlobs = true;
            dst.EmitCliConstants = true;
            dst.EmitLiteralCatalogs = true;
            dst.EmitAsmCatalogs = true;
            dst.EmitAsmRows = true;
            dst.EmitResBytes = true;
            dst.EmitAsmAnalysis = true;
            dst.EmitIntrinsicsInfo = true;
            return dst;
        }

        public override string ToString()
            => (this as ISettingsSet).Format();
    }
}