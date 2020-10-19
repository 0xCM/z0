//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [LiteralProvider]
    public readonly struct ArchiveFileKindNames
    {
        const string dot = ".";

        const string x = nameof(x);

        const string p = nameof(p);

        /// <summary>
        /// Defines the 'txt' literal
        /// </summary>
        public const string txt = nameof(txt);

        /// <summary>
        /// Defines the 'il' literal
        /// </summary>
        public const string il = nameof(il);

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
        /// Defines the 'hex' literal
        /// </summary>
        public const string hex = nameof(hex);

        /// <summary>
        /// Defines the 'log' literal
        /// </summary>
        public const string log = nameof(log);

        /// <summary>
        /// Defines the 'obj' literal
        /// </summary>
        public const string obj = nameof(obj);

        /// <summary>
        /// Defines the 'status' literal
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

        /// <summary>
        /// Defines the 'cmd' literal
        /// </summary>
        public const string cmd = nameof(cmd);

        /// <summary>
        /// Defines the 'x.csv' literal
        /// </summary>
        public const string xcsv = x + dot + csv;

        /// <summary>
        /// Defines the 'p.csv' literal
        /// </summary>
        public const string pcsv = p + dot + csv;
    }
}
