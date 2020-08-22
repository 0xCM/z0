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
        const string FolderJoinPattern = "{0}/{1}";

        const string FileJoinPattern = "{0}/{1}";

        public readonly struct FolderPath : IEntry<FolderPath>
        {
            public static FolderPath Empty => new FolderPath(PathPart.Empty);

            public PathPart Name {get;}

            [MethodImpl(Inline)]
            public FolderPath(PathPart name)
                => Name = name;

            [MethodImpl(Inline)]
            public static FolderPath operator +(FolderPath a, FolderName b)
                => new FolderPath(text.format(FolderJoinPattern, a, b));

            [MethodImpl(Inline)]
            public static FilePath operator +(FolderPath a, FileName b)
                => new FilePath(text.format(FileJoinPattern, a, b));


            /// <summary>
            /// Specifies whether the represented directory actually exists within the file system
            /// </summary>
            public bool Exists
                => Directory.Exists(Name);

            public DirectoryInfo Info
            {
                [MethodImpl(Inline)]
                get => new DirectoryInfo(Name);
            }

            [MethodImpl(Inline)]
            public string Format()
                => Name.Format();

            public override string ToString()
                => Format();
        }
    }
}