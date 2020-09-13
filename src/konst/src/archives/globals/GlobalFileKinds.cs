//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static FS;
    using static GlobalExtensionNames;

    using X = GlobalExtensions;

    public readonly struct GlobalFileKinds
    {
        [FileKind]
        public readonly struct PCsv : IFileKind<PCsv>
        {
            public const string Id = nameof(PCsv);
        }


        [FileKind]
        public readonly struct XCsv : IFileKind<XCsv>
        {
            public const string Id = nameof(XCsv);
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
                => GlobalExtensions.Cil;
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
            public const string Id = nameof(Doc);
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

        }

        [FileKind]
        public readonly struct Json : IFileKind<Json>
        {

        }

        [FileKind]
        public readonly struct Txt : IFileKind<Txt>
        {
            public const string Id = nameof(Txt);
        }

        [FileKind]
        public readonly struct Xml : IFileKind<Xml>
        {
            public string Name
                => xml;

            public static implicit operator FS.FileExt(Xml src)
                => X.Xml;
        }
    }
}