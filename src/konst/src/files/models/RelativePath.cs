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
        public readonly struct RelativePath : IFsEntry<RelativePath>
        {
            public PathPart Name {get;}

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

            [MethodImpl(Inline)]
            public RelativePath(PathPart name)
                => Name = name;

           [MethodImpl(Inline)]
            public RelativePath Replace(char src, char dst)
                => new RelativePath(Name.Replace(src,dst));

            [MethodImpl(Inline)]
            public RelativePath Replace(string src, string dst)
                => new RelativePath(Name.Replace(src,dst));

            [MethodImpl(Inline)]
            public string Format()
                => Name.Format();

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static RelativePath operator +(RelativePath a, RelativePath b)
                => relative(text.format("{0}/{1}",a.Name, b.Name));

            [MethodImpl(Inline)]
            public static RelativePath operator +(RelativePath a, FolderName b)
                => relative(text.format("{0}/{1}",a.Name, b.Name));

            [MethodImpl(Inline)]
            public static RelativePath operator +(FolderName a, RelativePath b)
                => relative(text.format("{0}/{1}",a.Name, b.Name));

            [MethodImpl(Inline)]
            public static RelativePath operator +(FolderPath a, RelativePath b)
                => relative(text.format("{0}/{1}",a.Name, b.Name));

            [MethodImpl(Inline)]
            public static RelativePath operator +(RelativePath a, FileName b)
                => relative(text.format("{0}/{1}",a.Name, b.Name));

            public static RelativePath Empty
            {
                [MethodImpl(Inline)]
                get => new RelativePath(PathPart.Empty);
            }
        }
    }
}