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

        public readonly struct FolderPath : IFso<FolderPath>
        {
            [MethodImpl(Inline)]
            public static FolderPath operator +(FolderPath a, FolderName b)
                => new FolderPath(text.format(FolderJoinPattern, a, b));

            [MethodImpl(Inline)]
            public static FilePath operator +(FolderPath a, FileName b)
                => new FilePath(text.format(FileJoinPattern, a, b));

            public PathPart Name {get;}

            [MethodImpl(Inline)]
            public FolderPath(PathPart name)
                => Name = name;
            
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