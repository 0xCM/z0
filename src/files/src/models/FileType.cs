//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct FileType
    {
        public FileKind Kind {get;}

        public Index<FS.FileExt> Extensions {get;}

        [MethodImpl(Inline)]
        public FileType(FileKind kind, FS.FileExt[] extensions)
        {
            Kind = kind;
            Extensions = extensions;
        }

        public string Format()
            => FS.format(this);

        public override string ToString()
            => Format();
    }
}