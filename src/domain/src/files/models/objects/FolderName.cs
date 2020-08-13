//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FileSystem
    {
        public readonly struct FolderName : IFso<FolderName>
        {            
            [MethodImpl(Inline)]
            public static FolderName operator +(FolderName a, FolderName b)
                => folder(text.format("{0}/{1}",a.Name, b.Name));

            public PathPart Name {get;}

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