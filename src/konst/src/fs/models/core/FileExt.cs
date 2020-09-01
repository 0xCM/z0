//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FS
    {
        public readonly struct FileExt : IEntry<FileExt>
        {
            public PathPart Name {get;}

            [MethodImpl(Inline)]
            public static FileExt operator + (FileExt a, FileExt b)
                => ext(text.format("{0}.{1}",a.Name,b.Name));

            [MethodImpl(Inline)]
            public FileExt(PathPart name)
                => Name = name;

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Name.IsEmpty;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => Name.IsNonEmpty;
            }

            public static FileExt Empty
            {
                [MethodImpl(Inline)]
                get => new FileExt(PathPart.Empty);
            }

            public string SearchPattern
            {
                [MethodImpl(Inline)]
                get => text.format("*.{0}", Name);
            }

            [MethodImpl(Inline)]
            public string Format()
                => Name.ToString();

            public override string ToString()
                => Format();
        }
    }
}