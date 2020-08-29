//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;

    partial struct FS
    {
        public readonly struct FilePath : IEntry<FilePath>
        {
            public PathPart Name {get;}

            [MethodImpl(Inline)]
            public FilePath(PathPart name)
                => Name = name;

            public bool Exists
            {
                [MethodImpl(Inline)]
                get => File.Exists(Name);
            }

            public FileName FileName
            {
                [MethodImpl(Inline)]
                get => file(Path.GetFileName(Name));
            }

            public FolderPath FolderPath
            {
                [MethodImpl(Inline)]
                get => dir(Path.GetDirectoryName(Name));
            }

            public FolderName FolderName
            {
                [MethodImpl(Inline)]
                get => folder(Directory.GetParent(FolderPath.Name).Name);
            }

            public FileInfo Info
            {
                [MethodImpl(Inline)]
                get => new FileInfo(Name);
            }

            [MethodImpl(Inline)]
            public FilePath Replace(char src, char dst)
                => new FilePath(Name.Replace(src,dst));

            [MethodImpl(Inline)]
            public string Format()
                => Name.Format();

            public override string ToString()
                => Format();
        }
    }
}