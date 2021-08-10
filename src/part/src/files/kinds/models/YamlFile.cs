//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct YamlFile : IFile
    {
        public FS.FilePath Path {get;}

        [MethodImpl(Inline)]
        public YamlFile(FS.FilePath path)
        {
            Path = path;
        }
    }
}