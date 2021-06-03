//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct FS
    {
        public readonly struct FolderName : IFsEntry<FolderName>
        {
            public static FS.FolderName version(byte major, byte minor, byte revision)
                => FS.folder(string.Format("{0}.{1}.{2}", major, minor, revision));

            [MethodImpl(Inline)]
            public static FolderName operator +(FolderName a, FolderName b)
                => folder(string.Format("{0}/{1}", a.Name, b.Name));

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

            public static FolderName Empty
            {
                [MethodImpl(Inline)]
                get => new FolderName(PathPart.Empty);
            }

            [MethodImpl(Inline)]
            public FolderName Replace(char src, char dst)
                => new FolderName(Name.Replace(src,dst));

            [MethodImpl(Inline)]
            public FolderName Replace(string src, string dst)
                => new FolderName(Name.Replace(src,dst));

            [MethodImpl(Inline)]
            public FolderName(PathPart name)
                => Name = name;

            [MethodImpl(Inline)]
            public string Format()
                => Name.Format();

            public override string ToString()
                => Format();
        }
    }
}