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

        public readonly PartFileKind Kind;

        public readonly FilePath Path;

        [MethodImpl(Inline)]
        public PartFile(PartId part, PartFileKind kind, FilePath path)
        {
            Part = part;
            Kind = kind;
            Path = path;
        }
    }
}