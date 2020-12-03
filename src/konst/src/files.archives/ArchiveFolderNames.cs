//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [LiteralProvider]
    public readonly struct ArchiveFolderNames
    {
        public const string Test = "test";

        public const string CilData = "cil";

        public const string AppsFolder = "apps";

        public const string Logs = "logs";

        public const string Extracts = "extracts";

        public const string Parsed = "parsed";

        public const string Hex = "hex";

        public const string Imm = "imm";

        public const string Respack = "respack";

        public const string ContentFolder = "content";

        public const string Asm = "asm";

        public const string AsmSemantic = "asm.semantic";

        public const string IndexFolder = "index";

        public const string TableFolder = "tables";

        public const string ErrorLog = "errors";

        public const string StatusLog = "status";

        public const string Capture = "capture";

        public const string Results = "results";

        public const string Config = ".config";

        public const string ArchiveFolder = "archive";

        public const string ArtifactFolder = "artifacts";

        public const string RespackContent = Respack + "/" + ContentFolder;
    }
}
