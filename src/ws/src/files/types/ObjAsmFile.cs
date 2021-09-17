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
        public readonly struct ObjAsmFile : ITypedFile<ObjAsmFile>
        {
            public FS.FilePath Path {get;}

            [MethodImpl(Inline)]
            public ObjAsmFile(FS.FilePath path)
            {
                Path = path;
            }

            public FileKind Kind
                => FileKind.ObjAsm;

            [MethodImpl(Inline)]
            public static implicit operator ObjAsmFile(FS.FilePath src)
                => new ObjAsmFile(src);

            [MethodImpl(Inline)]
            public static implicit operator FS.FilePath(ObjAsmFile src)
                => src.Path;

            [MethodImpl(Inline)]
            public static implicit operator TypedFile(ObjAsmFile src)
                => new TypedFile(src.Kind, src.Path);
        }
    }
}