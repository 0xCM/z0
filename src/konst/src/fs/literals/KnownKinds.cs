//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct FileKinds
    {
        /// <summary>
        /// Defines a type-level representation of a file of kind <see cref='FileKind.Asm'/>
        /// </summary>
        [FileKind]
        public readonly struct Asm : IFileKind<Asm>
        {
            public const string Id = nameof(Asm);
        }

        [FileKind]
        public readonly struct Cil : IFileKind<Cil>
        {
            public const string Id = nameof(Cil);
        }

        [FileKind]
        public readonly struct Cs : IFileKind<Cs>
        {
            public const string Id = nameof(Cs);
        }

        [FileKind]
        public readonly struct Csv : IFileKind<Csv>
        {
            public const string Id = nameof(Csv);
        }

        [FileKind]
        public readonly struct Doc : IFileKind<Doc>
        {
            public const string Id = nameof(Doc);
        }

        [FileKind]
        public readonly struct Dll : IFileKind<Dll>
        {
            public const string Id = nameof(Dll);
        }


        [FileKind]
        public readonly struct Exe : IFileKind<Exe>
        {
            public const string Id = nameof(Exe);
        }

        [FileKind]
        public readonly struct Hex : IFileKind<Hex>
        {
            public const string Id = nameof(Hex);
        }

        [FileKind]
        public readonly struct Json : IFileKind<Json>
        {
            public const string Id = nameof(Json);
        }

        [FileKind]
        public readonly struct Txt : IFileKind<Txt>
        {
            public const string Id = nameof(Txt);
        }

        [FileKind]
        public readonly struct Xml : IFileKind<Xml>
        {
            public const string Id = nameof(Xml);
        }
    }
}