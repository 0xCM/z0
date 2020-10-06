//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static ArchiveNames.Ext;

    using X = ArchiveExt;
    using K = FileKinds;

    public readonly struct FileKind
    {
        public static K.Csv Csv => default;

        public static K.Asm Asm => default;

        public static K.Dll Dll => default;

        public static K.Cil Cil => default;
    }

    public readonly struct FileKinds
    {
        [FileKind]
        public readonly struct PCsv : IFileKind<PCsv>
        {

        }

        [FileKind]
        public readonly struct XCsv : IFileKind<XCsv>
        {

        }

        [FileKind]
        public readonly struct Asm : IFileKind<Asm>
        {
            public string Name
                => asm;

            public static implicit operator FS.FileExt(Asm src)
                => X.Asm;
        }

        [FileKind]
        public readonly struct Cil : IFileKind<Cil>
        {
            public string Name
                => cil;

            public static implicit operator FS.FileExt(Cil src)
                => ArchiveExt.Cil;
        }

        [FileKind]
        public readonly struct Cs : IFileKind<Cs>
        {
            public string Name
                => cs;

            public static implicit operator FS.FileExt(Cs src)
                => X.Cs;
        }

        [FileKind]
        public readonly struct Csv : IFileKind<Csv>
        {
            public string Name
                => csv;

            public static implicit operator FS.FileExt(Csv src)
                => X.Csv;
        }

        [FileKind]
        public readonly struct Doc : IFileKind<Doc>
        {

        }

        [FileKind]
        public readonly struct Dll : IFileKind<Dll>
        {
            public string Name
                => dll;

            public static implicit operator FS.FileExt(Dll src)
                => X.Dll;
        }

        [FileKind]
        public readonly struct Exe : IFileKind<Exe>
        {
            public string Name
                => exe;

            public static implicit operator FS.FileExt(Exe src)
                => X.Exe;
        }

        [FileKind]
        public readonly struct Hex : IFileKind<Hex>
        {
            public string Name
                => hex;

            public static implicit operator FS.FileExt(Hex src)
                => X.Hex;
        }

        [FileKind]
        public readonly struct Json : IFileKind<Json>
        {
            public string Name
                => json;

            public static implicit operator FS.FileExt(Json src)
                => X.Json;
        }

        [FileKind]
        public readonly struct Txt : IFileKind<Txt>
        {
            public static implicit operator FS.FileExt(Txt src)
                => X.Txt;
        }

        [FileKind]
        public readonly struct Xml : IFileKind<Xml>
        {
            public string Name
                => xml;

            public static implicit operator FS.FileExt(Xml src)
                => X.Xml;
        }

        [FileKind]
        public readonly struct Log : IFileKind<Log>
        {
            public string Name
                => log;

            public static implicit operator FS.FileExt(Log src)
                => X.Log;
        }
    }
}