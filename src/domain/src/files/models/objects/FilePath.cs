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
        public readonly struct FilePath : IFso<FilePath>
        {            
            public PathPart Name {get;}

            [MethodImpl(Inline)]
            public FilePath(PathPart name)
                => Name = name;

            [MethodImpl(Inline)]
            public string Format()
                => Name.Format();
        }       
    }
}