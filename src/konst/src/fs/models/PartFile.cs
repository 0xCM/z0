//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct PartFile
    {
        public readonly PartId Part;

        public readonly PartFileClass Kind;

        public readonly FS.FilePath Path;

        [MethodImpl(Inline)]
        public PartFile(PartId part, PartFileClass kind, FilePath path)
        {
            Part = part;
            Kind = kind;
            Path = FS.path(path.Name);
        }

        public PartFile(PartId part, PartFileClass kind, FS.FilePath path)
        {
            Part = part;
            Kind = kind;
            Path = path;
        }

    }
}