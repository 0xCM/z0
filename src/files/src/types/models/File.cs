//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct File<T> : IFsEntry<File<T>>
        where T : IFileType
    {
        public FS.FilePath Location {get;}

        [MethodImpl(Inline)]
        public File(FS.FilePath location)
        {
            Location = location;
        }

        public FS.PathPart Name
        {
            [MethodImpl(Inline)]
            get => Location.Name;
        }
    }
}