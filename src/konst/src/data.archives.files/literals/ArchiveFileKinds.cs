//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static ArchiveFileKindNames;

    public readonly struct ArchiveFileKinds
    {
        public static FS.FileExt Asm => FS.ext(asm);

        public static FS.FileExt Csv => FS.ext(csv);

        public static FS.FileExt Cs => FS.ext(cs);

        public static FS.FileExt Dll => FS.ext(dll);

        public static FS.FileExt Xml => FS.ext(xml);

        public static FS.FileExt Json => FS.ext(json);

        public static FS.FileExt Exe => FS.ext(exe);

        public static FS.FileExt Txt => FS.ext(txt);

        public static FS.FileExt Il => FS.ext(il);

        public static FS.FileExt Hex => FS.ext(hex);

        public static FS.FileExt XCsv => FS.ext(xcsv);

        public static FS.FileExt PCsv => FS.ext(pcsv);
    }
}