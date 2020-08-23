//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct FS
    {
        [LiteralProvider]
        public readonly struct ExtensionNames
        {
            public const string asm = nameof(asm);

            public const string csv = nameof(csv);

            public const string cs = nameof(cs);

            public const string dll = nameof(dll);

            public const string exe = nameof(exe);

            public const string json = nameof(json);

            public const string pdb = nameof(pdb);

            public const string xml = nameof(xml);

            public const string lib = nameof(lib);
        }
    }
}