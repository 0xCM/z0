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
        public readonly struct FolderPath : IFso<FolderPath>
        {
            [MethodImpl(Inline)]
            public static FolderPath operator +(FolderPath a, FolderName b)
                => new FolderPath(text.format("{0}/{1}",a,b));

            [MethodImpl(Inline)]
            public static FilePath operator +(FolderPath a, FileName b)
                => new FilePath(text.format("{0}/{1}",a,b));

            public PathPart Name {get;}

            [MethodImpl(Inline)]
            public FolderPath(PathPart name)
                => Name = name;


            [MethodImpl(Inline)]
            public string Format()
                => Name.Format();

            public override string ToString()
                => Format();
        }        
    }
}