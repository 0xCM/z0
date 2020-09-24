//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct ArchiveNames
    {
        /// <summary>
        /// Common File eXtension name Literals
        /// </summary>
        [LiteralProvider]
        public readonly struct Ext
        {
            /// <summary>
            /// Defines the 'asm' literal
            /// </summary>
            public const string asm = nameof(asm);

            /// <summary>
            /// Defines the 'csv' literal
            /// </summary>
            public const string csv = nameof(csv);

            /// <summary>
            /// Defines the 'cs' literal
            /// </summary>
            public const string cs = nameof(cs);

            /// <summary>
            /// Defines the 'cil' literal
            /// </summary>
            public const string cil = nameof(cil);

            /// <summary>
            /// Defines the 'cpp' literal
            /// </summary>
            public const string cpp = nameof(cpp);

            /// <summary>
            /// Defines the 'dll' literal
            /// </summary>
            public const string dll = nameof(dll);

            /// <summary>
            /// Defines the 'json' literal
            /// </summary>
            public const string json = nameof(json);

            /// <summary>
            /// Defines the 'pdb' literal
            /// </summary>
            public const string pdb = nameof(pdb);

            /// <summary>
            /// Defines the 'xml' literal
            /// </summary>
            public const string xml = nameof(xml);

            /// <summary>
            /// Defines the 'exe' literal
            /// </summary>
            public const string exe = nameof(exe);

            /// <summary>
            /// Defines the 'h' literal
            /// </summary>
            public const string h = nameof(h);

            /// <summary>
            /// Defines the 'txt' literal
            /// </summary>
            public const string txt = nameof(txt);

            /// <summary>
            /// Defines the 'il' literal
            /// </summary>
            public const string il = nameof(il);

            /// <summary>
            /// Defines the 'hex' literal
            /// </summary>
            public const string hex = nameof(hex);

            /// <summary>
            /// Defines the 'log' literal
            /// </summary>
            public const string log = nameof(log);

            /// <summary>
            /// Defines the 'h' literal
            /// </summary>
            public const string obj = nameof(obj);

            /// <summary>
            /// Defines the 'stdout' literal
            /// </summary>
            public const string status = nameof(status);

            /// <summary>
            /// Defines the 'errors' literal
            /// </summary>
            public const string error = nameof(error);

            /// <summary>
            /// Defines the 'lib' literal
            /// </summary>
            public const string lib = nameof(lib);
        }

        /// <summary>
        /// Common Folder Name Literals
        /// </summary>
        [LiteralResource]
        public readonly struct Folders
        {
            public const string Test = "test";

            public const string CilData = "cil";

            public const string AppsFolder = "apps";

            public const string LogFolder = "logs";

            public const string Parsed = "parsed";

            public const string HexFolder = "hex";

            public const string ImmFolder = "imm";

            public const string Respack = "respack";

            public const string ContentFolder = "content";

            public const string AsmFolder = "asm";

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
}