//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public struct CliEmissionOptions
    {
        public Setting<bool> EmitAssemblyRefs;

        public Setting<bool> EmitSectionHeaders;

        public Setting<bool> EmitMsilMetadata;

        public Setting<bool> EmitCliConstants;

        public Setting<bool> EmitCliStrings;

        public Setting<bool> EmitCliBlobs;

        public Setting<bool> EmitApiMetadata;

        public Setting<bool> EmitImageContent;

        public Setting<bool> EmitFieldMetadata;

        public Setting<bool> EmitRowStats;

        public Setting<bool> EmitMethodDefs;

        public static CliEmissionOptions @default()
        {
            var dst = new CliEmissionOptions();
            dst.EmitImageContent = true;
            dst.EmitSectionHeaders = true;
            dst.EmitMsilMetadata = true;
            dst.EmitCliStrings = true;
            dst.EmitCliBlobs = true;
            dst.EmitCliConstants = true;
            dst.EmitFieldMetadata = true;
            dst.EmitApiMetadata = true;
            dst.EmitAssemblyRefs = true;
            dst.EmitRowStats = true;
            dst.EmitMethodDefs = true;
            return dst;
        }
    }
}