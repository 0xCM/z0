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
        public readonly struct FolderPath : IFileSystemObject<FolderPath>
        {
            public PathPart Name {get;}

            [MethodImpl(Inline)]
            public FolderPath(PathPart name)
                => Name = name;
        }        
    }
}