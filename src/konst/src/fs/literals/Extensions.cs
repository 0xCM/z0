//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static FS.ExtensionNames;

    partial struct FS
    {
        public readonly struct Extensions
        {
            public static FileExt Csv => ext(csv);

            public static FileExt Asm => ext(asm);

            public static FileExt Cs => ext(cs);

            public static FileExt Json => ext(json);

            public static FileExt Dll => ext(dll);

            public static FileExt Exe => ext(exe);

            public static FileExt Lib => ext(lib);
        }
    }
}