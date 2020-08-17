//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using static FileExtNames;

    partial struct FS
    {        
        public readonly struct FileExtensions
        {
            public static FileExt Csv => ext(csv);

            public static FileExt Asm => ext(asm);

            public static FileExt Cs => ext(cs);

            public static FileExt Dll => ext(dll);

            public static FileExt Json => ext(json);
        }
    }
}