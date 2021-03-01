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

        public Setting<bool> EmitPeData;

        public Setting<bool> EmitSectionHeaders;

        public Setting<bool> EmitCilRecords;

        public Setting<bool> EmitCliStrings;

        public Setting<bool> EmitCliBlobs;

        public Setting<bool> EmitCliConstants;

        public Setting<bool> EmitLiteralCatalogs;

        public Setting<bool> EmitAsmCatalogs;

        public Setting<bool> EmitAsmSemantic;

        public Setting<bool> EmitAsmRows;

        public Setting<bool> EmitResBytes;

        public Setting<bool> EmitAsmBranches;

        public static EtlSettings @default()
        {
            var dst = new EtlSettings();
            dst.RunXed = true;
            dst.EmitResourceData = false;
            dst.CollectApiDocs = false;
            dst.EmitPeData = true;
            dst.EmitSectionHeaders = true;
            dst.EmitCilRecords = true;
            dst.EmitCliStrings = true;
            dst.EmitCliBlobs = true;
            dst.EmitCliConstants = true;
            dst.EmitLiteralCatalogs = true;
            dst.EmitAsmCatalogs = true;
            dst.EmitAsmSemantic = false;
            dst.EmitAsmRows = true;
            dst.EmitResBytes = true;
            dst.EmitAsmBranches = true;
            return dst;
        }

        public override string ToString()
            => (this as ISettingsSet).Format();
    }
}