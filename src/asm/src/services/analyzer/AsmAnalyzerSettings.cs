//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public struct AsmAnalyzerSettings : ISettings<AsmAnalyzerSettings>
    {
        public bool EmitCalls;

        public bool EmitJumps;

        public bool EmitAsmDetails;

        public bool EmitStatementIndex;

        public bool EmitHostStatements;

        public bool EmitBitstringIndex;

        public static ref AsmAnalyzerSettings @default(out AsmAnalyzerSettings dst)
        {
            dst.EmitCalls = true;
            dst.EmitJumps = true;
            dst.EmitAsmDetails = true;
            dst.EmitStatementIndex = true;
            dst.EmitHostStatements = true;
            dst.EmitBitstringIndex = true;
            return ref dst;
        }
    }
}