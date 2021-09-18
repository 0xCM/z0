//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class FileTypes
    {
        public readonly struct ObjAsm : ITypedFile<ObjAsm>
        {
            public FS.FilePath Path {get;}

            [MethodImpl(Inline)]
            public ObjAsm(FS.FilePath path)
            {
                Path = path;
            }

            public FileKind Kind
                => FileKind.ObjAsm;

            [MethodImpl(Inline)]
            public static implicit operator ObjAsm(FS.FilePath src)
                => new ObjAsm(src);

            [MethodImpl(Inline)]
            public static implicit operator FS.FilePath(ObjAsm src)
                => src.Path;

            [MethodImpl(Inline)]
            public static implicit operator TypedFile(ObjAsm src)
                => new TypedFile(src.Kind, src.Path);
        }
    }
}