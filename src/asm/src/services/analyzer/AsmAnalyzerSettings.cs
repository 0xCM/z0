//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public struct AsmAnalyzerSettings : ISettingsSet<AsmAnalyzerSettings>
    {
        public Setting<bool> EmitCalls;

        public Setting<bool> EmitJumps;

        public Setting<bool> EmitAsmDetails;

        public Setting<bool> EmitStatementIndex;

        public Setting<bool> EmitStatements;

        public static ref AsmAnalyzerSettings @default(out AsmAnalyzerSettings dst)
        {
            dst.EmitCalls = true;
            dst.EmitJumps = true;
            dst.EmitAsmDetails = true;
            dst.EmitStatementIndex = true;
            dst.EmitStatements = true;
            return ref dst;
        }
    }
}