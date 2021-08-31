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
        public FileKind FileKind {get;}

        public AsciBlock16 FileExt {get;}

        [MethodImpl(Inline)]
        public FileType(FileKind kind, AsciBlock16 ext)
        {
            FileKind = kind;
            FileExt = ext;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => FileKind == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => FileKind != 0;
        }

        public string Format()
            => FileKind.Format();

        public override string ToString()
            => Format();

        public static FileType Empty
        {
            [MethodImpl(Inline)]
            get => new FileType(FileKind.None, AsciBlock16.Empty);
        }
    }
}