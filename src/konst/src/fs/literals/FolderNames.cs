//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct FS
    {
        /// <summary>
        /// Common Folder Name Literals
        /// </summary>
        [LiteralResource]
        public readonly struct FolderNames
        {
            public const string Test = "test";

            public const string CilData = "cil";

            public const string Apps = "apps";

            public const string Logs = "logs";

            public const string Parsed = "parsed";

            public const string Hex = "hex";

            public const string Imm = "imm";

            public const string Respack = "respack";

            public const string Content = "content";

            public const string Asm = "asm";

            public const string Index = "index";

            public const string Tables = "tables";

            public const string ErrorLog = "errors";

            public const string StatusLog = "status";

            public const string Capture = "capture";

            public const string Results = "results";

            public const string Config = ".config";

            public const string Archive = "archive";

            public const string Artifacts = "artifacts";

            public const string RespackContent = Respack + "/" + Content;
        }
    }
}